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

namespace JetBrains.Space.Client.ContextMenuItemUiExtensionApiPartialBuilder;

public static class ContextMenuItemUiExtensionApiPartialExtensions
{
    public static Partial<ContextMenuItemUiExtensionApi> WithTypeName(this Partial<ContextMenuItemUiExtensionApi> it)
        => it.AddFieldName("typeName");
    
    public static Partial<ContextMenuItemUiExtensionApi> WithMenuIdentifier(this Partial<ContextMenuItemUiExtensionApi> it)
        => it.AddFieldName("menuIdentifier");
    
    public static Partial<ContextMenuItemUiExtensionApi> WithMenuIdentifier(this Partial<ContextMenuItemUiExtensionApi> it, Func<Partial<ContextMenuIdentifier>, Partial<ContextMenuIdentifier>> partialBuilder)
        => it.AddFieldName("menuIdentifier", partialBuilder(new Partial<ContextMenuIdentifier>(it)));
    
    public static Partial<ContextMenuItemUiExtensionApi> WithDisplayName(this Partial<ContextMenuItemUiExtensionApi> it)
        => it.AddFieldName("displayName");
    
    public static Partial<ContextMenuItemUiExtensionApi> WithDescription(this Partial<ContextMenuItemUiExtensionApi> it)
        => it.AddFieldName("description");
    
    public static Partial<ContextMenuItemUiExtensionApi> WithMenuItemUniqueCode(this Partial<ContextMenuItemUiExtensionApi> it)
        => it.AddFieldName("menuItemUniqueCode");
    
    public static Partial<ContextMenuItemUiExtensionApi> WithVisibilityFilters(this Partial<ContextMenuItemUiExtensionApi> it)
        => it.AddFieldName("visibilityFilters");
    
    public static Partial<ContextMenuItemUiExtensionApi> WithVisibilityFilters(this Partial<ContextMenuItemUiExtensionApi> it, Func<Partial<MenuItemVisibilityFilter>, Partial<MenuItemVisibilityFilter>> partialBuilder)
        => it.AddFieldName("visibilityFilters", partialBuilder(new Partial<MenuItemVisibilityFilter>(it)));
    
}

