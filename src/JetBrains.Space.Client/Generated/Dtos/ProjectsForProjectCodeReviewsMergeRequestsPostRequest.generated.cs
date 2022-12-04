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

public class ProjectsForProjectCodeReviewsMergeRequestsPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectCodeReviewsMergeRequestsPostRequest() { }
    
    public ProjectsForProjectCodeReviewsMergeRequestsPostRequest(string repository, string sourceBranch, string targetBranch, string title, string? description = null, List<ReviewerParam>? reviewers = null)
    {
        Repository = repository;
        SourceBranch = sourceBranch;
        TargetBranch = targetBranch;
        Title = title;
        Description = description;
        Reviewers = reviewers;
    }
    
    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsMergeRequestsPostRequest), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _sourceBranch = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsMergeRequestsPostRequest), nameof(SourceBranch), "sourceBranch");
    
    [Required]
    [JsonPropertyName("sourceBranch")]
    public string SourceBranch
    {
        get => _sourceBranch.GetValue(InlineErrors);
        set => _sourceBranch.SetValue(value);
    }

    private PropertyValue<string> _targetBranch = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsMergeRequestsPostRequest), nameof(TargetBranch), "targetBranch");
    
    [Required]
    [JsonPropertyName("targetBranch")]
    public string TargetBranch
    {
        get => _targetBranch.GetValue(InlineErrors);
        set => _targetBranch.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsMergeRequestsPostRequest), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectCodeReviewsMergeRequestsPostRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<List<ReviewerParam>?> _reviewers = new PropertyValue<List<ReviewerParam>?>(nameof(ProjectsForProjectCodeReviewsMergeRequestsPostRequest), nameof(Reviewers), "reviewers");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("reviewers")]
    public List<ReviewerParam>? Reviewers
    {
        get => _reviewers.GetValue(InlineErrors);
        set => _reviewers.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sourceBranch.SetAccessPath(parentChainPath, validateHasBeenSet);
        _targetBranch.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviewers.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

