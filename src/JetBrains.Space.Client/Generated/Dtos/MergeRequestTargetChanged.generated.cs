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

public sealed class MergeRequestTargetChanged
     : CompactFeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MergeRequestTargetChanged";
    
    public MergeRequestTargetChanged() { }
    
    public MergeRequestTargetChanged(string prevBranch, string nextBranch)
    {
        PrevBranch = prevBranch;
        NextBranch = nextBranch;
    }
    
    private PropertyValue<string> _prevBranch = new PropertyValue<string>(nameof(MergeRequestTargetChanged), nameof(PrevBranch), "prevBranch");
    
    [Required]
    [JsonPropertyName("prevBranch")]
    public string PrevBranch
    {
        get => _prevBranch.GetValue(InlineErrors);
        set => _prevBranch.SetValue(value);
    }

    private PropertyValue<string> _nextBranch = new PropertyValue<string>(nameof(MergeRequestTargetChanged), nameof(NextBranch), "nextBranch");
    
    [Required]
    [JsonPropertyName("nextBranch")]
    public string NextBranch
    {
        get => _nextBranch.GetValue(InlineErrors);
        set => _nextBranch.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _prevBranch.SetAccessPath(parentChainPath, validateHasBeenSet);
        _nextBranch.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
