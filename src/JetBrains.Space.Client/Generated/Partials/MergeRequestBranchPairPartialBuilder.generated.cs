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

namespace JetBrains.Space.Client.MergeRequestBranchPairPartialBuilder;

public static class MergeRequestBranchPairPartialExtensions
{
    public static Partial<MergeRequestBranchPair> WithRepositoryId(this Partial<MergeRequestBranchPair> it)
        => it.AddFieldName("repositoryId");
    
    public static Partial<MergeRequestBranchPair> WithRepository(this Partial<MergeRequestBranchPair> it)
        => it.AddFieldName("repository");
    
    public static Partial<MergeRequestBranchPair> WithSourceBranch(this Partial<MergeRequestBranchPair> it)
        => it.AddFieldName("sourceBranch");
    
    public static Partial<MergeRequestBranchPair> WithTargetBranch(this Partial<MergeRequestBranchPair> it)
        => it.AddFieldName("targetBranch");
    
    public static Partial<MergeRequestBranchPair> WithSourceBranchRef(this Partial<MergeRequestBranchPair> it)
        => it.AddFieldName("sourceBranchRef");
    
    public static Partial<MergeRequestBranchPair> WithSourceBranchInfo(this Partial<MergeRequestBranchPair> it)
        => it.AddFieldName("sourceBranchInfo");
    
    public static Partial<MergeRequestBranchPair> WithSourceBranchInfo(this Partial<MergeRequestBranchPair> it, Func<Partial<MergeRequestBranch>, Partial<MergeRequestBranch>> partialBuilder)
        => it.AddFieldName("sourceBranchInfo", partialBuilder(new Partial<MergeRequestBranch>(it)));
    
    public static Partial<MergeRequestBranchPair> WithTargetBranchInfo(this Partial<MergeRequestBranchPair> it)
        => it.AddFieldName("targetBranchInfo");
    
    public static Partial<MergeRequestBranchPair> WithTargetBranchInfo(this Partial<MergeRequestBranchPair> it, Func<Partial<MergeRequestBranch>, Partial<MergeRequestBranch>> partialBuilder)
        => it.AddFieldName("targetBranchInfo", partialBuilder(new Partial<MergeRequestBranch>(it)));
    
    public static Partial<MergeRequestBranchPair> WithIsMerged(this Partial<MergeRequestBranchPair> it)
        => it.AddFieldName("isMerged");
    
    public static Partial<MergeRequestBranchPair> WithIsStale(this Partial<MergeRequestBranchPair> it)
        => it.AddFieldName("isStale");
    
}

