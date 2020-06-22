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
    public sealed class CalendarEventDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<bool?> _calendarEvent = new PropertyValue<bool?>(nameof(CalendarEventDto), nameof(CalendarEvent));
        
        [JsonPropertyName("calendarEvent")]
        public bool? CalendarEvent
        {
            get { return _calendarEvent.GetValue(); }
            set { _calendarEvent.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _starts = new PropertyValue<SpaceTime?>(nameof(CalendarEventDto), nameof(Starts));
        
        [JsonPropertyName("starts")]
        public SpaceTime? Starts
        {
            get { return _starts.GetValue(); }
            set { _starts.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _ends = new PropertyValue<SpaceTime?>(nameof(CalendarEventDto), nameof(Ends));
        
        [JsonPropertyName("ends")]
        public SpaceTime? Ends
        {
            get { return _ends.GetValue(); }
            set { _ends.SetValue(value); }
        }
    
        private PropertyValue<ATimeZoneDto?> _timezone = new PropertyValue<ATimeZoneDto?>(nameof(CalendarEventDto), nameof(Timezone));
        
        [JsonPropertyName("timezone")]
        public ATimeZoneDto? Timezone
        {
            get { return _timezone.GetValue(); }
            set { _timezone.SetValue(value); }
        }
    
        private PropertyValue<List<TDLocationDto>?> _rooms = new PropertyValue<List<TDLocationDto>?>(nameof(CalendarEventDto), nameof(Rooms));
        
        [JsonPropertyName("rooms")]
        public List<TDLocationDto>? Rooms
        {
            get { return _rooms.GetValue(); }
            set { _rooms.SetValue(value); }
        }
    
        private PropertyValue<bool?> _allDay = new PropertyValue<bool?>(nameof(CalendarEventDto), nameof(AllDay));
        
        [JsonPropertyName("allDay")]
        public bool? AllDay
        {
            get { return _allDay.GetValue(); }
            set { _allDay.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _calendarEvent.SetAccessPath(path + "->WithCalendarEvent()", validateHasBeenSet);
            _starts.SetAccessPath(path + "->WithStarts()", validateHasBeenSet);
            _ends.SetAccessPath(path + "->WithEnds()", validateHasBeenSet);
            _timezone.SetAccessPath(path + "->WithTimezone()", validateHasBeenSet);
            _rooms.SetAccessPath(path + "->WithRooms()", validateHasBeenSet);
            _allDay.SetAccessPath(path + "->WithAllDay()", validateHasBeenSet);
        }
    
    }
    
}
