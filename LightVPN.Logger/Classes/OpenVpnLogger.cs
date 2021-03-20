﻿/* --------------------------------------------
 * 
 * File logger - OpenVPN Logger
 * Copyright (C) Light Technologies LLC
 * 
 * File: OpenVpnLogger.cs
 * 
 * Created: 04-03-21 Khrysus
 * 
 * --------------------------------------------
 */
using LightVPN.Logger.Base;

namespace LightVPN.Logger
{
    public class OpenVpnLogger : FileLogger
    {
        public OpenVpnLogger(string fileName) : base(fileName)
        {

        }
    }
}
