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

public sealed class GitCommitWithGraph
     : IPropagatePropertyAccessPath
{
    public GitCommitWithGraph() { }
    
    public GitCommitWithGraph(string repositoryName, GitCommitInfo commit, List<Unfurl> commitMessageUnfurls, List<CodeReviewRecord> reviews, List<string> issueIds, List<Pair<string, string>> deployments, bool unreachable, List<GenericIssueId>? linkedIssues = null, GitGraphLayoutLine? layout = null)
    {
        RepositoryName = repositoryName;
        Commit = commit;
        CommitMessageUnfurls = commitMessageUnfurls;
        Reviews = reviews;
        IssueIds = issueIds;
        LinkedIssues = linkedIssues;
        Deployments = deployments;
        Layout = layout;
        IsUnreachable = unreachable;
    }
    
    private PropertyValue<string> _repositoryName = new PropertyValue<string>(nameof(GitCommitWithGraph), nameof(RepositoryName), "repositoryName");
    
    [Required]
    [JsonPropertyName("repositoryName")]
    public string RepositoryName
    {
        get => _repositoryName.GetValue(InlineErrors);
        set => _repositoryName.SetValue(value);
    }

    private PropertyValue<GitCommitInfo> _commit = new PropertyValue<GitCommitInfo>(nameof(GitCommitWithGraph), nameof(Commit), "commit");
    
    [Required]
    [JsonPropertyName("commit")]
    public GitCommitInfo Commit
    {
        get => _commit.GetValue(InlineErrors);
        set => _commit.SetValue(value);
    }

    private PropertyValue<List<Unfurl>> _commitMessageUnfurls = new PropertyValue<List<Unfurl>>(nameof(GitCommitWithGraph), nameof(CommitMessageUnfurls), "commitMessageUnfurls", new List<Unfurl>());
    
    [Required]
    [JsonPropertyName("commitMessageUnfurls")]
    public List<Unfurl> CommitMessageUnfurls
    {
        get => _commitMessageUnfurls.GetValue(InlineErrors);
        set => _commitMessageUnfurls.SetValue(value);
    }

    private PropertyValue<List<CodeReviewRecord>> _reviews = new PropertyValue<List<CodeReviewRecord>>(nameof(GitCommitWithGraph), nameof(Reviews), "reviews", new List<CodeReviewRecord>());
    
    [Required]
    [JsonPropertyName("reviews")]
    public List<CodeReviewRecord> Reviews
    {
        get => _reviews.GetValue(InlineErrors);
        set => _reviews.SetValue(value);
    }

    private PropertyValue<List<string>> _issueIds = new PropertyValue<List<string>>(nameof(GitCommitWithGraph), nameof(IssueIds), "issueIds", new List<string>());
    
    [Required]
    [JsonPropertyName("issueIds")]
    public List<string> IssueIds
    {
        get => _issueIds.GetValue(InlineErrors);
        set => _issueIds.SetValue(value);
    }

    private PropertyValue<List<GenericIssueId>?> _linkedIssues = new PropertyValue<List<GenericIssueId>?>(nameof(GitCommitWithGraph), nameof(LinkedIssues), "linkedIssues");
    
    [JsonPropertyName("linkedIssues")]
    public List<GenericIssueId>? LinkedIssues
    {
        get => _linkedIssues.GetValue(InlineErrors);
        set => _linkedIssues.SetValue(value);
    }

    private PropertyValue<List<Pair<string, string>>> _deployments = new PropertyValue<List<Pair<string, string>>>(nameof(GitCommitWithGraph), nameof(Deployments), "deployments", new List<Pair<string, string>>());
    
    [Required]
    [JsonPropertyName("deployments")]
    public List<Pair<string, string>> Deployments
    {
        get => _deployments.GetValue(InlineErrors);
        set => _deployments.SetValue(value);
    }

    private PropertyValue<GitGraphLayoutLine?> _layout = new PropertyValue<GitGraphLayoutLine?>(nameof(GitCommitWithGraph), nameof(Layout), "layout");
    
    [JsonPropertyName("layout")]
    public GitGraphLayoutLine? Layout
    {
        get => _layout.GetValue(InlineErrors);
        set => _layout.SetValue(value);
    }

    private PropertyValue<bool> _unreachable = new PropertyValue<bool>(nameof(GitCommitWithGraph), nameof(IsUnreachable), "unreachable");
    
    [Required]
    [JsonPropertyName("unreachable")]
    public bool IsUnreachable
    {
        get => _unreachable.GetValue(InlineErrors);
        set => _unreachable.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _repositoryName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commit.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitMessageUnfurls.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviews.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueIds.SetAccessPath(parentChainPath, validateHasBeenSet);
        _linkedIssues.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deployments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _layout.SetAccessPath(parentChainPath, validateHasBeenSet);
        _unreachable.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

