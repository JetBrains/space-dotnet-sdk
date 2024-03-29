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

public sealed class WeekDayTimeInterval
     : IPropagatePropertyAccessPath
{
    public WeekDayTimeInterval() { }
    
    public WeekDayTimeInterval(int day, bool @checked, TimeInterval interval)
    {
        Day = day;
        IsChecked = @checked;
        Interval = interval;
    }
    
    private PropertyValue<int> _day = new PropertyValue<int>(nameof(WeekDayTimeInterval), nameof(Day), "day");
    
    [Required]
    [JsonPropertyName("day")]
    public int Day
    {
        get => _day.GetValue(InlineErrors);
        set => _day.SetValue(value);
    }

    private PropertyValue<bool> _checked = new PropertyValue<bool>(nameof(WeekDayTimeInterval), nameof(IsChecked), "checked");
    
    [Required]
    [JsonPropertyName("checked")]
    public bool IsChecked
    {
        get => _checked.GetValue(InlineErrors);
        set => _checked.SetValue(value);
    }

    private PropertyValue<TimeInterval> _interval = new PropertyValue<TimeInterval>(nameof(WeekDayTimeInterval), nameof(Interval), "interval");
    
    [Required]
    [JsonPropertyName("interval")]
    public TimeInterval Interval
    {
        get => _interval.GetValue(InlineErrors);
        set => _interval.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _day.SetAccessPath(parentChainPath, validateHasBeenSet);
        _checked.SetAccessPath(parentChainPath, validateHasBeenSet);
        _interval.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

