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

public sealed class FeatureFlagDate
     : IPropagatePropertyAccessPath
{
    public FeatureFlagDate() { }
    
    public FeatureFlagDate(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }
    
    private PropertyValue<int> _year = new PropertyValue<int>(nameof(FeatureFlagDate), nameof(Year), "year");
    
    [Required]
    [JsonPropertyName("year")]
    public int Year
    {
        get => _year.GetValue(InlineErrors);
        set => _year.SetValue(value);
    }

    private PropertyValue<int> _month = new PropertyValue<int>(nameof(FeatureFlagDate), nameof(Month), "month");
    
    [Required]
    [JsonPropertyName("month")]
    public int Month
    {
        get => _month.GetValue(InlineErrors);
        set => _month.SetValue(value);
    }

    private PropertyValue<int> _day = new PropertyValue<int>(nameof(FeatureFlagDate), nameof(Day), "day");
    
    [Required]
    [JsonPropertyName("day")]
    public int Day
    {
        get => _day.GetValue(InlineErrors);
        set => _day.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _year.SetAccessPath(parentChainPath, validateHasBeenSet);
        _month.SetAccessPath(parentChainPath, validateHasBeenSet);
        _day.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

