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

public sealed class DeploymentRecord
     : DeploymentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "DeploymentRecord";
    
    public DeploymentRecord() { }
    
    public DeploymentRecord(string id, string version, DateTime createdAt, DeploymentStatus status, M2ChannelRecord channel, DeployTargetRecord target, string targetKey, DeploymentSyncStatus syncStatus, List<DeploymentCommitRefDetails> commitRefs, bool archived, DateTime? scheduledStart = null, DateTime? startedAt = null, DateTime? finishedAt = null, string? description = null, List<string>? jobIds = null, ExternalLink? externalLink = null, int? commitsAdded = null, int? mergesAdded = null, int? issuesAdded = null, int? commitsReverted = null, int? mergesReverted = null, int? issuesReverted = null)
    {
        Id = id;
        Version = version;
        ScheduledStart = scheduledStart;
        StartedAt = startedAt;
        FinishedAt = finishedAt;
        CreatedAt = createdAt;
        Status = status;
        Description = description;
        Channel = channel;
        Target = target;
        TargetKey = targetKey;
        SyncStatus = syncStatus;
        CommitRefs = commitRefs;
        JobIds = jobIds;
        ExternalLink = externalLink;
        IsArchived = archived;
        CommitsAdded = commitsAdded;
        MergesAdded = mergesAdded;
        IssuesAdded = issuesAdded;
        CommitsReverted = commitsReverted;
        MergesReverted = mergesReverted;
        IssuesReverted = issuesReverted;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(DeploymentRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _version = new PropertyValue<string>(nameof(DeploymentRecord), nameof(Version), "version");
    
    [Required]
    [JsonPropertyName("version")]
    public string Version
    {
        get => _version.GetValue(InlineErrors);
        set => _version.SetValue(value);
    }

    private PropertyValue<DateTime?> _scheduledStart = new PropertyValue<DateTime?>(nameof(DeploymentRecord), nameof(ScheduledStart), "scheduledStart");
    
    [JsonPropertyName("scheduledStart")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? ScheduledStart
    {
        get => _scheduledStart.GetValue(InlineErrors);
        set => _scheduledStart.SetValue(value);
    }

    private PropertyValue<DateTime?> _startedAt = new PropertyValue<DateTime?>(nameof(DeploymentRecord), nameof(StartedAt), "startedAt");
    
    [JsonPropertyName("startedAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? StartedAt
    {
        get => _startedAt.GetValue(InlineErrors);
        set => _startedAt.SetValue(value);
    }

    private PropertyValue<DateTime?> _finishedAt = new PropertyValue<DateTime?>(nameof(DeploymentRecord), nameof(FinishedAt), "finishedAt");
    
    [JsonPropertyName("finishedAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? FinishedAt
    {
        get => _finishedAt.GetValue(InlineErrors);
        set => _finishedAt.SetValue(value);
    }

    private PropertyValue<DateTime> _createdAt = new PropertyValue<DateTime>(nameof(DeploymentRecord), nameof(CreatedAt), "createdAt");
    
    [Required]
    [JsonPropertyName("createdAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime CreatedAt
    {
        get => _createdAt.GetValue(InlineErrors);
        set => _createdAt.SetValue(value);
    }

    private PropertyValue<DeploymentStatus> _status = new PropertyValue<DeploymentStatus>(nameof(DeploymentRecord), nameof(Status), "status");
    
    [Required]
    [JsonPropertyName("status")]
    public DeploymentStatus Status
    {
        get => _status.GetValue(InlineErrors);
        set => _status.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(DeploymentRecord), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<M2ChannelRecord> _channel = new PropertyValue<M2ChannelRecord>(nameof(DeploymentRecord), nameof(Channel), "channel");
    
    [Required]
    [JsonPropertyName("channel")]
    public M2ChannelRecord Channel
    {
        get => _channel.GetValue(InlineErrors);
        set => _channel.SetValue(value);
    }

    private PropertyValue<DeployTargetRecord> _target = new PropertyValue<DeployTargetRecord>(nameof(DeploymentRecord), nameof(Target), "target");
    
    [Required]
    [JsonPropertyName("target")]
    public DeployTargetRecord Target
    {
        get => _target.GetValue(InlineErrors);
        set => _target.SetValue(value);
    }

    private PropertyValue<string> _targetKey = new PropertyValue<string>(nameof(DeploymentRecord), nameof(TargetKey), "targetKey");
    
    [Required]
    [JsonPropertyName("targetKey")]
    public string TargetKey
    {
        get => _targetKey.GetValue(InlineErrors);
        set => _targetKey.SetValue(value);
    }

    private PropertyValue<DeploymentSyncStatus> _syncStatus = new PropertyValue<DeploymentSyncStatus>(nameof(DeploymentRecord), nameof(SyncStatus), "syncStatus");
    
    [Required]
    [JsonPropertyName("syncStatus")]
    public DeploymentSyncStatus SyncStatus
    {
        get => _syncStatus.GetValue(InlineErrors);
        set => _syncStatus.SetValue(value);
    }

    private PropertyValue<List<DeploymentCommitRefDetails>> _commitRefs = new PropertyValue<List<DeploymentCommitRefDetails>>(nameof(DeploymentRecord), nameof(CommitRefs), "commitRefs", new List<DeploymentCommitRefDetails>());
    
    [Required]
    [JsonPropertyName("commitRefs")]
    public List<DeploymentCommitRefDetails> CommitRefs
    {
        get => _commitRefs.GetValue(InlineErrors);
        set => _commitRefs.SetValue(value);
    }

    private PropertyValue<List<string>?> _jobIds = new PropertyValue<List<string>?>(nameof(DeploymentRecord), nameof(JobIds), "jobIds");
    
    [JsonPropertyName("jobIds")]
    public List<string>? JobIds
    {
        get => _jobIds.GetValue(InlineErrors);
        set => _jobIds.SetValue(value);
    }

    private PropertyValue<ExternalLink?> _externalLink = new PropertyValue<ExternalLink?>(nameof(DeploymentRecord), nameof(ExternalLink), "externalLink");
    
    [JsonPropertyName("externalLink")]
    public ExternalLink? ExternalLink
    {
        get => _externalLink.GetValue(InlineErrors);
        set => _externalLink.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(DeploymentRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<int?> _commitsAdded = new PropertyValue<int?>(nameof(DeploymentRecord), nameof(CommitsAdded), "commitsAdded");
    
    [JsonPropertyName("commitsAdded")]
    public int? CommitsAdded
    {
        get => _commitsAdded.GetValue(InlineErrors);
        set => _commitsAdded.SetValue(value);
    }

    private PropertyValue<int?> _mergesAdded = new PropertyValue<int?>(nameof(DeploymentRecord), nameof(MergesAdded), "mergesAdded");
    
    [JsonPropertyName("mergesAdded")]
    public int? MergesAdded
    {
        get => _mergesAdded.GetValue(InlineErrors);
        set => _mergesAdded.SetValue(value);
    }

    private PropertyValue<int?> _issuesAdded = new PropertyValue<int?>(nameof(DeploymentRecord), nameof(IssuesAdded), "issuesAdded");
    
    [JsonPropertyName("issuesAdded")]
    public int? IssuesAdded
    {
        get => _issuesAdded.GetValue(InlineErrors);
        set => _issuesAdded.SetValue(value);
    }

    private PropertyValue<int?> _commitsReverted = new PropertyValue<int?>(nameof(DeploymentRecord), nameof(CommitsReverted), "commitsReverted");
    
    [JsonPropertyName("commitsReverted")]
    public int? CommitsReverted
    {
        get => _commitsReverted.GetValue(InlineErrors);
        set => _commitsReverted.SetValue(value);
    }

    private PropertyValue<int?> _mergesReverted = new PropertyValue<int?>(nameof(DeploymentRecord), nameof(MergesReverted), "mergesReverted");
    
    [JsonPropertyName("mergesReverted")]
    public int? MergesReverted
    {
        get => _mergesReverted.GetValue(InlineErrors);
        set => _mergesReverted.SetValue(value);
    }

    private PropertyValue<int?> _issuesReverted = new PropertyValue<int?>(nameof(DeploymentRecord), nameof(IssuesReverted), "issuesReverted");
    
    [JsonPropertyName("issuesReverted")]
    public int? IssuesReverted
    {
        get => _issuesReverted.GetValue(InlineErrors);
        set => _issuesReverted.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _version.SetAccessPath(parentChainPath, validateHasBeenSet);
        _scheduledStart.SetAccessPath(parentChainPath, validateHasBeenSet);
        _startedAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _finishedAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _status.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _channel.SetAccessPath(parentChainPath, validateHasBeenSet);
        _target.SetAccessPath(parentChainPath, validateHasBeenSet);
        _targetKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _syncStatus.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitRefs.SetAccessPath(parentChainPath, validateHasBeenSet);
        _jobIds.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalLink.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitsAdded.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mergesAdded.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issuesAdded.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitsReverted.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mergesReverted.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issuesReverted.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

