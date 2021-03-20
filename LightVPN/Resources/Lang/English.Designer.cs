﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightVPN.Resources.Lang {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class English {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal English() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LightVPN.Resources.Lang.English", typeof(English).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not authenticate the LightVPN API correctly. Please make sure you do not have any web-interception programs open..
        /// </summary>
        internal static string API_CERT_INVALID {
            get {
                return ResourceManager.GetString("API_CERT_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not access the LightVPN API correctly. Please check your internet connection or try again later.
        ///
        ///Status code:.
        /// </summary>
        internal static string API_NO_RESP {
            get {
                return ResourceManager.GetString("API_NO_RESP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid username or password..
        /// </summary>
        internal static string AUTH_INVALID {
            get {
                return ResourceManager.GetString("AUTH_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your subscription has expired or is not active. Purchase a subscription at https://lightvpn.cc.
        /// </summary>
        internal static string AUTH_SUB {
            get {
                return ResourceManager.GetString("AUTH_SUB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An update is available, please restart LightVPN to install it..
        /// </summary>
        internal static string CLIENT_UPDATE {
            get {
                return ResourceManager.GetString("CLIENT_UPDATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to service.
        /// </summary>
        internal static string DIALOG_SERVICE {
            get {
                return ResourceManager.GetString("DIALOG_SERVICE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to exit LightVPN?
        ///
        ///Your open VPN connection will be terminated!.
        /// </summary>
        internal static string NOTIFY_CLOSE {
            get {
                return ResourceManager.GetString("NOTIFY_CLOSE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to logout?.
        /// </summary>
        internal static string NOTIFY_LOGOUT {
            get {
                return ResourceManager.GetString("NOTIFY_LOGOUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server configuration file cache is corrupt, LightVPN will redownload the latest cache for you..
        /// </summary>
        internal static string OVPN_CONFIG_FAIL {
            get {
                return ResourceManager.GetString("OVPN_CONFIG_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to connect to the specified server. Please try again or check your credentials.
        /// </summary>
        internal static string OVPN_CONN_FAIL {
            get {
                return ResourceManager.GetString("OVPN_CONN_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t find the OpenVPN binaries, please reinstall the LightVPN Client.
        /// </summary>
        internal static string OVPN_ERROR {
            get {
                return ResourceManager.GetString("OVPN_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OpenVPN binary failed to start, the error will anonymously be reported to LightVPN. The error can be listed below.
        /// </summary>
        internal static string OVPN_START_EXCEPTION {
            get {
                return ResourceManager.GetString("OVPN_START_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debug.
        /// </summary>
        internal static string PAGES_DEBUG {
            get {
                return ResourceManager.GetString("PAGES_DEBUG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome!.
        /// </summary>
        internal static string PAGES_HOME {
            get {
                return ResourceManager.GetString("PAGES_HOME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SIGN IN.
        /// </summary>
        internal static string PAGES_LOGIN_BTN {
            get {
                return ResourceManager.GetString("PAGES_LOGIN_BTN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        internal static string PAGES_PASSWORD {
            get {
                return ResourceManager.GetString("PAGES_PASSWORD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings.
        /// </summary>
        internal static string PAGES_SETTINGS {
            get {
                return ResourceManager.GetString("PAGES_SETTINGS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto connect.
        /// </summary>
        internal static string PAGES_SETTINGS_AUTO_CONNECT {
            get {
                return ResourceManager.GetString("PAGES_SETTINGS_AUTO_CONNECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LightVPN will automatically connect when you open the program.
        /// </summary>
        internal static string PAGES_SETTINGS_AUTO_CONNECT_DESC {
            get {
                return ResourceManager.GetString("PAGES_SETTINGS_AUTO_CONNECT_DESC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start when Windows starts.
        /// </summary>
        internal static string PAGES_SETTINGS_AUTO_START {
            get {
                return ResourceManager.GetString("PAGES_SETTINGS_AUTO_START", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LightVPN will open when you boot up Windows.
        /// </summary>
        internal static string PAGES_SETTINGS_AUTO_START_DESC {
            get {
                return ResourceManager.GetString("PAGES_SETTINGS_AUTO_START_DESC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General.
        /// </summary>
        internal static string PAGES_SETTINGS_CARD_GENERAL {
            get {
                return ResourceManager.GetString("PAGES_SETTINGS_CARD_GENERAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dark mode.
        /// </summary>
        internal static string PAGES_SETTINGS_DARK_MODE {
            get {
                return ResourceManager.GetString("PAGES_SETTINGS_DARK_MODE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kill switch.
        /// </summary>
        internal static string PAGES_SETTINGS_KILL_SWITCH {
            get {
                return ResourceManager.GetString("PAGES_SETTINGS_KILL_SWITCH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All other traffic will be blocked when you aren&apos;t connected to LightVPN.
        /// </summary>
        internal static string PAGES_SETTINGS_KILL_SWITCH_DESC {
            get {
                return ResourceManager.GetString("PAGES_SETTINGS_KILL_SWITCH_DESC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tools.
        /// </summary>
        internal static string PAGES_TOOLS {
            get {
                return ResourceManager.GetString("PAGES_TOOLS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Troubleshoot.
        /// </summary>
        internal static string PAGES_TOOLS_CARD_TROUBLESHOOT {
            get {
                return ResourceManager.GetString("PAGES_TOOLS_CARD_TROUBLESHOOT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to REINSTALL.
        /// </summary>
        internal static string PAGES_TOOLS_TAP_BTN {
            get {
                return ResourceManager.GetString("PAGES_TOOLS_TAP_BTN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your OpenVPN TAP adapter will be reinstalled and reconfigured.
        /// </summary>
        internal static string PAGES_TOOLS_TAP_DESC {
            get {
                return ResourceManager.GetString("PAGES_TOOLS_TAP_DESC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reinstall OpenVPN TAP Adapter.
        /// </summary>
        internal static string PAGES_TOOLS_TAP_TITLE {
            get {
                return ResourceManager.GetString("PAGES_TOOLS_TAP_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username.
        /// </summary>
        internal static string PAGES_USERNAME {
            get {
                return ResourceManager.GetString("PAGES_USERNAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authenticating.
        /// </summary>
        internal static string VPN_AUTH {
            get {
                return ResourceManager.GetString("VPN_AUTH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to .
        /// </summary>
        internal static string VPN_CONNECTED {
            get {
                return ResourceManager.GetString("VPN_CONNECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting.
        /// </summary>
        internal static string VPN_CONNECTING {
            get {
                return ResourceManager.GetString("VPN_CONNECTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Securing your internet connection....
        /// </summary>
        internal static string VPN_CONNECTING_TIP {
            get {
                return ResourceManager.GetString("VPN_CONNECTING_TIP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assigning IP.
        /// </summary>
        internal static string VPN_DHCP {
            get {
                return ResourceManager.GetString("VPN_DHCP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disconnected.
        /// </summary>
        internal static string VPN_DISCONNECTED {
            get {
                return ResourceManager.GetString("VPN_DISCONNECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading configuration cache.
        /// </summary>
        internal static string VPN_DOWNLOADING {
            get {
                return ResourceManager.GetString("VPN_DOWNLOADING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong.
        /// </summary>
        internal static string VPN_ERROR {
            get {
                return ResourceManager.GetString("VPN_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initalizing.
        /// </summary>
        internal static string VPN_INIT {
            get {
                return ResourceManager.GetString("VPN_INIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reconnecting.
        /// </summary>
        internal static string VPN_RECONNECTING {
            get {
                return ResourceManager.GetString("VPN_RECONNECTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adding routes.
        /// </summary>
        internal static string VPN_ROUTE {
            get {
                return ResourceManager.GetString("VPN_ROUTE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for server.
        /// </summary>
        internal static string VPN_WAIT {
            get {
                return ResourceManager.GetString("VPN_WAIT", resourceCulture);
            }
        }
    }
}
