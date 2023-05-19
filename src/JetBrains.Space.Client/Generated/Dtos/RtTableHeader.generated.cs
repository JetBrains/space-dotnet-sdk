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

public sealed class RtTableHeader
     : RtTableRowContent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "RtTableHeader";
    
    public RtTableHeader() { }
    
    public RtTableHeader(List<RtBlockNode> children, int rowspan, int colspan, List<int>? colwidth = null, RtTableCellAttrs? attrs = null)
    {
        Children = children;
        Rowspan = rowspan;
        Colspan = colspan;
        Colwidth = colwidth;
        Attrs = attrs;
    }
    
    private PropertyValue<List<RtBlockNode>> _children = new PropertyValue<List<RtBlockNode>>(nameof(RtTableHeader), nameof(Children), "children", new List<RtBlockNode>());
    
    [Required]
    [JsonPropertyName("children")]
    public List<RtBlockNode> Children
    {
        get => _children.GetValue(InlineErrors);
        set => _children.SetValue(value);
    }

    private PropertyValue<int> _rowspan = new PropertyValue<int>(nameof(RtTableHeader), nameof(Rowspan), "rowspan");
    
    [Required]
    [JsonPropertyName("rowspan")]
    public int Rowspan
    {
        get => _rowspan.GetValue(InlineErrors);
        set => _rowspan.SetValue(value);
    }

    private PropertyValue<int> _colspan = new PropertyValue<int>(nameof(RtTableHeader), nameof(Colspan), "colspan");
    
    [Required]
    [JsonPropertyName("colspan")]
    public int Colspan
    {
        get => _colspan.GetValue(InlineErrors);
        set => _colspan.SetValue(value);
    }

    private PropertyValue<List<int>?> _colwidth = new PropertyValue<List<int>?>(nameof(RtTableHeader), nameof(Colwidth), "colwidth");
    
    [JsonPropertyName("colwidth")]
    public List<int>? Colwidth
    {
        get => _colwidth.GetValue(InlineErrors);
        set => _colwidth.SetValue(value);
    }

    private PropertyValue<RtTableCellAttrs?> _attrs = new PropertyValue<RtTableCellAttrs?>(nameof(RtTableHeader), nameof(Attrs), "attrs");
    
    [JsonPropertyName("attrs")]
    public RtTableCellAttrs? Attrs
    {
        get => _attrs.GetValue(InlineErrors);
        set => _attrs.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _children.SetAccessPath(parentChainPath, validateHasBeenSet);
        _rowspan.SetAccessPath(parentChainPath, validateHasBeenSet);
        _colspan.SetAccessPath(parentChainPath, validateHasBeenSet);
        _colwidth.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attrs.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

