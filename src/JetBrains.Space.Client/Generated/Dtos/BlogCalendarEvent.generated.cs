// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class BlogCalendarEvent
         : IPropagatePropertyAccessPath
    {
        public BlogCalendarEvent() { }
        
        public BlogCalendarEvent(DateTime? starts = null, DateTime? ends = null, ATimeZone? timezone = null, List<string>? rooms = null, bool? allDay = null)
        {
            Starts = starts;
            Ends = ends;
            Timezone = timezone;
            Rooms = rooms;
            IsAllDay = allDay;
        }
        
        private PropertyValue<DateTime?> _starts = new PropertyValue<DateTime?>(nameof(BlogCalendarEvent), nameof(Starts));
        
        [JsonPropertyName("starts")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Starts
        {
            get => _starts.GetValue();
            set => _starts.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _ends = new PropertyValue<DateTime?>(nameof(BlogCalendarEvent), nameof(Ends));
        
        [JsonPropertyName("ends")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Ends
        {
            get => _ends.GetValue();
            set => _ends.SetValue(value);
        }
    
        private PropertyValue<ATimeZone?> _timezone = new PropertyValue<ATimeZone?>(nameof(BlogCalendarEvent), nameof(Timezone));
        
        [JsonPropertyName("timezone")]
        public ATimeZone? Timezone
        {
            get => _timezone.GetValue();
            set => _timezone.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _rooms = new PropertyValue<List<string>?>(nameof(BlogCalendarEvent), nameof(Rooms));
        
        [JsonPropertyName("rooms")]
        public List<string>? Rooms
        {
            get => _rooms.GetValue();
            set => _rooms.SetValue(value);
        }
    
        private PropertyValue<bool?> _allDay = new PropertyValue<bool?>(nameof(BlogCalendarEvent), nameof(IsAllDay));
        
        [JsonPropertyName("allDay")]
        public bool? IsAllDay
        {
            get => _allDay.GetValue();
            set => _allDay.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _starts.SetAccessPath(path, validateHasBeenSet);
            _ends.SetAccessPath(path, validateHasBeenSet);
            _timezone.SetAccessPath(path, validateHasBeenSet);
            _rooms.SetAccessPath(path, validateHasBeenSet);
            _allDay.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
