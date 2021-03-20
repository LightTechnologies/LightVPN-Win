﻿/* --------------------------------------------
 * 
 * Login view - Model
 * Copyright (C) Light Technologies LLC
 * 
 * File: Login.xaml.cs
 * 
 * Created: 04-03-21 Khrysus
 * 
 * --------------------------------------------
 */
using LightVPN.Auth.Models;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using LightVPN.Common.v2.Models;
using LightVPN.Settings.Interfaces;

namespace LightVPN.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public static readonly DependencyProperty IsAuthenticatingProperty =
            DependencyProperty.Register("IsAuthenticating", typeof(bool),
            typeof(Page), new(false));
        public bool IsAuthenticating
        {
            get { return (bool)GetValue(IsAuthenticatingProperty); }
            set { SetValue(IsAuthenticatingProperty, value); }
        }
        public Login()
        {
            InitializeComponent();
            var settings = Globals.container.GetInstance<ISettingsManager<Configuration>>().Load();
            if (settings.DarkMode)
            {
                LogoImage.Source = new BitmapImage(new Uri(@"pack://application:,,,/LightVPN;component/Resources/logo-light.png", UriKind.Absolute));
            }
        }
    }
}
