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

public sealed class ReviewCompletionStateChanged
     : CompactFeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ReviewCompletionStateChanged";
    
    public ReviewCompletionStateChanged() { }
    
    public ReviewCompletionStateChanged(ReviewerState state, bool isAccepted, bool isAcceptedBefore, bool isApproveSticky, bool reviewOnlyOwnedFiles)
    {
        State = state;
        IsAccepted = isAccepted;
        IsAcceptedBefore = isAcceptedBefore;
        IsApproveSticky = isApproveSticky;
        IsReviewOnlyOwnedFiles = reviewOnlyOwnedFiles;
    }
    
    private PropertyValue<ReviewerState> _state = new PropertyValue<ReviewerState>(nameof(ReviewCompletionStateChanged), nameof(State), "state");
    
    [Required]
    [JsonPropertyName("state")]
    public ReviewerState State
    {
        get => _state.GetValue(InlineErrors);
        set => _state.SetValue(value);
    }

    private PropertyValue<bool> _isAccepted = new PropertyValue<bool>(nameof(ReviewCompletionStateChanged), nameof(IsAccepted), "isAccepted");
    
    [Required]
    [JsonPropertyName("isAccepted")]
    public bool IsAccepted
    {
        get => _isAccepted.GetValue(InlineErrors);
        set => _isAccepted.SetValue(value);
    }

    private PropertyValue<bool> _isAcceptedBefore = new PropertyValue<bool>(nameof(ReviewCompletionStateChanged), nameof(IsAcceptedBefore), "isAcceptedBefore");
    
    [Required]
    [JsonPropertyName("isAcceptedBefore")]
    public bool IsAcceptedBefore
    {
        get => _isAcceptedBefore.GetValue(InlineErrors);
        set => _isAcceptedBefore.SetValue(value);
    }

    private PropertyValue<bool> _isApproveSticky = new PropertyValue<bool>(nameof(ReviewCompletionStateChanged), nameof(IsApproveSticky), "isApproveSticky");
    
    [Required]
    [JsonPropertyName("isApproveSticky")]
    public bool IsApproveSticky
    {
        get => _isApproveSticky.GetValue(InlineErrors);
        set => _isApproveSticky.SetValue(value);
    }

    private PropertyValue<bool> _reviewOnlyOwnedFiles = new PropertyValue<bool>(nameof(ReviewCompletionStateChanged), nameof(IsReviewOnlyOwnedFiles), "reviewOnlyOwnedFiles");
    
    [Required]
    [JsonPropertyName("reviewOnlyOwnedFiles")]
    public bool IsReviewOnlyOwnedFiles
    {
        get => _reviewOnlyOwnedFiles.GetValue(InlineErrors);
        set => _reviewOnlyOwnedFiles.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _state.SetAccessPath(parentChainPath, validateHasBeenSet);
        _isAccepted.SetAccessPath(parentChainPath, validateHasBeenSet);
        _isAcceptedBefore.SetAccessPath(parentChainPath, validateHasBeenSet);
        _isApproveSticky.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviewOnlyOwnedFiles.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
