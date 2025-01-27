﻿using LightVPN.Windows;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace LightVPN.Views
{
    /// <summary>
    /// Interaction logic for Settingsv2.xaml
    /// </summary>
    public partial class Settings : Page
    {
        private readonly MainWindow _host;

        public Settings(MainWindow host)
        {
            InitializeComponent();
            _host = host;
            versionText.Text = $"LightVPN Windows Client [stable version {Assembly.GetEntryAssembly().GetName().Version}]";
        }

        private void BackToHome(object sender, RoutedEventArgs e) => _host.NavigatePage(new Main());
    }
}