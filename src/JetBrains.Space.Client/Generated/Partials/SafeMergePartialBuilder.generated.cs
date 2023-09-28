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

namespace JetBrains.Space.Client.SafeMergePartialBuilder;

public static class SafeMergePartialExtensions
{
    public static Partial<SafeMerge> WithState(this Partial<SafeMerge> it)
        => it.AddFieldName("state");
    
    public static Partial<SafeMerge> WithState(this Partial<SafeMerge> it, Func<Partial<SafeMergeState>, Partial<SafeMergeState>> partialBuilder)
        => it.AddFieldName("state", partialBuilder(new Partial<SafeMergeState>(it)));
    
    public static Partial<SafeMerge> WithMergeCommitId(this Partial<SafeMerge> it)
        => it.AddFieldName("mergeCommitId");
    
    public static Partial<SafeMerge> WithChecks(this Partial<SafeMerge> it)
        => it.AddFieldName("checks");
    
    public static Partial<SafeMerge> WithChecks(this Partial<SafeMerge> it, Func<Partial<SafeMergeCheck>, Partial<SafeMergeCheck>> partialBuilder)
        => it.AddFieldName("checks", partialBuilder(new Partial<SafeMergeCheck>(it)));
    
    public static Partial<SafeMerge> WithMergeOptions(this Partial<SafeMerge> it)
        => it.AddFieldName("mergeOptions");
    
    public static Partial<SafeMerge> WithMergeOptions(this Partial<SafeMerge> it, Func<Partial<MergeSelectOptions>, Partial<MergeSelectOptions>> partialBuilder)
        => it.AddFieldName("mergeOptions", partialBuilder(new Partial<MergeSelectOptions>(it)));
    
    public static Partial<SafeMerge> WithStartedBy(this Partial<SafeMerge> it)
        => it.AddFieldName("startedBy");
    
    public static Partial<SafeMerge> WithStartedBy(this Partial<SafeMerge> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("startedBy", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<SafeMerge> WithStartedAt(this Partial<SafeMerge> it)
        => it.AddFieldName("startedAt");
    
    public static Partial<SafeMerge> WithDuration(this Partial<SafeMerge> it)
        => it.AddFieldName("duration");
    
    public static Partial<SafeMerge> WithAttempts(this Partial<SafeMerge> it)
        => it.AddFieldName("attempts");
    
}

