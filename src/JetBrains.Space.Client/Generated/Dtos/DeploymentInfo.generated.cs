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

namespace JetBrains.Space.Client;

public interface DeploymentInfo
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static DeploymentData DeploymentData(string id, string version, DateTime createdAt, string targetKey, DeploymentStatus status, DeploymentSyncStatus syncStatus, List<DeploymentCommitRefDetails> commitRefs, DateTime? scheduledStart = null, DateTime? startedAt = null, DateTime? finishedAt = null, ExternalLink? externalLink = null)
        => new DeploymentData(id: id, version: version, createdAt: createdAt, targetKey: targetKey, status: status, syncStatus: syncStatus, commitRefs: commitRefs, scheduledStart: scheduledStart, startedAt: startedAt, finishedAt: finishedAt, externalLink: externalLink);
    
    public static DeploymentRecord DeploymentRecord(string id, string version, DateTime createdAt, DeploymentStatus status, M2ChannelRecord channel, DeployTargetRecord target, string targetKey, DeploymentSyncStatus syncStatus, List<DeploymentCommitRefDetails> commitRefs, bool archived, DateTime? scheduledStart = null, DateTime? startedAt = null, DateTime? finishedAt = null, string? description = null, List<string>? jobIds = null, ExternalLink? externalLink = null, int? totalCommits = null, int? totalMerges = null, int? totalIssues = null)
        => new DeploymentRecord(id: id, version: version, createdAt: createdAt, status: status, channel: channel, target: target, targetKey: targetKey, syncStatus: syncStatus, commitRefs: commitRefs, archived: archived, scheduledStart: scheduledStart, startedAt: startedAt, finishedAt: finishedAt, description: description, jobIds: jobIds, externalLink: externalLink, totalCommits: totalCommits, totalMerges: totalMerges, totalIssues: totalIssues);
    
}

