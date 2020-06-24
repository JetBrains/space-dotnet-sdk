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
    public sealed class PublicHolidayCalendarRecordDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PublicHolidayCalendarRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(PublicHolidayCalendarRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PublicHolidayCalendarRecordDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _firstDate = new PropertyValue<SpaceDate?>(nameof(PublicHolidayCalendarRecordDto), nameof(FirstDate));
        
        [JsonPropertyName("firstDate")]
        public SpaceDate? FirstDate
        {
            get { return _firstDate.GetValue(); }
            set { _firstDate.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _lastDate = new PropertyValue<SpaceDate?>(nameof(PublicHolidayCalendarRecordDto), nameof(LastDate));
        
        [JsonPropertyName("lastDate")]
        public SpaceDate? LastDate
        {
            get { return _lastDate.GetValue(); }
            set { _lastDate.SetValue(value); }
        }
    
        private PropertyValue<int> _eventsCount = new PropertyValue<int>(nameof(PublicHolidayCalendarRecordDto), nameof(EventsCount));
        
        [Required]
        [JsonPropertyName("eventsCount")]
        public int EventsCount
        {
            get { return _eventsCount.GetValue(); }
            set { _eventsCount.SetValue(value); }
        }
    
        private PropertyValue<TDLocationDto> _location = new PropertyValue<TDLocationDto>(nameof(PublicHolidayCalendarRecordDto), nameof(Location));
        
        [Required]
        [JsonPropertyName("location")]
        public TDLocationDto Location
        {
            get { return _location.GetValue(); }
            set { _location.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _firstDate.SetAccessPath(path, validateHasBeenSet);
            _lastDate.SetAccessPath(path, validateHasBeenSet);
            _eventsCount.SetAccessPath(path, validateHasBeenSet);
            _location.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
