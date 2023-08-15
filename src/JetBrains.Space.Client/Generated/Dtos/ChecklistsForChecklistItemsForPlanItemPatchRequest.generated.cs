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

internal class ChecklistsForChecklistItemsForPlanItemPatchRequest
     : IPropagatePropertyAccessPath
{
    public ChecklistsForChecklistItemsForPlanItemPatchRequest() { }
    
    public ChecklistsForChecklistItemsForPlanItemPatchRequest(string? itemText = null, bool? itemDone = null)
    {
        ItemText = itemText;
        IsItemDone = itemDone;
    }
    
    private PropertyValue<string?> _itemText = new PropertyValue<string?>(nameof(ChecklistsForChecklistItemsForPlanItemPatchRequest), nameof(ItemText), "itemText");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("itemText")]
    public string? ItemText
    {
        get => _itemText.GetValue(InlineErrors);
        set => _itemText.SetValue(value);
    }

    private PropertyValue<bool?> _itemDone = new PropertyValue<bool?>(nameof(ChecklistsForChecklistItemsForPlanItemPatchRequest), nameof(IsItemDone), "itemDone");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("itemDone")]
    public bool? IsItemDone
    {
        get => _itemDone.GetValue(InlineErrors);
        set => _itemDone.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _itemText.SetAccessPath(parentChainPath, validateHasBeenSet);
        _itemDone.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

