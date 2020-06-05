// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class CreateHolidayRequest
    {
        private PropertyValue<string> _calendar = new PropertyValue<string>(nameof(CreateHolidayRequest), nameof(Calendar));
        
        [Required]
        [JsonPropertyName("calendar")]
        public string Calendar { get { return _calendar.GetValue(); } set { _calendar.SetValue(value); } }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(CreateHolidayRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get { return _name.GetValue(); } set { _name.SetValue(value); } }
    
        private PropertyValue<SpaceDate> _date = new PropertyValue<SpaceDate>(nameof(CreateHolidayRequest), nameof(Date));
        
        [Required]
        [JsonPropertyName("date")]
        public SpaceDate Date { get { return _date.GetValue(); } set { _date.SetValue(value); } }
    
        private PropertyValue<bool> _workingDay = new PropertyValue<bool>(nameof(CreateHolidayRequest), nameof(WorkingDay));
        
        [Required]
        [JsonPropertyName("workingDay")]
        public bool WorkingDay { get { return _workingDay.GetValue(); } set { _workingDay.SetValue(value); } }
    
    }
    
}
