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

namespace JetBrains.Space.Client.MessageSectionPartialBuilder;

public static class MessageSectionPartialExtensions
{
    /// <summary>
    /// Block elements that constitute the section
    /// </summary>
    public static Partial<MessageSection> WithElements(this Partial<MessageSection> it)
        => it.AddFieldName("elements");
    
    /// <summary>
    /// Block elements that constitute the section
    /// </summary>
    public static Partial<MessageSection> WithElements(this Partial<MessageSection> it, Func<Partial<MessageElement>, Partial<MessageElement>> partialBuilder)
        => it.AddFieldName("elements", partialBuilder(new Partial<MessageElement>(it)));
    
    /// <summary>
    /// Header text is displayed with a large font size at the top of the section
    /// </summary>
    public static Partial<MessageSection> WithHeader(this Partial<MessageSection> it)
        => it.AddFieldName("header");
    
    /// <summary>
    /// Footer text is displayed with a small font size and in a dimmed color at the bottom of the section
    /// </summary>
    public static Partial<MessageSection> WithFooter(this Partial<MessageSection> it)
        => it.AddFieldName("footer");
    
    /// <summary>
    /// Section style determines the color of the left-hand side bar
    /// </summary>
    /// <remarks>
    /// This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.
    /// </remarks>
#if NET6_0_OR_GREATER
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.", DiagnosticId = "SPC001")]
#else
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.")]
#endif
    
    public static Partial<MessageSection> WithStyle(this Partial<MessageSection> it)
        => it.AddFieldName("style");
    
    /// <summary>
    /// Section style determines the color of the left-hand side bar
    /// </summary>
    /// <remarks>
    /// This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.
    /// </remarks>
#if NET6_0_OR_GREATER
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.", DiagnosticId = "SPC001")]
#else
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.")]
#endif
    
    public static Partial<MessageSection> WithStyle(this Partial<MessageSection> it, Func<Partial<MessageStyle>, Partial<MessageStyle>> partialBuilder)
        => it.AddFieldName("style", partialBuilder(new Partial<MessageStyle>(it)));
    
    /// <summary>
    /// Default text size for all the elements within the section (excluding header and footer)
    /// </summary>
    /// <remarks>
    /// This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.
    /// </remarks>
#if NET6_0_OR_GREATER
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.", DiagnosticId = "SPC001")]
#else
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.")]
#endif
    
    public static Partial<MessageSection> WithTextSize(this Partial<MessageSection> it)
        => it.AddFieldName("textSize");
    
    /// <summary>
    /// Default text size for all the elements within the section (excluding header and footer)
    /// </summary>
    /// <remarks>
    /// This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.
    /// </remarks>
#if NET6_0_OR_GREATER
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.", DiagnosticId = "SPC001")]
#else
    [Obsolete("This parameter is not supported yet on mobile clients and will be ignored on iOS and Android.")]
#endif
    
    public static Partial<MessageSection> WithTextSize(this Partial<MessageSection> it, Func<Partial<MessageTextSize>, Partial<MessageTextSize>> partialBuilder)
        => it.AddFieldName("textSize", partialBuilder(new Partial<MessageTextSize>(it)));
    
}

