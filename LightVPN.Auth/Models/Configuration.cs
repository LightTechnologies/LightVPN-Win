﻿/* --------------------------------------------
 * 
 * Configuration file - Model
 * Copyright (C) Light Technologies LLC
 * 
 * File: Configuration.cs
 * 
 * Created: 04-03-21 Khrysus
 * 
 * --------------------------------------------
 */

using Newtonsoft.Json;

namespace LightVPN.Auth.Models
{
    public struct Configuration
    {
        [JsonProperty("AutoConnect")] 
        public bool AutoConnect { get; set; }

        [JsonProperty("DarkMode")] 
        public bool DarkMode { get; set; }

        [JsonProperty("KillSwitch")] 
        public bool KillSwitch { get; set; }

        [JsonProperty("PreviousServer")]
        public PreviousServer PreviousServer { get; set; }

    }

    public class PreviousServer
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("Country")]
        public string Country { get; set; }
    }
}
