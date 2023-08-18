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

[JsonConverter(typeof(ClassNameDtoTypeConverter))]
public abstract class CodeReviewRecord
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "CodeReviewRecord";
    
    public static CommitSetReviewRecord CommitSetReviewRecord(ProjectKey project, string projectId, int number, string title, CodeReviewState state, long createdAt, bool? canBeReopened = null, TDMemberProfile? createdBy = null, long? timestamp = null, bool? turnBased = null, M2ChannelRecord? feedChannel = null, string? feedChannelId = null, bool? readOnly = null)
        => new CommitSetReviewRecord(project: project, projectId: projectId, number: number, title: title, state: state, createdAt: createdAt, canBeReopened: canBeReopened, createdBy: createdBy, timestamp: timestamp, turnBased: turnBased, feedChannel: feedChannel, feedChannelId: feedChannelId, readOnly: readOnly);
    
    public static MergeRequestRecord MergeRequestRecord(ProjectKey project, string projectId, int number, string title, CodeReviewState state, long createdAt, List<MergeRequestBranchPair> branchPairs, bool? canBeReopened = null, TDMemberProfile? createdBy = null, long? timestamp = null, bool? turnBased = null, M2ChannelRecord? feedChannel = null, string? feedChannelId = null, bool? readOnly = null, ExternalCodeReviewLink? externalLink = null)
        => new MergeRequestRecord(project: project, projectId: projectId, number: number, title: title, state: state, createdAt: createdAt, branchPairs: branchPairs, canBeReopened: canBeReopened, createdBy: createdBy, timestamp: timestamp, turnBased: turnBased, feedChannel: feedChannel, feedChannelId: feedChannelId, readOnly: readOnly, externalLink: externalLink);
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeReviewRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<List<CodeReviewParticipantRecord>> _authors = new PropertyValue<List<CodeReviewParticipantRecord>>(nameof(CodeReviewRecord), nameof(Authors), "authors", new List<CodeReviewParticipantRecord>());
    
    [Required]
    [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
    [JsonPropertyName("authors")]
    public List<CodeReviewParticipantRecord> Authors
    {
        get => _authors.GetValue(InlineErrors);
        set => _authors.SetValue(value);
    }

    private PropertyValue<List<ReviewCommit>> _commits = new PropertyValue<List<ReviewCommit>>(nameof(CodeReviewRecord), nameof(Commits), "commits", new List<ReviewCommit>());
    
    [Required]
    [JsonPropertyName("commits")]
    public List<ReviewCommit> Commits
    {
        get => _commits.GetValue(InlineErrors);
        set => _commits.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CodeReviewRecord), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<DiscussionCounter> _discussionCounter = new PropertyValue<DiscussionCounter>(nameof(CodeReviewRecord), nameof(DiscussionCounter), "discussionCounter");
    
    [Required]
    [JsonPropertyName("discussionCounter")]
    public DiscussionCounter DiscussionCounter
    {
        get => _discussionCounter.GetValue(InlineErrors);
        set => _discussionCounter.SetValue(value);
    }

    private PropertyValue<List<ExternalIssueIdOut>?> _externalIssues = new PropertyValue<List<ExternalIssueIdOut>?>(nameof(CodeReviewRecord), nameof(ExternalIssues), "externalIssues");
    
    [JsonPropertyName("externalIssues")]
    public List<ExternalIssueIdOut>? ExternalIssues
    {
        get => _externalIssues.GetValue(InlineErrors);
        set => _externalIssues.SetValue(value);
    }

    private PropertyValue<List<string>> _issueIds = new PropertyValue<List<string>>(nameof(CodeReviewRecord), nameof(IssueIds), "issueIds", new List<string>());
    
    [Required]
    [JsonPropertyName("issueIds")]
    public List<string> IssueIds
    {
        get => _issueIds.GetValue(InlineErrors);
        set => _issueIds.SetValue(value);
    }

    private PropertyValue<List<CodeReviewParticipant>?> _participants = new PropertyValue<List<CodeReviewParticipant>?>(nameof(CodeReviewRecord), nameof(Participants), "participants");
    
    [JsonPropertyName("participants")]
    public List<CodeReviewParticipant>? Participants
    {
        get => _participants.GetValue(InlineErrors);
        set => _participants.SetValue(value);
    }

    private PropertyValue<List<CodeReviewParticipantRecord>> _reviewers = new PropertyValue<List<CodeReviewParticipantRecord>>(nameof(CodeReviewRecord), nameof(Reviewers), "reviewers", new List<CodeReviewParticipantRecord>());
    
    [Required]
    [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
    [JsonPropertyName("reviewers")]
    public List<CodeReviewParticipantRecord> Reviewers
    {
        get => _reviewers.GetValue(InlineErrors);
        set => _reviewers.SetValue(value);
    }

    private PropertyValue<List<Attachment>> _unfurls = new PropertyValue<List<Attachment>>(nameof(CodeReviewRecord), nameof(Unfurls), "unfurls", new List<Attachment>());
    
    [Required]
    [JsonPropertyName("unfurls")]
    public List<Attachment> Unfurls
    {
        get => _unfurls.GetValue(InlineErrors);
        set => _unfurls.SetValue(value);
    }

    private PropertyValue<List<CodeReviewParticipantRecord>> _watchers = new PropertyValue<List<CodeReviewParticipantRecord>>(nameof(CodeReviewRecord), nameof(Watchers), "watchers", new List<CodeReviewParticipantRecord>());
    
    [Required]
    [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
    [JsonPropertyName("watchers")]
    public List<CodeReviewParticipantRecord> Watchers
    {
        get => _watchers.GetValue(InlineErrors);
        set => _watchers.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authors.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commits.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _discussionCounter.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalIssues.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueIds.SetAccessPath(parentChainPath, validateHasBeenSet);
        _participants.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviewers.SetAccessPath(parentChainPath, validateHasBeenSet);
        _unfurls.SetAccessPath(parentChainPath, validateHasBeenSet);
        _watchers.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

