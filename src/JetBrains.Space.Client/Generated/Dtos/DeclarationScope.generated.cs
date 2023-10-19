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

public sealed class DeclarationScope
     : IPropagatePropertyAccessPath
{
    public DeclarationScope() { }
    
    public DeclarationScope(int prefix, int startLine, int linesCount, string? declaredIdentifier = null, List<DeclarationScopeReferencedIdentifier>? referencedIdentifiers = null)
    {
        Prefix = prefix;
        StartLine = startLine;
        LinesCount = linesCount;
        DeclaredIdentifier = declaredIdentifier;
        ReferencedIdentifiers = referencedIdentifiers;
    }
    
    private PropertyValue<int> _prefix = new PropertyValue<int>(nameof(DeclarationScope), nameof(Prefix), "prefix");
    
    [Required]
    [JsonPropertyName("prefix")]
    public int Prefix
    {
        get => _prefix.GetValue(InlineErrors);
        set => _prefix.SetValue(value);
    }

    private PropertyValue<int> _startLine = new PropertyValue<int>(nameof(DeclarationScope), nameof(StartLine), "startLine");
    
    [Required]
    [JsonPropertyName("startLine")]
    public int StartLine
    {
        get => _startLine.GetValue(InlineErrors);
        set => _startLine.SetValue(value);
    }

    private PropertyValue<int> _linesCount = new PropertyValue<int>(nameof(DeclarationScope), nameof(LinesCount), "linesCount");
    
    [Required]
    [JsonPropertyName("linesCount")]
    public int LinesCount
    {
        get => _linesCount.GetValue(InlineErrors);
        set => _linesCount.SetValue(value);
    }

    private PropertyValue<string?> _declaredIdentifier = new PropertyValue<string?>(nameof(DeclarationScope), nameof(DeclaredIdentifier), "declaredIdentifier");
    
    [JsonPropertyName("declaredIdentifier")]
    public string? DeclaredIdentifier
    {
        get => _declaredIdentifier.GetValue(InlineErrors);
        set => _declaredIdentifier.SetValue(value);
    }

    private PropertyValue<List<DeclarationScopeReferencedIdentifier>?> _referencedIdentifiers = new PropertyValue<List<DeclarationScopeReferencedIdentifier>?>(nameof(DeclarationScope), nameof(ReferencedIdentifiers), "referencedIdentifiers");
    
    [JsonPropertyName("referencedIdentifiers")]
    public List<DeclarationScopeReferencedIdentifier>? ReferencedIdentifiers
    {
        get => _referencedIdentifiers.GetValue(InlineErrors);
        set => _referencedIdentifiers.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _prefix.SetAccessPath(parentChainPath, validateHasBeenSet);
        _startLine.SetAccessPath(parentChainPath, validateHasBeenSet);
        _linesCount.SetAccessPath(parentChainPath, validateHasBeenSet);
        _declaredIdentifier.SetAccessPath(parentChainPath, validateHasBeenSet);
        _referencedIdentifiers.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

