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

namespace JetBrains.Space.Client.CodeReviewMenuItemUiExtensionInPartialBuilder;

public static class CodeReviewMenuItemUiExtensionInPartialExtensions
{
    public static Partial<CodeReviewMenuItemUiExtensionIn> WithDisplayName(this Partial<CodeReviewMenuItemUiExtensionIn> it)
        => it.AddFieldName("displayName");
    
    public static Partial<CodeReviewMenuItemUiExtensionIn> WithDescription(this Partial<CodeReviewMenuItemUiExtensionIn> it)
        => it.AddFieldName("description");
    
    public static Partial<CodeReviewMenuItemUiExtensionIn> WithMenuItemUniqueCode(this Partial<CodeReviewMenuItemUiExtensionIn> it)
        => it.AddFieldName("menuItemUniqueCode");
    
    public static Partial<CodeReviewMenuItemUiExtensionIn> WithVisibilityFilters(this Partial<CodeReviewMenuItemUiExtensionIn> it)
        => it.AddFieldName("visibilityFilters");
    
    public static Partial<CodeReviewMenuItemUiExtensionIn> WithVisibilityFilters(this Partial<CodeReviewMenuItemUiExtensionIn> it, Func<Partial<CodeReviewMenuItemVisibilityFilterIn>, Partial<CodeReviewMenuItemVisibilityFilterIn>> partialBuilder)
        => it.AddFieldName("visibilityFilters", partialBuilder(new Partial<CodeReviewMenuItemVisibilityFilterIn>(it)));
    
    public static Partial<CodeReviewMenuItemUiExtensionIn> WithParametersForm(this Partial<CodeReviewMenuItemUiExtensionIn> it)
        => it.AddFieldName("parametersForm");
    
    public static Partial<CodeReviewMenuItemUiExtensionIn> WithParametersForm(this Partial<CodeReviewMenuItemUiExtensionIn> it, Func<Partial<ExtensionActionParametersForm>, Partial<ExtensionActionParametersForm>> partialBuilder)
        => it.AddFieldName("parametersForm", partialBuilder(new Partial<ExtensionActionParametersForm>(it)));
    
    public static Partial<CodeReviewMenuItemUiExtensionIn> WithActionPlacement(this Partial<CodeReviewMenuItemUiExtensionIn> it)
        => it.AddFieldName("actionPlacement");
    
    public static Partial<CodeReviewMenuItemUiExtensionIn> WithActionPlacement(this Partial<CodeReviewMenuItemUiExtensionIn> it, Func<Partial<ExtensionActionPlacement>, Partial<ExtensionActionPlacement>> partialBuilder)
        => it.AddFieldName("actionPlacement", partialBuilder(new Partial<ExtensionActionPlacement>(it)));
    
}

