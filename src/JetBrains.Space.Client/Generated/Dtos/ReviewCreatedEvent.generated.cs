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

public sealed class ReviewCreatedEvent
     : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ReviewCreatedEvent";
    
    public ReviewCreatedEvent() { }
    
    public ReviewCreatedEvent(string projectKey, string reviewId, int reviewNumber, ReviewType reviewType, List<TDMemberProfile> descriptionEditedByProfileIds, CodeReviewDescription? description = null, List<UnfurlDetailsCommit>? commits = null, bool? compact = null)
    {
        ProjectKey = projectKey;
        ReviewId = reviewId;
        ReviewNumber = reviewNumber;
        ReviewType = reviewType;
        Description = description;
        DescriptionEditedByProfileIds = descriptionEditedByProfileIds;
        Commits = commits;
        IsCompact = compact;
    }
    
    private PropertyValue<string> _projectKey = new PropertyValue<string>(nameof(ReviewCreatedEvent), nameof(ProjectKey), "projectKey");
    
    [Required]
    [JsonPropertyName("projectKey")]
    public string ProjectKey
    {
        get => _projectKey.GetValue(InlineErrors);
        set => _projectKey.SetValue(value);
    }

    private PropertyValue<string> _reviewId = new PropertyValue<string>(nameof(ReviewCreatedEvent), nameof(ReviewId), "reviewId");
    
    [Required]
    [JsonPropertyName("reviewId")]
    public string ReviewId
    {
        get => _reviewId.GetValue(InlineErrors);
        set => _reviewId.SetValue(value);
    }

    private PropertyValue<int> _reviewNumber = new PropertyValue<int>(nameof(ReviewCreatedEvent), nameof(ReviewNumber), "reviewNumber");
    
    [Required]
    [JsonPropertyName("reviewNumber")]
    public int ReviewNumber
    {
        get => _reviewNumber.GetValue(InlineErrors);
        set => _reviewNumber.SetValue(value);
    }

    private PropertyValue<ReviewType> _reviewType = new PropertyValue<ReviewType>(nameof(ReviewCreatedEvent), nameof(ReviewType), "reviewType");
    
    [Required]
    [JsonPropertyName("reviewType")]
    public ReviewType ReviewType
    {
        get => _reviewType.GetValue(InlineErrors);
        set => _reviewType.SetValue(value);
    }

    private PropertyValue<CodeReviewDescription?> _description = new PropertyValue<CodeReviewDescription?>(nameof(ReviewCreatedEvent), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public CodeReviewDescription? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>> _descriptionEditedByProfileIds = new PropertyValue<List<TDMemberProfile>>(nameof(ReviewCreatedEvent), nameof(DescriptionEditedByProfileIds), "descriptionEditedByProfileIds", new List<TDMemberProfile>());
    
    [Required]
    [JsonPropertyName("descriptionEditedByProfileIds")]
    public List<TDMemberProfile> DescriptionEditedByProfileIds
    {
        get => _descriptionEditedByProfileIds.GetValue(InlineErrors);
        set => _descriptionEditedByProfileIds.SetValue(value);
    }

    private PropertyValue<List<UnfurlDetailsCommit>?> _commits = new PropertyValue<List<UnfurlDetailsCommit>?>(nameof(ReviewCreatedEvent), nameof(Commits), "commits");
    
    [JsonPropertyName("commits")]
    public List<UnfurlDetailsCommit>? Commits
    {
        get => _commits.GetValue(InlineErrors);
        set => _commits.SetValue(value);
    }

    private PropertyValue<bool?> _compact = new PropertyValue<bool?>(nameof(ReviewCreatedEvent), nameof(IsCompact), "compact");
    
    [JsonPropertyName("compact")]
    public bool? IsCompact
    {
        get => _compact.GetValue(InlineErrors);
        set => _compact.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _projectKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviewId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviewNumber.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviewType.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _descriptionEditedByProfileIds.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commits.SetAccessPath(parentChainPath, validateHasBeenSet);
        _compact.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

