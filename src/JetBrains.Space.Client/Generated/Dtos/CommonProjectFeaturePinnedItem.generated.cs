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

public sealed class CommonProjectFeaturePinnedItem
     : IPropagatePropertyAccessPath
{
    public CommonProjectFeaturePinnedItem() { }
    
    public CommonProjectFeaturePinnedItem(ProjectFeaturePinnedItem value, bool wasPinnedAutomatically, CPrincipal? pinnedBy = null)
    {
        Value = value;
        PinnedBy = pinnedBy;
        IsWasPinnedAutomatically = wasPinnedAutomatically;
    }
    
    private PropertyValue<ProjectFeaturePinnedItem> _value = new PropertyValue<ProjectFeaturePinnedItem>(nameof(CommonProjectFeaturePinnedItem), nameof(Value), "value");
    
    [Required]
    [JsonPropertyName("value")]
    public ProjectFeaturePinnedItem Value
    {
        get => _value.GetValue(InlineErrors);
        set => _value.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _pinnedBy = new PropertyValue<CPrincipal?>(nameof(CommonProjectFeaturePinnedItem), nameof(PinnedBy), "pinnedBy");
    
    [JsonPropertyName("pinnedBy")]
    public CPrincipal? PinnedBy
    {
        get => _pinnedBy.GetValue(InlineErrors);
        set => _pinnedBy.SetValue(value);
    }

    private PropertyValue<bool> _wasPinnedAutomatically = new PropertyValue<bool>(nameof(CommonProjectFeaturePinnedItem), nameof(IsWasPinnedAutomatically), "wasPinnedAutomatically");
    
    [Required]
    [JsonPropertyName("wasPinnedAutomatically")]
    public bool IsWasPinnedAutomatically
    {
        get => _wasPinnedAutomatically.GetValue(InlineErrors);
        set => _wasPinnedAutomatically.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _value.SetAccessPath(parentChainPath, validateHasBeenSet);
        _pinnedBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _wasPinnedAutomatically.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
