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

namespace JetBrains.Space.Client.GitRepositorySettingsMergeOptionsPartialBuilder;

public static class GitRepositorySettingsMergeOptionsPartialExtensions
{
    public static Partial<GitRepositorySettingsMergeOptions> WithIsAllowMerge(this Partial<GitRepositorySettingsMergeOptions> it)
        => it.AddFieldName("allowMerge");
    
    public static Partial<GitRepositorySettingsMergeOptions> WithMergeMessageOption(this Partial<GitRepositorySettingsMergeOptions> it)
        => it.AddFieldName("mergeMessageOption");
    
    public static Partial<GitRepositorySettingsMergeOptions> WithMergeMessageOption(this Partial<GitRepositorySettingsMergeOptions> it, Func<Partial<GitRepositorySettingsMergeOptionsMergeMessageOption>, Partial<GitRepositorySettingsMergeOptionsMergeMessageOption>> partialBuilder)
        => it.AddFieldName("mergeMessageOption", partialBuilder(new Partial<GitRepositorySettingsMergeOptionsMergeMessageOption>(it)));
    
    public static Partial<GitRepositorySettingsMergeOptions> WithIsAllowRebase(this Partial<GitRepositorySettingsMergeOptions> it)
        => it.AddFieldName("allowRebase");
    
    public static Partial<GitRepositorySettingsMergeOptions> WithIsAllowSquash(this Partial<GitRepositorySettingsMergeOptions> it)
        => it.AddFieldName("allowSquash");
    
    public static Partial<GitRepositorySettingsMergeOptions> WithSquashMessageOption(this Partial<GitRepositorySettingsMergeOptions> it)
        => it.AddFieldName("squashMessageOption");
    
    public static Partial<GitRepositorySettingsMergeOptions> WithSquashMessageOption(this Partial<GitRepositorySettingsMergeOptions> it, Func<Partial<GitRepositorySettingsMergeOptionsSquashMessageOption>, Partial<GitRepositorySettingsMergeOptionsSquashMessageOption>> partialBuilder)
        => it.AddFieldName("squashMessageOption", partialBuilder(new Partial<GitRepositorySettingsMergeOptionsSquashMessageOption>(it)));
    
}

