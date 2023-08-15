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

internal class ProjectsForProjectRepositoriesForRepositoryCommitPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectRepositoriesForRepositoryCommitPostRequest() { }
    
    public ProjectsForProjectRepositoriesForRepositoryCommitPostRequest(string baseCommit, string targetBranch, string commitMessage, List<GitCommitFileRequest> files)
    {
        BaseCommit = baseCommit;
        TargetBranch = targetBranch;
        CommitMessage = commitMessage;
        Files = files;
    }
    
    private PropertyValue<string> _baseCommit = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryCommitPostRequest), nameof(BaseCommit), "baseCommit");
    
    [Required]
    [JsonPropertyName("baseCommit")]
    public string BaseCommit
    {
        get => _baseCommit.GetValue(InlineErrors);
        set => _baseCommit.SetValue(value);
    }

    private PropertyValue<string> _targetBranch = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryCommitPostRequest), nameof(TargetBranch), "targetBranch");
    
    [Required]
    [JsonPropertyName("targetBranch")]
    public string TargetBranch
    {
        get => _targetBranch.GetValue(InlineErrors);
        set => _targetBranch.SetValue(value);
    }

    private PropertyValue<string> _commitMessage = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryCommitPostRequest), nameof(CommitMessage), "commitMessage");
    
    [Required]
    [JsonPropertyName("commitMessage")]
    public string CommitMessage
    {
        get => _commitMessage.GetValue(InlineErrors);
        set => _commitMessage.SetValue(value);
    }

    private PropertyValue<List<GitCommitFileRequest>> _files = new PropertyValue<List<GitCommitFileRequest>>(nameof(ProjectsForProjectRepositoriesForRepositoryCommitPostRequest), nameof(Files), "files", new List<GitCommitFileRequest>());
    
    [Required]
    [JsonPropertyName("files")]
    public List<GitCommitFileRequest> Files
    {
        get => _files.GetValue(InlineErrors);
        set => _files.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _baseCommit.SetAccessPath(parentChainPath, validateHasBeenSet);
        _targetBranch.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitMessage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _files.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

