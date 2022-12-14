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

namespace JetBrains.Space.Client.GitRepositorySettingsPartialBuilder;

public static class GitRepositorySettingsPartialExtensions
{
    public static Partial<GitRepositorySettings> WithVersion(this Partial<GitRepositorySettings> it)
        => it.AddFieldName("version");
    
    public static Partial<GitRepositorySettings> WithMirror(this Partial<GitRepositorySettings> it)
        => it.AddFieldName("mirror");
    
    public static Partial<GitRepositorySettings> WithMirror(this Partial<GitRepositorySettings> it, Func<Partial<GitRepositorySettingsMirrorSettings>, Partial<GitRepositorySettingsMirrorSettings>> partialBuilder)
        => it.AddFieldName("mirror", partialBuilder(new Partial<GitRepositorySettingsMirrorSettings>(it)));
    
    public static Partial<GitRepositorySettings> WithEncoding(this Partial<GitRepositorySettings> it)
        => it.AddFieldName("encoding");
    
    public static Partial<GitRepositorySettings> WithPushRestrictions(this Partial<GitRepositorySettings> it)
        => it.AddFieldName("pushRestrictions");
    
    public static Partial<GitRepositorySettings> WithPushRestrictions(this Partial<GitRepositorySettings> it, Func<Partial<GitRepositorySettingsPushRestrictions>, Partial<GitRepositorySettingsPushRestrictions>> partialBuilder)
        => it.AddFieldName("pushRestrictions", partialBuilder(new Partial<GitRepositorySettingsPushRestrictions>(it)));
    
    public static Partial<GitRepositorySettings> WithProtectedBranches(this Partial<GitRepositorySettings> it)
        => it.AddFieldName("protectedBranches");
    
    public static Partial<GitRepositorySettings> WithProtectedBranches(this Partial<GitRepositorySettings> it, Func<Partial<GitRepositorySettingsProtectedBranch>, Partial<GitRepositorySettingsProtectedBranch>> partialBuilder)
        => it.AddFieldName("protectedBranches", partialBuilder(new Partial<GitRepositorySettingsProtectedBranch>(it)));
    
    public static Partial<GitRepositorySettings> WithPreReceiveHook(this Partial<GitRepositorySettings> it)
        => it.AddFieldName("preReceiveHook");
    
    public static Partial<GitRepositorySettings> WithPreReceiveHook(this Partial<GitRepositorySettings> it, Func<Partial<GitRepositorySettingsPreReceiveHook>, Partial<GitRepositorySettingsPreReceiveHook>> partialBuilder)
        => it.AddFieldName("preReceiveHook", partialBuilder(new Partial<GitRepositorySettingsPreReceiveHook>(it)));
    
}

