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

namespace JetBrains.Space.Client.MergeRequestQualityGateSettingsPartialBuilder;

public static class MergeRequestQualityGateSettingsPartialExtensions
{
    public static Partial<MergeRequestQualityGateSettings> WithRules(this Partial<MergeRequestQualityGateSettings> it)
        => it.AddFieldName("rules");
    
    public static Partial<MergeRequestQualityGateSettings> WithRules(this Partial<MergeRequestQualityGateSettings> it, Func<Partial<MergeRequestQualityGateSettingsRule>, Partial<MergeRequestQualityGateSettingsRule>> partialBuilder)
        => it.AddFieldName("rules", partialBuilder(new Partial<MergeRequestQualityGateSettingsRule>(it)));
    
    public static Partial<MergeRequestQualityGateSettings> WithUsers(this Partial<MergeRequestQualityGateSettings> it)
        => it.AddFieldName("users");
    
    public static Partial<MergeRequestQualityGateSettings> WithUsers(this Partial<MergeRequestQualityGateSettings> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("users", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<MergeRequestQualityGateSettings> WithApplications(this Partial<MergeRequestQualityGateSettings> it)
        => it.AddFieldName("applications");
    
    public static Partial<MergeRequestQualityGateSettings> WithApplications(this Partial<MergeRequestQualityGateSettings> it, Func<Partial<ESApp>, Partial<ESApp>> partialBuilder)
        => it.AddFieldName("applications", partialBuilder(new Partial<ESApp>(it)));
    
    public static Partial<MergeRequestQualityGateSettings> WithRoles(this Partial<MergeRequestQualityGateSettings> it)
        => it.AddFieldName("roles");
    
    public static Partial<MergeRequestQualityGateSettings> WithRoles(this Partial<MergeRequestQualityGateSettings> it, Func<Partial<Role>, Partial<Role>> partialBuilder)
        => it.AddFieldName("roles", partialBuilder(new Partial<Role>(it)));
    
    public static Partial<MergeRequestQualityGateSettings> WithRoles2(this Partial<MergeRequestQualityGateSettings> it)
        => it.AddFieldName("roles2");
    
    public static Partial<MergeRequestQualityGateSettings> WithRoles2(this Partial<MergeRequestQualityGateSettings> it, Func<Partial<RoleDTO>, Partial<RoleDTO>> partialBuilder)
        => it.AddFieldName("roles2", partialBuilder(new Partial<RoleDTO>(it)));
    
    public static Partial<MergeRequestQualityGateSettings> WithIsSafeMerge(this Partial<MergeRequestQualityGateSettings> it)
        => it.AddFieldName("safeMerge");
    
}
