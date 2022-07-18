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

namespace JetBrains.Space.Client.ApplicationUnfurlContentMessagePartialBuilder;

public static class ApplicationUnfurlContentMessagePartialExtensions
{
    /// <summary>
    /// Default style for outline and sections
    /// </summary>
    public static Partial<ApplicationUnfurlContentMessage> WithStyle(this Partial<ApplicationUnfurlContentMessage> it)
        => it.AddFieldName("style");
    
    /// <summary>
    /// Default style for outline and sections
    /// </summary>
    public static Partial<ApplicationUnfurlContentMessage> WithStyle(this Partial<ApplicationUnfurlContentMessage> it, Func<Partial<MessageStyle>, Partial<MessageStyle>> partialBuilder)
        => it.AddFieldName("style", partialBuilder(new Partial<MessageStyle>(it)));
    
    /// <summary>
    /// Line of elements appearing above the main body of the message
    /// </summary>
    public static Partial<ApplicationUnfurlContentMessage> WithOutline(this Partial<ApplicationUnfurlContentMessage> it)
        => it.AddFieldName("outline");
    
    /// <summary>
    /// Line of elements appearing above the main body of the message
    /// </summary>
    public static Partial<ApplicationUnfurlContentMessage> WithOutline(this Partial<ApplicationUnfurlContentMessage> it, Func<Partial<MessageOutlineBase>, Partial<MessageOutlineBase>> partialBuilder)
        => it.AddFieldName("outline", partialBuilder(new Partial<MessageOutlineBase>(it)));
    
    /// <summary>
    /// List of sections of the message
    /// </summary>
    public static Partial<ApplicationUnfurlContentMessage> WithSections(this Partial<ApplicationUnfurlContentMessage> it)
        => it.AddFieldName("sections");
    
    /// <summary>
    /// List of sections of the message
    /// </summary>
    public static Partial<ApplicationUnfurlContentMessage> WithSections(this Partial<ApplicationUnfurlContentMessage> it, Func<Partial<MessageSectionElement>, Partial<MessageSectionElement>> partialBuilder)
        => it.AddFieldName("sections", partialBuilder(new Partial<MessageSectionElement>(it)));
    
}

