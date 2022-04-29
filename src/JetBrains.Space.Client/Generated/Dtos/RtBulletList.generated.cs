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

public sealed class RtBulletList
     : BlockNode, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "RtBulletList";
    
    public RtBulletList() { }
    
    public RtBulletList(List<RtListItem> children, List<DocumentMark> marks)
    {
        Children = children;
        Marks = marks;
    }
    
    private PropertyValue<List<RtListItem>> _children = new PropertyValue<List<RtListItem>>(nameof(RtBulletList), nameof(Children), "children", new List<RtListItem>());
    
    [Required]
    [JsonPropertyName("children")]
    public List<RtListItem> Children
    {
        get => _children.GetValue(InlineErrors);
        set => _children.SetValue(value);
    }

    private PropertyValue<List<DocumentMark>> _marks = new PropertyValue<List<DocumentMark>>(nameof(RtBulletList), nameof(Marks), "marks", new List<DocumentMark>());
    
    [Required]
    [JsonPropertyName("marks")]
    public List<DocumentMark> Marks
    {
        get => _marks.GetValue(InlineErrors);
        set => _marks.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _children.SetAccessPath(parentChainPath, validateHasBeenSet);
        _marks.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

