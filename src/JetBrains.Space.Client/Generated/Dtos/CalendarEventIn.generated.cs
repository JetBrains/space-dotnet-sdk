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

namespace JetBrains.Space.Client;

public sealed class CalendarEventIn
     : IPropagatePropertyAccessPath
{
    public CalendarEventIn() { }
    
    public CalendarEventIn(bool? calendarEvent = null, DateTime? starts = null, DateTime? ends = null, ATimeZone? timezone = null, List<string>? rooms = null, bool? allDay = null)
    {
        IsCalendarEvent = calendarEvent;
        Starts = starts;
        Ends = ends;
        Timezone = timezone;
        Rooms = rooms;
        IsAllDay = allDay;
    }
    
    private PropertyValue<bool?> _calendarEvent = new PropertyValue<bool?>(nameof(CalendarEventIn), nameof(IsCalendarEvent), "calendarEvent");
    
    [JsonPropertyName("calendarEvent")]
    public bool? IsCalendarEvent
    {
        get => _calendarEvent.GetValue(InlineErrors);
        set => _calendarEvent.SetValue(value);
    }

    private PropertyValue<DateTime?> _starts = new PropertyValue<DateTime?>(nameof(CalendarEventIn), nameof(Starts), "starts");
    
    [JsonPropertyName("starts")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? Starts
    {
        get => _starts.GetValue(InlineErrors);
        set => _starts.SetValue(value);
    }

    private PropertyValue<DateTime?> _ends = new PropertyValue<DateTime?>(nameof(CalendarEventIn), nameof(Ends), "ends");
    
    [JsonPropertyName("ends")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? Ends
    {
        get => _ends.GetValue(InlineErrors);
        set => _ends.SetValue(value);
    }

    private PropertyValue<ATimeZone?> _timezone = new PropertyValue<ATimeZone?>(nameof(CalendarEventIn), nameof(Timezone), "timezone");
    
    [JsonPropertyName("timezone")]
    public ATimeZone? Timezone
    {
        get => _timezone.GetValue(InlineErrors);
        set => _timezone.SetValue(value);
    }

    private PropertyValue<List<string>?> _rooms = new PropertyValue<List<string>?>(nameof(CalendarEventIn), nameof(Rooms), "rooms");
    
    [JsonPropertyName("rooms")]
    public List<string>? Rooms
    {
        get => _rooms.GetValue(InlineErrors);
        set => _rooms.SetValue(value);
    }

    private PropertyValue<bool?> _allDay = new PropertyValue<bool?>(nameof(CalendarEventIn), nameof(IsAllDay), "allDay");
    
    [JsonPropertyName("allDay")]
    public bool? IsAllDay
    {
        get => _allDay.GetValue(InlineErrors);
        set => _allDay.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _calendarEvent.SetAccessPath(parentChainPath, validateHasBeenSet);
        _starts.SetAccessPath(parentChainPath, validateHasBeenSet);
        _ends.SetAccessPath(parentChainPath, validateHasBeenSet);
        _timezone.SetAccessPath(parentChainPath, validateHasBeenSet);
        _rooms.SetAccessPath(parentChainPath, validateHasBeenSet);
        _allDay.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

