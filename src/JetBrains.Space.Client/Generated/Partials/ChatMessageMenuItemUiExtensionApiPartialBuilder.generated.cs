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

namespace JetBrains.Space.Client.ChatMessageMenuItemUiExtensionApiPartialBuilder;

public static class ChatMessageMenuItemUiExtensionApiPartialExtensions
{
    public static Partial<ChatMessageMenuItemUiExtensionApi> WithDisplayName(this Partial<ChatMessageMenuItemUiExtensionApi> it)
        => it.AddFieldName("displayName");
    
    public static Partial<ChatMessageMenuItemUiExtensionApi> WithDescription(this Partial<ChatMessageMenuItemUiExtensionApi> it)
        => it.AddFieldName("description");
    
    public static Partial<ChatMessageMenuItemUiExtensionApi> WithMenuItemUniqueCode(this Partial<ChatMessageMenuItemUiExtensionApi> it)
        => it.AddFieldName("menuItemUniqueCode");
    
    public static Partial<ChatMessageMenuItemUiExtensionApi> WithVisibilityFilters(this Partial<ChatMessageMenuItemUiExtensionApi> it)
        => it.AddFieldName("visibilityFilters");
    
    public static Partial<ChatMessageMenuItemUiExtensionApi> WithVisibilityFilters(this Partial<ChatMessageMenuItemUiExtensionApi> it, Func<Partial<ChatMessageMenuItemVisibilityFilterApi>, Partial<ChatMessageMenuItemVisibilityFilterApi>> partialBuilder)
        => it.AddFieldName("visibilityFilters", partialBuilder(new Partial<ChatMessageMenuItemVisibilityFilterApi>(it)));
    
}

