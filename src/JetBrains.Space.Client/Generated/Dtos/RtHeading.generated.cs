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

public sealed class RtHeading
     : RtBlockNodeWithChildren, RtFirstListItemContentNode, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "RtHeading";
    
    public RtHeading() { }
    
    public RtHeading(int level, List<RtHeadingContentNode> children, RtTextAlign? textAlign = null)
    {
        Level = level;
        Children = children;
        TextAlign = textAlign;
    }
    
    private PropertyValue<int> _level = new PropertyValue<int>(nameof(RtHeading), nameof(Level), "level");
    
    [Required]
    [JsonPropertyName("level")]
    public int Level
    {
        get => _level.GetValue(InlineErrors);
        set => _level.SetValue(value);
    }

    private PropertyValue<List<RtHeadingContentNode>> _children = new PropertyValue<List<RtHeadingContentNode>>(nameof(RtHeading), nameof(Children), "children", new List<RtHeadingContentNode>());
    
    [Required]
    [JsonPropertyName("children")]
    public List<RtHeadingContentNode> Children
    {
        get => _children.GetValue(InlineErrors);
        set => _children.SetValue(value);
    }

    private PropertyValue<RtTextAlign?> _textAlign = new PropertyValue<RtTextAlign?>(nameof(RtHeading), nameof(TextAlign), "textAlign");
    
    [Obsolete("RtTextAlign is deprecated, alignments are no longer supported (since 2023-10-17) (will be removed in a future version)")]
    [JsonPropertyName("textAlign")]
    public RtTextAlign? TextAlign
    {
        get => _textAlign.GetValue(InlineErrors);
        set => _textAlign.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _level.SetAccessPath(parentChainPath, validateHasBeenSet);
        _children.SetAccessPath(parentChainPath, validateHasBeenSet);
        _textAlign.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

