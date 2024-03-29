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

public sealed class AdditionalRepositoryInfo
     : IPropagatePropertyAccessPath
{
    public AdditionalRepositoryInfo() { }
    
    public AdditionalRepositoryInfo(string repoName, List<PRProject> projectsRepoAttachedTo, RepoStats? stats = null)
    {
        RepoName = repoName;
        Stats = stats;
        ProjectsRepoAttachedTo = projectsRepoAttachedTo;
    }
    
    private PropertyValue<string> _repoName = new PropertyValue<string>(nameof(AdditionalRepositoryInfo), nameof(RepoName), "repoName");
    
    [Required]
    [JsonPropertyName("repoName")]
    public string RepoName
    {
        get => _repoName.GetValue(InlineErrors);
        set => _repoName.SetValue(value);
    }

    private PropertyValue<RepoStats?> _stats = new PropertyValue<RepoStats?>(nameof(AdditionalRepositoryInfo), nameof(Stats), "stats");
    
    [JsonPropertyName("stats")]
    public RepoStats? Stats
    {
        get => _stats.GetValue(InlineErrors);
        set => _stats.SetValue(value);
    }

    private PropertyValue<List<PRProject>> _projectsRepoAttachedTo = new PropertyValue<List<PRProject>>(nameof(AdditionalRepositoryInfo), nameof(ProjectsRepoAttachedTo), "projectsRepoAttachedTo", new List<PRProject>());
    
    [Required]
    [JsonPropertyName("projectsRepoAttachedTo")]
    public List<PRProject> ProjectsRepoAttachedTo
    {
        get => _projectsRepoAttachedTo.GetValue(InlineErrors);
        set => _projectsRepoAttachedTo.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _repoName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _stats.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectsRepoAttachedTo.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

