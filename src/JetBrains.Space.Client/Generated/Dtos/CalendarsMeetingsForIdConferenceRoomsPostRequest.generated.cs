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

internal class CalendarsMeetingsForIdConferenceRoomsPostRequest
     : IPropagatePropertyAccessPath
{
    public CalendarsMeetingsForIdConferenceRoomsPostRequest() { }
    
    public CalendarsMeetingsForIdConferenceRoomsPostRequest(string roomId, DateTime dateTime)
    {
        RoomId = roomId;
        DateTime = dateTime;
    }
    
    private PropertyValue<string> _roomId = new PropertyValue<string>(nameof(CalendarsMeetingsForIdConferenceRoomsPostRequest), nameof(RoomId), "roomId");
    
    [Required]
    [JsonPropertyName("roomId")]
    public string RoomId
    {
        get => _roomId.GetValue(InlineErrors);
        set => _roomId.SetValue(value);
    }

    private PropertyValue<DateTime> _dateTime = new PropertyValue<DateTime>(nameof(CalendarsMeetingsForIdConferenceRoomsPostRequest), nameof(DateTime), "dateTime");
    
    [Required]
    [JsonPropertyName("dateTime")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime DateTime
    {
        get => _dateTime.GetValue(InlineErrors);
        set => _dateTime.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _roomId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _dateTime.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

