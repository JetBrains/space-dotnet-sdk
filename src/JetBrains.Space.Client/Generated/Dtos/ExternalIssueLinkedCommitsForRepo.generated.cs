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

public sealed class ExternalIssueLinkedCommitsForRepo
     : IPropagatePropertyAccessPath
{
    public ExternalIssueLinkedCommitsForRepo() { }
    
    public ExternalIssueLinkedCommitsForRepo(PRProject project, string repositoryId, List<ExternalIssueLinkedCommit> commits, string? repositoryName = null)
    {
        Project = project;
        RepositoryId = repositoryId;
        RepositoryName = repositoryName;
        Commits = commits;
    }
    
    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(ExternalIssueLinkedCommitsForRepo), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _repositoryId = new PropertyValue<string>(nameof(ExternalIssueLinkedCommitsForRepo), nameof(RepositoryId), "repositoryId");
    
    [Required]
    [JsonPropertyName("repositoryId")]
    public string RepositoryId
    {
        get => _repositoryId.GetValue(InlineErrors);
        set => _repositoryId.SetValue(value);
    }

    private PropertyValue<string?> _repositoryName = new PropertyValue<string?>(nameof(ExternalIssueLinkedCommitsForRepo), nameof(RepositoryName), "repositoryName");
    
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName
    {
        get => _repositoryName.GetValue(InlineErrors);
        set => _repositoryName.SetValue(value);
    }

    private PropertyValue<List<ExternalIssueLinkedCommit>> _commits = new PropertyValue<List<ExternalIssueLinkedCommit>>(nameof(ExternalIssueLinkedCommitsForRepo), nameof(Commits), "commits", new List<ExternalIssueLinkedCommit>());
    
    [Required]
    [JsonPropertyName("commits")]
    public List<ExternalIssueLinkedCommit> Commits
    {
        get => _commits.GetValue(InlineErrors);
        set => _commits.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositoryId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositoryName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commits.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

