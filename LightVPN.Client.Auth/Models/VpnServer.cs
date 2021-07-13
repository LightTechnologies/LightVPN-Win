﻿namespace LightVPN.Client.Auth.Models
{
    using System.Text.Json.Serialization;
    using Windows.Common.Models;

    public sealed class VpnServer
    {
        [JsonPropertyName("countryName")] public string CountryName { get; set; }
        [JsonPropertyName("id")] public string Id { get; set; }
        [JsonPropertyName("location")] public string Location { get; set; }
        [JsonPropertyName("pritunlName")] public string PritunlName { get; set; }
        [JsonPropertyName("serverName")] public string ServerName { get; set; }
        [JsonPropertyName("status")] public bool Status { get; set; }
        [JsonPropertyName("devicesOnline")] public uint DevicesOnline { get; set; }
        [JsonPropertyName("type")] public VpnServerType Type { get; set; }
    }
}
