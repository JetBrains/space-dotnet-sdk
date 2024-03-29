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

internal class ProjectsForProjectCodeReviewsCodeDiscussionsForDiscussionIdSuggestedEditPatchRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectCodeReviewsCodeDiscussionsForDiscussionIdSuggestedEditPatchRequest() { }
    
    public ProjectsForProjectCodeReviewsCodeDiscussionsForDiscussionIdSuggestedEditPatchRequest(string text, List<AttachmentIn> attachments, string? snippetContent = null)
    {
        Text = text;
        Attachments = attachments;
        SnippetContent = snippetContent;
    }
    
    private PropertyValue<string> _text = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsForDiscussionIdSuggestedEditPatchRequest), nameof(Text), "text");
    
    [Required]
    [JsonPropertyName("text")]
    public string Text
    {
        get => _text.GetValue(InlineErrors);
        set => _text.SetValue(value);
    }

    private PropertyValue<List<AttachmentIn>> _attachments = new PropertyValue<List<AttachmentIn>>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsForDiscussionIdSuggestedEditPatchRequest), nameof(Attachments), "attachments", new List<AttachmentIn>());
    
    [Required]
    [JsonPropertyName("attachments")]
    public List<AttachmentIn> Attachments
    {
        get => _attachments.GetValue(InlineErrors);
        set => _attachments.SetValue(value);
    }

    private PropertyValue<string?> _snippetContent = new PropertyValue<string?>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsForDiscussionIdSuggestedEditPatchRequest), nameof(SnippetContent), "snippetContent");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("snippetContent")]
    public string? SnippetContent
    {
        get => _snippetContent.GetValue(InlineErrors);
        set => _snippetContent.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _text.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _snippetContent.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

