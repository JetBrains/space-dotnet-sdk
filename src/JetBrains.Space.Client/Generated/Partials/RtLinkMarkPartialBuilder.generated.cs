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

namespace JetBrains.Space.Client.RtLinkMarkPartialBuilder;

public static class RtLinkMarkPartialExtensions
{
    public static Partial<RtLinkMark> WithHref(this Partial<RtLinkMark> it)
        => it.AddFieldName("href");
    
    public static Partial<RtLinkMark> WithTitle(this Partial<RtLinkMark> it)
        => it.AddFieldName("title");
    
    public static Partial<RtLinkMark> WithMention(this Partial<RtLinkMark> it)
        => it.AddFieldName("mention");
    
    public static Partial<RtLinkMark> WithDetails(this Partial<RtLinkMark> it)
        => it.AddFieldName("details");
    
    public static Partial<RtLinkMark> WithDetails(this Partial<RtLinkMark> it, Func<Partial<RtLinkDetails>, Partial<RtLinkDetails>> partialBuilder)
        => it.AddFieldName("details", partialBuilder(new Partial<RtLinkDetails>(it)));
    
    public static Partial<RtLinkMark> WithAttrs(this Partial<RtLinkMark> it)
        => it.AddFieldName("attrs");
    
    public static Partial<RtLinkMark> WithAttrs(this Partial<RtLinkMark> it, Func<Partial<RtLinkAttrs>, Partial<RtLinkAttrs>> partialBuilder)
        => it.AddFieldName("attrs", partialBuilder(new Partial<RtLinkAttrs>(it)));
    
}

