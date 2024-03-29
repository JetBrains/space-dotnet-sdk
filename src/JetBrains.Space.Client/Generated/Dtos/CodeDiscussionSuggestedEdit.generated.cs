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

public sealed class CodeDiscussionSuggestedEdit
     : IPropagatePropertyAccessPath
{
    public CodeDiscussionSuggestedEdit() { }
    
    public CodeDiscussionSuggestedEdit(string suggestionCommitId, string filePath, bool hasConflicts, int startLineIndex, int endLineIndexInclusive, CodeDiscussionSuggestedEditState? status = null, CPrincipal? resolvedBy = null, bool? identicalContents = null)
    {
        SuggestionCommitId = suggestionCommitId;
        Status = status;
        ResolvedBy = resolvedBy;
        FilePath = filePath;
        IsHasConflicts = hasConflicts;
        IsIdenticalContents = identicalContents;
        StartLineIndex = startLineIndex;
        EndLineIndexInclusive = endLineIndexInclusive;
    }
    
    private PropertyValue<string> _suggestionCommitId = new PropertyValue<string>(nameof(CodeDiscussionSuggestedEdit), nameof(SuggestionCommitId), "suggestionCommitId");
    
    [Required]
    [JsonPropertyName("suggestionCommitId")]
    public string SuggestionCommitId
    {
        get => _suggestionCommitId.GetValue(InlineErrors);
        set => _suggestionCommitId.SetValue(value);
    }

    private PropertyValue<CodeDiscussionSuggestedEditState?> _status = new PropertyValue<CodeDiscussionSuggestedEditState?>(nameof(CodeDiscussionSuggestedEdit), nameof(Status), "status");
    
    [JsonPropertyName("status")]
    public CodeDiscussionSuggestedEditState? Status
    {
        get => _status.GetValue(InlineErrors);
        set => _status.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _resolvedBy = new PropertyValue<CPrincipal?>(nameof(CodeDiscussionSuggestedEdit), nameof(ResolvedBy), "resolvedBy");
    
    [JsonPropertyName("resolvedBy")]
    public CPrincipal? ResolvedBy
    {
        get => _resolvedBy.GetValue(InlineErrors);
        set => _resolvedBy.SetValue(value);
    }

    private PropertyValue<string> _filePath = new PropertyValue<string>(nameof(CodeDiscussionSuggestedEdit), nameof(FilePath), "filePath");
    
    [Required]
    [JsonPropertyName("filePath")]
    public string FilePath
    {
        get => _filePath.GetValue(InlineErrors);
        set => _filePath.SetValue(value);
    }

    private PropertyValue<bool> _hasConflicts = new PropertyValue<bool>(nameof(CodeDiscussionSuggestedEdit), nameof(IsHasConflicts), "hasConflicts");
    
    [Required]
    [JsonPropertyName("hasConflicts")]
    public bool IsHasConflicts
    {
        get => _hasConflicts.GetValue(InlineErrors);
        set => _hasConflicts.SetValue(value);
    }

    private PropertyValue<bool?> _identicalContents = new PropertyValue<bool?>(nameof(CodeDiscussionSuggestedEdit), nameof(IsIdenticalContents), "identicalContents");
    
    [JsonPropertyName("identicalContents")]
    public bool? IsIdenticalContents
    {
        get => _identicalContents.GetValue(InlineErrors);
        set => _identicalContents.SetValue(value);
    }

    private PropertyValue<int> _startLineIndex = new PropertyValue<int>(nameof(CodeDiscussionSuggestedEdit), nameof(StartLineIndex), "startLineIndex");
    
    [Required]
    [JsonPropertyName("startLineIndex")]
    public int StartLineIndex
    {
        get => _startLineIndex.GetValue(InlineErrors);
        set => _startLineIndex.SetValue(value);
    }

    private PropertyValue<int> _endLineIndexInclusive = new PropertyValue<int>(nameof(CodeDiscussionSuggestedEdit), nameof(EndLineIndexInclusive), "endLineIndexInclusive");
    
    [Required]
    [JsonPropertyName("endLineIndexInclusive")]
    public int EndLineIndexInclusive
    {
        get => _endLineIndexInclusive.GetValue(InlineErrors);
        set => _endLineIndexInclusive.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _suggestionCommitId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _status.SetAccessPath(parentChainPath, validateHasBeenSet);
        _resolvedBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _filePath.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hasConflicts.SetAccessPath(parentChainPath, validateHasBeenSet);
        _identicalContents.SetAccessPath(parentChainPath, validateHasBeenSet);
        _startLineIndex.SetAccessPath(parentChainPath, validateHasBeenSet);
        _endLineIndexInclusive.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

