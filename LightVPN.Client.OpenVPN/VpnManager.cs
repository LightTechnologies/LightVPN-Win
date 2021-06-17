﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using LightVPN.Client.OpenVPN.EventArgs;
using LightVPN.Client.OpenVPN.Exceptions;
using LightVPN.Client.OpenVPN.Interfaces;
using LightVPN.Client.OpenVPN.Models;
using LightVPN.Client.OpenVPN.Resources;
using LightVpn.Client.OpenVpn.Utils;
using LightVPN.Client.OpenVPN.Utils;

namespace LightVPN.Client.OpenVPN
{
    /// <inheritdoc cref="System.IAsyncDisposable" />
    /// <summary>
    ///     Cross-platform class for managing the connection to a OpenVPN server.
    /// </summary>
    internal sealed class VpnManager : IVpnManager, IAsyncDisposable
    {
        private readonly OpenVpnConfiguration _configuration;
        private readonly Process _ovpnProcess;
        private readonly LogDataManager _logDataManager;
        private ManagementSocketHandler _managementSocketHandler;

        /// <summary>
        ///     Fired when a line of output is spat out by the OpenVPN process
        /// </summary>
        public event IVpnManager.OutputReceived OnOutputReceived;

        /// <summary>
        ///     Fired when a connection to a VPN server was successful
        /// </summary>
        public event IVpnManager.Connected OnConnected;

        /// <summary>
        ///     Returns whether an active connection is established to a VPN server
        /// </summary>
        public bool IsConnected { get; private set; }

        /// <summary>
        ///     Returns whether OpenVPN is attempting to connect to a VPN server
        /// </summary>
        public bool IsConnecting { get; private set; }

        /// <summary>
        ///     Returns whether this instance has been disposed or not
        /// </summary>
        public bool IsDisposed { get; private set; }

        /// <summary>
        ///     The configuration file that OpenVPN is using to connect to a VPN server
        /// </summary>
        public string ConfigurationPath { get; private set; }

        public VpnManager(OpenVpnConfiguration configuration)
        {
            TerminateExistingProcesses();

            _configuration = configuration;
            _logDataManager = new LogDataManager(configuration.OpenVpnLogPath);

            _ovpnProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    FileName = _configuration.OpenVpnPath,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    WorkingDirectory = Path.GetDirectoryName(_configuration.OpenVpnPath) ??
                                       throw new ArgumentNullException(nameof(configuration)),
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false
                }
            };

            _ovpnProcess.OutputDataReceived += OVpnProcessOnOutputDataReceived;
            _ovpnProcess.ErrorDataReceived += OVpnProcessOnErrorDataReceived;
        }

        /// <summary>
        ///     Searches and terminates any active OpenVPN processes (in-case the child process tracker fails)
        /// </summary>
        private static void TerminateExistingProcesses()
        {
            try
            {
                Process.GetProcessesByName("openvpn").ToList().ForEach(x => x.Kill());
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        ///     Asynchronously disconnects from a VPN server
        /// </summary>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <exception cref="InvalidOperationException">Thrown when a connection hasn't been established or is being established</exception>
        public async Task DisconnectAsync(CancellationToken cancellationToken = default)
        {
            if (!IsConnecting && !IsConnected)
                throw new InvalidOperationException("Not connected or connecting to a VPN server");

            _ovpnProcess.CancelErrorRead();
            _ovpnProcess.CancelOutputRead();

            await _managementSocketHandler.SendShutdownSignalAsync(cancellationToken);

            await _ovpnProcess.WaitForExitAsync(cancellationToken);

            IsConnected = false;
            IsConnecting = false;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Connects to the server provided in the configuration file
        /// </summary>
        /// <param name="configurationPath">Path to the OpenVPN configuration file</param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="T:System.InvalidOperationException">
        ///     Thrown when attempting to connect whilst connected or connecting
        ///     or if the configuration file doesn't exist
        /// </exception>
        public async Task ConnectAsync(string configurationPath, CancellationToken cancellationToken = default)
        {
            if (IsConnected || IsConnecting) throw new InvalidOperationException("Already connected to a VPN server");

            if (!File.Exists(configurationPath))
                throw new InvalidOperationException("The configuration file doesn't exist");

            _managementSocketHandler = new ManagementSocketHandler(ManagementSocketHandler.GetAvailablePort(45555));

            // Set the process args
            _ovpnProcess.StartInfo.Arguments =
                $"--config {configurationPath} --register-dns --dev-node {_configuration.TapAdapterName} --management 127.0.0.1 {_managementSocketHandler.Port}";

            ConfigurationPath = configurationPath;

            _ovpnProcess.Start();

            _ovpnProcess.BeginErrorReadLine();
            _ovpnProcess.BeginOutputReadLine();

            ChildProcessTracker.AddProcess(_ovpnProcess);

            await _managementSocketHandler.ConnectAsync(cancellationToken);

            IsConnecting = true;
        }

        /// <summary>
        ///     Fired when the OpenVPN process instance sends a error output through stdout
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void OVpnProcessOnErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Data)) return;

            OnOutputReceived?.Invoke(this, new OutputReceivedEventArgs(e.Data));
        }

        /// <summary>
        ///     Fired when the OpenVPN process instance sends a regular output through stdout
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        /// <exception cref="AuthenticationException">Thrown when the authentication process fails</exception>
        /// <exception cref="FileLoadException">Thrown when OpenVPN rejects a configuration file for whatever reason</exception>
        /// <exception cref="UnknownErrorException">Thrown when OpenVPN spits out 'Unknown error' into stdout</exception>
        /// <exception cref="TimeoutException">Thrown when the connection to a VPN server times out</exception>
        private async void OVpnProcessOnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Data)) return;

            OnOutputReceived?.Invoke(this, new OutputReceivedEventArgs(e.Data));

            _logDataManager.WriteLine(e.Data);

            switch (e.Data)
            {
                case { } when e.Data.Contains(StringTable.OVPN_OUT_AUTH_FAILED):
                    await DisconnectAsync();
                    throw new AuthenticationException(StringTable.OVPN_AUTH_FAILED);
                case { } when e.Data.Contains(StringTable.OVPN_OUT_CONFIG_ERROR):
                    await DisconnectAsync();
                    throw new FileLoadException(StringTable.OVPN_CONFIG_ERROR);
                case { } when e.Data.Contains(StringTable.OVPN_OUT_UNKNOWN_ERROR):
                    await DisconnectAsync();
                    throw new UnknownErrorException(StringTable.OVPN_UNKNOWN_ERROR);
                case { } when e.Data.Contains(StringTable.OVPN_OUT_SERVER_TIMEOUT):
                    await DisconnectAsync();
                    throw new TimeoutException(StringTable.OVPN_SERVER_TIMEOUT);
                case { } when e.Data.Contains(StringTable.OVPN_OUT_INIT_COMPLETE):
                    IsConnected = true;
                    OnConnected?.Invoke(this, new ConnectedEventArgs(e.Data));
                    break;
            }
        }

        /// <inheritdoc cref="IAsyncDisposable.DisposeAsync" />
        /// <summary>
        ///     Disposes the manager instance
        /// </summary>
        public async ValueTask DisposeAsync()
        {
            if (IsConnected || IsConnecting) await DisconnectAsync();

            _ovpnProcess?.Dispose();

            IsDisposed = true;
        }
    }
}