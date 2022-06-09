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

public sealed class DocumentInListMenuItemUiExtensionIn
     : ContextMenuItemUiExtensionIn, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "DocumentInListMenuItemUiExtensionIn";
    
    public DocumentInListMenuItemUiExtensionIn() { }
    
    public DocumentInListMenuItemUiExtensionIn(string displayName, string menuItemUniqueCode, List<DocumentMenuItemVisibilityFilterIn> visibilityFilters, string? description = null)
    {
        DisplayName = displayName;
        Description = description;
        MenuItemUniqueCode = menuItemUniqueCode;
        VisibilityFilters = visibilityFilters;
    }
    
    private PropertyValue<string> _displayName = new PropertyValue<string>(nameof(DocumentInListMenuItemUiExtensionIn), nameof(DisplayName), "displayName");
    
    [Required]
    [JsonPropertyName("displayName")]
    public string DisplayName
    {
        get => _displayName.GetValue(InlineErrors);
        set => _displayName.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(DocumentInListMenuItemUiExtensionIn), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<string> _menuItemUniqueCode = new PropertyValue<string>(nameof(DocumentInListMenuItemUiExtensionIn), nameof(MenuItemUniqueCode), "menuItemUniqueCode");
    
    [Required]
    [JsonPropertyName("menuItemUniqueCode")]
    public string MenuItemUniqueCode
    {
        get => _menuItemUniqueCode.GetValue(InlineErrors);
        set => _menuItemUniqueCode.SetValue(value);
    }

    private PropertyValue<List<DocumentMenuItemVisibilityFilterIn>> _visibilityFilters = new PropertyValue<List<DocumentMenuItemVisibilityFilterIn>>(nameof(DocumentInListMenuItemUiExtensionIn), nameof(VisibilityFilters), "visibilityFilters", new List<DocumentMenuItemVisibilityFilterIn>());
    
    [Required]
    [JsonPropertyName("visibilityFilters")]
    public List<DocumentMenuItemVisibilityFilterIn> VisibilityFilters
    {
        get => _visibilityFilters.GetValue(InlineErrors);
        set => _visibilityFilters.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _displayName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _menuItemUniqueCode.SetAccessPath(parentChainPath, validateHasBeenSet);
        _visibilityFilters.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

