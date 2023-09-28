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

namespace JetBrains.Space.Client.AdditionalRepositoryInfoPartialBuilder;

public static class AdditionalRepositoryInfoPartialExtensions
{
    public static Partial<AdditionalRepositoryInfo> WithRepoName(this Partial<AdditionalRepositoryInfo> it)
        => it.AddFieldName("repoName");
    
    public static Partial<AdditionalRepositoryInfo> WithStats(this Partial<AdditionalRepositoryInfo> it)
        => it.AddFieldName("stats");
    
    public static Partial<AdditionalRepositoryInfo> WithStats(this Partial<AdditionalRepositoryInfo> it, Func<Partial<RepoStats>, Partial<RepoStats>> partialBuilder)
        => it.AddFieldName("stats", partialBuilder(new Partial<RepoStats>(it)));
    
    public static Partial<AdditionalRepositoryInfo> WithProjectsRepoAttachedTo(this Partial<AdditionalRepositoryInfo> it)
        => it.AddFieldName("projectsRepoAttachedTo");
    
    public static Partial<AdditionalRepositoryInfo> WithProjectsRepoAttachedTo(this Partial<AdditionalRepositoryInfo> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("projectsRepoAttachedTo", partialBuilder(new Partial<PRProject>(it)));
    
}

