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

namespace JetBrains.Space.Client.DeployTargetAuditLogEntryPartialBuilder;

public static class DeployTargetAuditLogEntryPartialExtensions
{
    public static Partial<DeployTargetAuditLogEntry> WithCreated(this Partial<DeployTargetAuditLogEntry> it)
        => it.AddFieldName("created");
    
    public static Partial<DeployTargetAuditLogEntry> WithAuthor(this Partial<DeployTargetAuditLogEntry> it)
        => it.AddFieldName("author");
    
    public static Partial<DeployTargetAuditLogEntry> WithAuthor(this Partial<DeployTargetAuditLogEntry> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("author", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<DeployTargetAuditLogEntry> WithText(this Partial<DeployTargetAuditLogEntry> it)
        => it.AddFieldName("text");
    
    public static Partial<DeployTargetAuditLogEntry> WithChanges(this Partial<DeployTargetAuditLogEntry> it)
        => it.AddFieldName("changes");
    
    public static Partial<DeployTargetAuditLogEntry> WithChanges(this Partial<DeployTargetAuditLogEntry> it, Func<Partial<DeployTargetFieldMod>, Partial<DeployTargetFieldMod>> partialBuilder)
        => it.AddFieldName("changes", partialBuilder(new Partial<DeployTargetFieldMod>(it)));
    
    public static Partial<DeployTargetAuditLogEntry> WithChannelItem(this Partial<DeployTargetAuditLogEntry> it)
        => it.AddFieldName("channelItem");
    
    public static Partial<DeployTargetAuditLogEntry> WithChannelItem(this Partial<DeployTargetAuditLogEntry> it, Func<Partial<ChannelItemRecord>, Partial<ChannelItemRecord>> partialBuilder)
        => it.AddFieldName("channelItem", partialBuilder(new Partial<ChannelItemRecord>(it)));
    
}

