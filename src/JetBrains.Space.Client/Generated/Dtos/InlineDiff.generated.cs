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

public sealed class InlineDiff
     : IPropagatePropertyAccessPath
{
    public InlineDiff() { }
    
    public InlineDiff(GitFileType type, List<InlineDiffLine> lines, bool hasFilteredFragments, LineEndingDiff? lineEndingDiff = null, BOMDiff? bomDiff = null, List<CodeScopeRange>? scopes = null)
    {
        Type = type;
        Lines = lines;
        IsHasFilteredFragments = hasFilteredFragments;
        LineEndingDiff = lineEndingDiff;
        BomDiff = bomDiff;
        Scopes = scopes;
    }
    
    private PropertyValue<GitFileType> _type = new PropertyValue<GitFileType>(nameof(InlineDiff), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public GitFileType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<List<InlineDiffLine>> _lines = new PropertyValue<List<InlineDiffLine>>(nameof(InlineDiff), nameof(Lines), "lines", new List<InlineDiffLine>());
    
    [Required]
    [JsonPropertyName("lines")]
    public List<InlineDiffLine> Lines
    {
        get => _lines.GetValue(InlineErrors);
        set => _lines.SetValue(value);
    }

    private PropertyValue<bool> _hasFilteredFragments = new PropertyValue<bool>(nameof(InlineDiff), nameof(IsHasFilteredFragments), "hasFilteredFragments");
    
    [Required]
    [JsonPropertyName("hasFilteredFragments")]
    public bool IsHasFilteredFragments
    {
        get => _hasFilteredFragments.GetValue(InlineErrors);
        set => _hasFilteredFragments.SetValue(value);
    }

    private PropertyValue<LineEndingDiff?> _lineEndingDiff = new PropertyValue<LineEndingDiff?>(nameof(InlineDiff), nameof(LineEndingDiff), "lineEndingDiff");
    
    [JsonPropertyName("lineEndingDiff")]
    public LineEndingDiff? LineEndingDiff
    {
        get => _lineEndingDiff.GetValue(InlineErrors);
        set => _lineEndingDiff.SetValue(value);
    }

    private PropertyValue<BOMDiff?> _bomDiff = new PropertyValue<BOMDiff?>(nameof(InlineDiff), nameof(BomDiff), "bomDiff");
    
    [JsonPropertyName("bomDiff")]
    public BOMDiff? BomDiff
    {
        get => _bomDiff.GetValue(InlineErrors);
        set => _bomDiff.SetValue(value);
    }

    private PropertyValue<List<CodeScopeRange>?> _scopes = new PropertyValue<List<CodeScopeRange>?>(nameof(InlineDiff), nameof(Scopes), "scopes");
    
    [JsonPropertyName("scopes")]
    public List<CodeScopeRange>? Scopes
    {
        get => _scopes.GetValue(InlineErrors);
        set => _scopes.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lines.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hasFilteredFragments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lineEndingDiff.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bomDiff.SetAccessPath(parentChainPath, validateHasBeenSet);
        _scopes.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

