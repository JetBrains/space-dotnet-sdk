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

namespace JetBrains.Space.Client.ChatContactDetailsDefaultPartialBuilder;

public static class ChatContactDetailsDefaultPartialExtensions
{
    public static Partial<ChatContactDetailsDefault> WithType(this Partial<ChatContactDetailsDefault> it)
        => it.AddFieldName("type");
    
    public static Partial<ChatContactDetailsDefault> WithName(this Partial<ChatContactDetailsDefault> it)
        => it.AddFieldName("name");
    
    public static Partial<ChatContactDetailsDefault> WithIcon(this Partial<ChatContactDetailsDefault> it)
        => it.AddFieldName("icon");
    
    public static Partial<ChatContactDetailsDefault> WithFontIcon(this Partial<ChatContactDetailsDefault> it)
        => it.AddFieldName("fontIcon");
    
    public static Partial<ChatContactDetailsDefault> WithFontIconColor(this Partial<ChatContactDetailsDefault> it)
        => it.AddFieldName("fontIconColor");
    
    public static Partial<ChatContactDetailsDefault> WithFontIconColor(this Partial<ChatContactDetailsDefault> it, Func<Partial<PrivateFeedColor>, Partial<PrivateFeedColor>> partialBuilder)
        => it.AddFieldName("fontIconColor", partialBuilder(new Partial<PrivateFeedColor>(it)));
    
    public static Partial<ChatContactDetailsDefault> WithAccess(this Partial<ChatContactDetailsDefault> it)
        => it.AddFieldName("access");
    
    public static Partial<ChatContactDetailsDefault> WithAccess(this Partial<ChatContactDetailsDefault> it, Func<Partial<M2Access>, Partial<M2Access>> partialBuilder)
        => it.AddFieldName("access", partialBuilder(new Partial<M2Access>(it)));
    
    public static Partial<ChatContactDetailsDefault> WithIsResolvedImpl(this Partial<ChatContactDetailsDefault> it)
        => it.AddFieldName("resolvedImpl");
    
    public static Partial<ChatContactDetailsDefault> WithExtra(this Partial<ChatContactDetailsDefault> it)
        => it.AddFieldName("extra");
    
    public static Partial<ChatContactDetailsDefault> WithExtra(this Partial<ChatContactDetailsDefault> it, Func<Partial<ContactExtraTag>, Partial<ContactExtraTag>> partialBuilder)
        => it.AddFieldName("extra", partialBuilder(new Partial<ContactExtraTag>(it)));
    
}

