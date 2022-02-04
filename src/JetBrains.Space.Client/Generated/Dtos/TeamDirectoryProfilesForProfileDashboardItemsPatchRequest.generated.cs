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

public class TeamDirectoryProfilesForProfileDashboardItemsPatchRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryProfilesForProfileDashboardItemsPatchRequest() { }
    
    public TeamDirectoryProfilesForProfileDashboardItemsPatchRequest(DashboardItem item)
    {
        Item = item;
    }
    
    private PropertyValue<DashboardItem> _item = new PropertyValue<DashboardItem>(nameof(TeamDirectoryProfilesForProfileDashboardItemsPatchRequest), nameof(Item), "item");
    
    [Required]
    [JsonPropertyName("item")]
    public DashboardItem Item
    {
        get => _item.GetValue(InlineErrors);
        set => _item.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _item.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

