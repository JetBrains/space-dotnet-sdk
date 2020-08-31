// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class Workday
         : IPropagatePropertyAccessPath
    {
        public Workday() { }
        
        public Workday(string weekday, bool working, int hours, int? minutes = null)
        {
            Weekday = weekday;
            IsWorking = working;
            Hours = hours;
            Minutes = minutes;
        }
        
        private PropertyValue<string> _weekday = new PropertyValue<string>(nameof(Workday), nameof(Weekday));
        
        [Required]
        [JsonPropertyName("weekday")]
        public string Weekday
        {
            get { return _weekday.GetValue(); }
            set { _weekday.SetValue(value); }
        }
    
        private PropertyValue<bool> _working = new PropertyValue<bool>(nameof(Workday), nameof(IsWorking));
        
        [Required]
        [JsonPropertyName("working")]
        public bool IsWorking
        {
            get { return _working.GetValue(); }
            set { _working.SetValue(value); }
        }
    
        private PropertyValue<int> _hours = new PropertyValue<int>(nameof(Workday), nameof(Hours));
        
        [Required]
        [JsonPropertyName("hours")]
        public int Hours
        {
            get { return _hours.GetValue(); }
            set { _hours.SetValue(value); }
        }
    
        private PropertyValue<int?> _minutes = new PropertyValue<int?>(nameof(Workday), nameof(Minutes));
        
        [JsonPropertyName("minutes")]
        public int? Minutes
        {
            get { return _minutes.GetValue(); }
            set { _minutes.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _weekday.SetAccessPath(path, validateHasBeenSet);
            _working.SetAccessPath(path, validateHasBeenSet);
            _hours.SetAccessPath(path, validateHasBeenSet);
            _minutes.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
