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

namespace JetBrains.Space.Client.RtLinkAttrsPartialBuilder;

public static class RtLinkAttrsPartialExtensions
{
    public static Partial<RtLinkAttrs> WithHref(this Partial<RtLinkAttrs> it)
        => it.AddFieldName("href");
    
    public static Partial<RtLinkAttrs> WithTitle(this Partial<RtLinkAttrs> it)
        => it.AddFieldName("title");
    
    public static Partial<RtLinkAttrs> WithMention(this Partial<RtLinkAttrs> it)
        => it.AddFieldName("mention");
    
    public static Partial<RtLinkAttrs> WithDetails(this Partial<RtLinkAttrs> it)
        => it.AddFieldName("details");
    
    public static Partial<RtLinkAttrs> WithDetails(this Partial<RtLinkAttrs> it, Func<Partial<RtLinkDetails>, Partial<RtLinkDetails>> partialBuilder)
        => it.AddFieldName("details", partialBuilder(new Partial<RtLinkDetails>(it)));
    
}

