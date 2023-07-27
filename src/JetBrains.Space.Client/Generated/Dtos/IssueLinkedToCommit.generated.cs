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

public sealed class IssueLinkedToCommit
     : ExternalIssueEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "IssueLinkedToCommit";
    
    public IssueLinkedToCommit() { }
    
    public IssueLinkedToCommit(PRProject project, string repositoryId, string repositoryName, GitCommitInfo commit, string commitUrl, string issuePrefix, string issueId, GitCommitChanges? commitChanges = null)
    {
        Project = project;
        RepositoryId = repositoryId;
        RepositoryName = repositoryName;
        Commit = commit;
        CommitChanges = commitChanges;
        CommitUrl = commitUrl;
        IssuePrefix = issuePrefix;
        IssueId = issueId;
    }
    
    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(IssueLinkedToCommit), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _repositoryId = new PropertyValue<string>(nameof(IssueLinkedToCommit), nameof(RepositoryId), "repositoryId");
    
    [Required]
    [JsonPropertyName("repositoryId")]
    public string RepositoryId
    {
        get => _repositoryId.GetValue(InlineErrors);
        set => _repositoryId.SetValue(value);
    }

    private PropertyValue<string> _repositoryName = new PropertyValue<string>(nameof(IssueLinkedToCommit), nameof(RepositoryName), "repositoryName");
    
    [Required]
    [JsonPropertyName("repositoryName")]
    public string RepositoryName
    {
        get => _repositoryName.GetValue(InlineErrors);
        set => _repositoryName.SetValue(value);
    }

    private PropertyValue<GitCommitInfo> _commit = new PropertyValue<GitCommitInfo>(nameof(IssueLinkedToCommit), nameof(Commit), "commit");
    
    [Required]
    [JsonPropertyName("commit")]
    public GitCommitInfo Commit
    {
        get => _commit.GetValue(InlineErrors);
        set => _commit.SetValue(value);
    }

    private PropertyValue<GitCommitChanges?> _commitChanges = new PropertyValue<GitCommitChanges?>(nameof(IssueLinkedToCommit), nameof(CommitChanges), "commitChanges");
    
    [JsonPropertyName("commitChanges")]
    public GitCommitChanges? CommitChanges
    {
        get => _commitChanges.GetValue(InlineErrors);
        set => _commitChanges.SetValue(value);
    }

    private PropertyValue<string> _commitUrl = new PropertyValue<string>(nameof(IssueLinkedToCommit), nameof(CommitUrl), "commitUrl");
    
    [Required]
    [JsonPropertyName("commitUrl")]
    public string CommitUrl
    {
        get => _commitUrl.GetValue(InlineErrors);
        set => _commitUrl.SetValue(value);
    }

    private PropertyValue<string> _issuePrefix = new PropertyValue<string>(nameof(IssueLinkedToCommit), nameof(IssuePrefix), "issuePrefix");
    
    [Required]
    [JsonPropertyName("issuePrefix")]
    public string IssuePrefix
    {
        get => _issuePrefix.GetValue(InlineErrors);
        set => _issuePrefix.SetValue(value);
    }

    private PropertyValue<string> _issueId = new PropertyValue<string>(nameof(IssueLinkedToCommit), nameof(IssueId), "issueId");
    
    [Required]
    [JsonPropertyName("issueId")]
    public string IssueId
    {
        get => _issueId.GetValue(InlineErrors);
        set => _issueId.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositoryId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositoryName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commit.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitChanges.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitUrl.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issuePrefix.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueId.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

