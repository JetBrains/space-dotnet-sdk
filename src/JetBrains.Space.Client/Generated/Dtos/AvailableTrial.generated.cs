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

public sealed class AvailableTrial
     : IPropagatePropertyAccessPath
{
    public AvailableTrial() { }
    
    public AvailableTrial(Tier tier, int durationDays)
    {
        Tier = tier;
        DurationDays = durationDays;
    }
    
    private PropertyValue<Tier> _tier = new PropertyValue<Tier>(nameof(AvailableTrial), nameof(Tier), "tier");
    
    [Required]
    [JsonPropertyName("tier")]
    public Tier Tier
    {
        get => _tier.GetValue(InlineErrors);
        set => _tier.SetValue(value);
    }

    private PropertyValue<int> _durationDays = new PropertyValue<int>(nameof(AvailableTrial), nameof(DurationDays), "durationDays");
    
    [Required]
    [JsonPropertyName("durationDays")]
    public int DurationDays
    {
        get => _durationDays.GetValue(InlineErrors);
        set => _durationDays.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _tier.SetAccessPath(parentChainPath, validateHasBeenSet);
        _durationDays.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

