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

namespace JetBrains.Space.Client.GitRepositorySettingsQualityGatePartialBuilder;

public static class GitRepositorySettingsQualityGatePartialExtensions
{
    public static Partial<GitRepositorySettingsQualityGate> WithAllowMergeFor(this Partial<GitRepositorySettingsQualityGate> it)
        => it.AddFieldName("allowMergeFor");
    
    public static Partial<GitRepositorySettingsQualityGate> WithAllowBypassFor(this Partial<GitRepositorySettingsQualityGate> it)
        => it.AddFieldName("allowBypassFor");
    
    public static Partial<GitRepositorySettingsQualityGate> WithExternalStatusEx(this Partial<GitRepositorySettingsQualityGate> it)
        => it.AddFieldName("externalStatusEx");
    
    public static Partial<GitRepositorySettingsQualityGate> WithExternalStatusEx(this Partial<GitRepositorySettingsQualityGate> it, Func<Partial<GitRepositorySettingsExternalStatus>, Partial<GitRepositorySettingsExternalStatus>> partialBuilder)
        => it.AddFieldName("externalStatusEx", partialBuilder(new Partial<GitRepositorySettingsExternalStatus>(it)));
    
    public static Partial<GitRepositorySettingsQualityGate> WithExternalStatus(this Partial<GitRepositorySettingsQualityGate> it)
        => it.AddFieldName("externalStatus");
    
    public static Partial<GitRepositorySettingsQualityGate> WithAutomationJobs(this Partial<GitRepositorySettingsQualityGate> it)
        => it.AddFieldName("automationJobs");
    
    public static Partial<GitRepositorySettingsQualityGate> WithApprovals(this Partial<GitRepositorySettingsQualityGate> it)
        => it.AddFieldName("approvals");
    
    public static Partial<GitRepositorySettingsQualityGate> WithApprovals(this Partial<GitRepositorySettingsQualityGate> it, Func<Partial<GitRepositorySettingsQualityGateApproval>, Partial<GitRepositorySettingsQualityGateApproval>> partialBuilder)
        => it.AddFieldName("approvals", partialBuilder(new Partial<GitRepositorySettingsQualityGateApproval>(it)));
    
    public static Partial<GitRepositorySettingsQualityGate> WithIsCodeOwnersApproval(this Partial<GitRepositorySettingsQualityGate> it)
        => it.AddFieldName("codeOwnersApproval");
    
    public static Partial<GitRepositorySettingsQualityGate> WithIsAllowSelfApproval(this Partial<GitRepositorySettingsQualityGate> it)
        => it.AddFieldName("allowSelfApproval");
    
}

