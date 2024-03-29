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

public sealed class PublicHoliday
     : IPropagatePropertyAccessPath
{
    public PublicHoliday() { }
    
    public PublicHoliday(string id, PublicHolidayCalendarRecord calendar, string name, DateTime date, bool workingDay, bool? halfDay = null, bool? archived = null)
    {
        Id = id;
        Calendar = calendar;
        Name = name;
        Date = date;
        IsWorkingDay = workingDay;
        IsHalfDay = halfDay;
        IsArchived = archived;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(PublicHoliday), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<PublicHolidayCalendarRecord> _calendar = new PropertyValue<PublicHolidayCalendarRecord>(nameof(PublicHoliday), nameof(Calendar), "calendar");
    
    [Required]
    [JsonPropertyName("calendar")]
    public PublicHolidayCalendarRecord Calendar
    {
        get => _calendar.GetValue(InlineErrors);
        set => _calendar.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(PublicHoliday), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<DateTime> _date = new PropertyValue<DateTime>(nameof(PublicHoliday), nameof(Date), "date");
    
    [Required]
    [JsonPropertyName("date")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime Date
    {
        get => _date.GetValue(InlineErrors);
        set => _date.SetValue(value);
    }

    private PropertyValue<bool> _workingDay = new PropertyValue<bool>(nameof(PublicHoliday), nameof(IsWorkingDay), "workingDay");
    
    [Required]
    [JsonPropertyName("workingDay")]
    public bool IsWorkingDay
    {
        get => _workingDay.GetValue(InlineErrors);
        set => _workingDay.SetValue(value);
    }

    private PropertyValue<bool?> _halfDay = new PropertyValue<bool?>(nameof(PublicHoliday), nameof(IsHalfDay), "halfDay");
    
    [JsonPropertyName("halfDay")]
    public bool? IsHalfDay
    {
        get => _halfDay.GetValue(InlineErrors);
        set => _halfDay.SetValue(value);
    }

    private PropertyValue<bool?> _archived = new PropertyValue<bool?>(nameof(PublicHoliday), nameof(IsArchived), "archived");
    
    [JsonPropertyName("archived")]
    public bool? IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _calendar.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _date.SetAccessPath(parentChainPath, validateHasBeenSet);
        _workingDay.SetAccessPath(parentChainPath, validateHasBeenSet);
        _halfDay.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

