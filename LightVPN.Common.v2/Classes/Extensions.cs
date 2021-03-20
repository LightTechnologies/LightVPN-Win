﻿/* --------------------------------------------
 * 
 * Extension methods - Main class
 * Copyright (C) Light Technologies LLC
 * 
 * File: Extensions.cs
 * 
 * Created: 04-03-21 Khrysus
 * 
 * --------------------------------------------
 */
using Newtonsoft.Json.Linq;
using System;

namespace LightVPN.Common.v2
{
    public static class Extensions
    {
        /// <summary>
        /// Checks if the input string is valid Json data using JToken
        /// </summary>
        /// <param name="strInput">The input string</param>
        /// <returns>True or false value whether the string was valid Json or not</returns>
        public static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            try
            {
                var obj = JToken.Parse(strInput);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Converts a TimeSpan to a string, hours, mins, seconds
        /// </summary>
        /// <param name="time">TimeSpan to be converted</param>
        /// <returns>The formatted string</returns>
        public static string ToHMS(this TimeSpan time)
        {
            string converted = null;
            converted += time.Days == 0 ? "" : time.Days == 1 ? $"{time.Days} day " : $"{time.Days} days ";
            converted += time.Hours == 0 ? "" : time.Hours == 1 ? $"{time.Hours} hour " : $"{time.Hours} hours ";
            converted += time.Minutes == 0 ? "" : time.Seconds == 0 ? time.Minutes == 1 ? $"{time.Minutes} minute " : $"{time.Minutes} minutes " : time.Minutes == 1 ? $"{time.Minutes} minute and " : $"{time.Minutes} minutes and ";
            converted += time.Seconds == 0 ? "" : time.Seconds == 1 ? $"{time.Seconds} second" : $"{time.Seconds} seconds";
            return converted;
        }
    }
}
