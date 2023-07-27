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

namespace JetBrains.Space.Client.DeployTargetRecordPartialBuilder;

public static class DeployTargetRecordPartialExtensions
{
    public static Partial<DeployTargetRecord> WithId(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("id");
    
    public static Partial<DeployTargetRecord> WithProjectId(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("projectId");
    
    public static Partial<DeployTargetRecord> WithName(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("name");
    
    public static Partial<DeployTargetRecord> WithKey(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("key");
    
    public static Partial<DeployTargetRecord> WithDescription(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("description");
    
    public static Partial<DeployTargetRecord> WithCreatedAt(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("createdAt");
    
    public static Partial<DeployTargetRecord> WithLastUpdated(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("lastUpdated");
    
    public static Partial<DeployTargetRecord> WithLastDeployed(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("lastDeployed");
    
    public static Partial<DeployTargetRecord> WithChannel(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("channel");
    
    public static Partial<DeployTargetRecord> WithChannel(this Partial<DeployTargetRecord> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
        => it.AddFieldName("channel", partialBuilder(new Partial<M2ChannelRecord>(it)));
    
    public static Partial<DeployTargetRecord> WithNumber(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("number");
    
    public static Partial<DeployTargetRecord> WithFullNumberId(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("fullNumberId");
    
    public static Partial<DeployTargetRecord> WithIsArchived(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("archived");
    
    public static Partial<DeployTargetRecord> WithChannelId(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("channelId");
    
    public static Partial<DeployTargetRecord> WithConnectedChannelId(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("connectedChannelId");
    
    public static Partial<DeployTargetRecord> WithCreatedBy(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("createdBy");
    
    public static Partial<DeployTargetRecord> WithCreatedBy(this Partial<DeployTargetRecord> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("createdBy", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<DeployTargetRecord> WithCurrent(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("current");
    
    public static Partial<DeployTargetRecord> WithCurrent(this Partial<DeployTargetRecord> it, Func<Partial<DeploymentInfo>, Partial<DeploymentInfo>> partialBuilder)
        => it.AddFieldName("current", partialBuilder(new Partial<DeploymentInfo>(it)));
    
    public static Partial<DeployTargetRecord> WithCustomFields(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("customFields");
    
    public static Partial<DeployTargetRecord> WithCustomFields(this Partial<DeployTargetRecord> it, Func<Partial<CFValue>, Partial<CFValue>> partialBuilder)
        => it.AddFieldName("customFields", partialBuilder(new Partial<CFValue>(it)));
    
    public static Partial<DeployTargetRecord> WithFailTimeoutMinutes(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("failTimeoutMinutes");
    
    public static Partial<DeployTargetRecord> WithHangTimeoutMinutes(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("hangTimeoutMinutes");
    
    public static Partial<DeployTargetRecord> WithLinks(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("links");
    
    public static Partial<DeployTargetRecord> WithLinks(this Partial<DeployTargetRecord> it, Func<Partial<DeployTargetLink>, Partial<DeployTargetLink>> partialBuilder)
        => it.AddFieldName("links", partialBuilder(new Partial<DeployTargetLink>(it)));
    
    public static Partial<DeployTargetRecord> WithIsManualControl(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("manualControl");
    
    public static Partial<DeployTargetRecord> WithNext(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("next");
    
    public static Partial<DeployTargetRecord> WithNext(this Partial<DeployTargetRecord> it, Func<Partial<DeploymentInfo>, Partial<DeploymentInfo>> partialBuilder)
        => it.AddFieldName("next", partialBuilder(new Partial<DeploymentInfo>(it)));
    
    public static Partial<DeployTargetRecord> WithRepositories(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("repositories");
    
    public static Partial<DeployTargetRecord> WithRepositories(this Partial<DeployTargetRecord> it, Func<Partial<DeployTargetRepositoryDTO>, Partial<DeployTargetRepositoryDTO>> partialBuilder)
        => it.AddFieldName("repositories", partialBuilder(new Partial<DeployTargetRepositoryDTO>(it)));
    
    public static Partial<DeployTargetRecord> WithIsSingleScheduled(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("singleScheduled");
    
    public static Partial<DeployTargetRecord> WithTeams(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("teams");
    
    public static Partial<DeployTargetRecord> WithTeams(this Partial<DeployTargetRecord> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
        => it.AddFieldName("teams", partialBuilder(new Partial<TDTeam>(it)));
    
    public static Partial<DeployTargetRecord> WithUsers(this Partial<DeployTargetRecord> it)
        => it.AddFieldName("users");
    
    public static Partial<DeployTargetRecord> WithUsers(this Partial<DeployTargetRecord> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("users", partialBuilder(new Partial<TDMemberProfile>(it)));
    
}

