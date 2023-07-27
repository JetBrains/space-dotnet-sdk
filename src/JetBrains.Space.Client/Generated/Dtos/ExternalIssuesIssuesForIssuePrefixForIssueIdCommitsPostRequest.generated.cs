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

public class ExternalIssuesIssuesForIssuePrefixForIssueIdCommitsPostRequest
     : IPropagatePropertyAccessPath
{
    public ExternalIssuesIssuesForIssuePrefixForIssueIdCommitsPostRequest() { }
    
    public ExternalIssuesIssuesForIssuePrefixForIssueIdCommitsPostRequest(ProjectIdentifier project, string repository, List<string> commitIds)
    {
        Project = project;
        Repository = repository;
        CommitIds = commitIds;
    }
    
    private PropertyValue<ProjectIdentifier> _project = new PropertyValue<ProjectIdentifier>(nameof(ExternalIssuesIssuesForIssuePrefixForIssueIdCommitsPostRequest), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public ProjectIdentifier Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ExternalIssuesIssuesForIssuePrefixForIssueIdCommitsPostRequest), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<List<string>> _commitIds = new PropertyValue<List<string>>(nameof(ExternalIssuesIssuesForIssuePrefixForIssueIdCommitsPostRequest), nameof(CommitIds), "commitIds", new List<string>());
    
    [Required]
    [JsonPropertyName("commitIds")]
    public List<string> CommitIds
    {
        get => _commitIds.GetValue(InlineErrors);
        set => _commitIds.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitIds.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

