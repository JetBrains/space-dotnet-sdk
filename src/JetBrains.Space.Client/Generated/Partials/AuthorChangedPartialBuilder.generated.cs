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

namespace JetBrains.Space.Client.AuthorChangedPartialBuilder;

public static class AuthorChangedPartialExtensions
{
    public static Partial<AuthorChanged> WithProfile(this Partial<AuthorChanged> it)
        => it.AddFieldName("profile");
    
    public static Partial<AuthorChanged> WithProfile(this Partial<AuthorChanged> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<AuthorChanged> WithChangeType(this Partial<AuthorChanged> it)
        => it.AddFieldName("changeType");
    
    public static Partial<AuthorChanged> WithChangeType(this Partial<AuthorChanged> it, Func<Partial<ReviewerChangedType>, Partial<ReviewerChangedType>> partialBuilder)
        => it.AddFieldName("changeType", partialBuilder(new Partial<ReviewerChangedType>(it)));
    
}
