﻿/* --------------------------------------------
 *
 * MainWindow MVVM
 * Copyright (C) Light Technologies LLC
 *
 * File: MainWindowViewModel.cs
 *
 * Created: 27-03-21 Khrysus
 *
 * --------------------------------------------
 */

using LightVPN.ViewModels.Base;
using System.ComponentModel;

namespace LightVPN.ViewModels
{
    public class MainWindowViewModel : WindowBaseViewModel
    {
        public MainWindowViewModel() : base(false)
        {
        }
    }
}