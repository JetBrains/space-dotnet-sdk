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

internal class TimeTrackingItemsPostRequest
     : IPropagatePropertyAccessPath
{
    public TimeTrackingItemsPostRequest() { }
    
    public TimeTrackingItemsPostRequest(TimeTrackingSubjectIdentifier subject, ProfileIdentifier userId, DateTime date, int duration, string? description = null)
    {
        Subject = subject;
        UserId = userId;
        Date = date;
        Duration = duration;
        Description = description;
    }
    
    private PropertyValue<TimeTrackingSubjectIdentifier> _subject = new PropertyValue<TimeTrackingSubjectIdentifier>(nameof(TimeTrackingItemsPostRequest), nameof(Subject), "subject");
    
    [Required]
    [JsonPropertyName("subject")]
    public TimeTrackingSubjectIdentifier Subject
    {
        get => _subject.GetValue(InlineErrors);
        set => _subject.SetValue(value);
    }

    private PropertyValue<ProfileIdentifier> _userId = new PropertyValue<ProfileIdentifier>(nameof(TimeTrackingItemsPostRequest), nameof(UserId), "userId");
    
    [Required]
    [JsonPropertyName("userId")]
    public ProfileIdentifier UserId
    {
        get => _userId.GetValue(InlineErrors);
        set => _userId.SetValue(value);
    }

    private PropertyValue<DateTime> _date = new PropertyValue<DateTime>(nameof(TimeTrackingItemsPostRequest), nameof(Date), "date");
    
    [Required]
    [JsonPropertyName("date")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime Date
    {
        get => _date.GetValue(InlineErrors);
        set => _date.SetValue(value);
    }

    private PropertyValue<int> _duration = new PropertyValue<int>(nameof(TimeTrackingItemsPostRequest), nameof(Duration), "duration");
    
    /// <summary>
    /// Work item duration in minutes, should be greater than 0
    /// </summary>
    [Required]
    [JsonPropertyName("duration")]
    public int Duration
    {
        get => _duration.GetValue(InlineErrors);
        set => _duration.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(TimeTrackingItemsPostRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _subject.SetAccessPath(parentChainPath, validateHasBeenSet);
        _userId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _date.SetAccessPath(parentChainPath, validateHasBeenSet);
        _duration.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

