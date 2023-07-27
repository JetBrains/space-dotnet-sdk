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

public sealed class RtUnfurl
     : RtHeadingContentNode, RtInlineNodeWithMarks, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "RtUnfurl";
    
    public RtUnfurl() { }
    
    public RtUnfurl(string href, string title, List<RtDocumentMark> marks, RtUnfurlAttrs? attrs = null)
    {
        Href = href;
        Title = title;
        Marks = marks;
        Attrs = attrs;
    }
    
    private PropertyValue<string> _href = new PropertyValue<string>(nameof(RtUnfurl), nameof(Href), "href");
    
    [Required]
    [JsonPropertyName("href")]
    public string Href
    {
        get => _href.GetValue(InlineErrors);
        set => _href.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(RtUnfurl), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<List<RtDocumentMark>> _marks = new PropertyValue<List<RtDocumentMark>>(nameof(RtUnfurl), nameof(Marks), "marks", new List<RtDocumentMark>());
    
    [Required]
    [JsonPropertyName("marks")]
    public List<RtDocumentMark> Marks
    {
        get => _marks.GetValue(InlineErrors);
        set => _marks.SetValue(value);
    }

    private PropertyValue<RtUnfurlAttrs?> _attrs = new PropertyValue<RtUnfurlAttrs?>(nameof(RtUnfurl), nameof(Attrs), "attrs");
    
    [Obsolete("Use RtUnfurl fields instead (since 2023-03-28) (will be removed in a future version)")]
    [JsonPropertyName("attrs")]
    public RtUnfurlAttrs? Attrs
    {
        get => _attrs.GetValue(InlineErrors);
        set => _attrs.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _href.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _marks.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attrs.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

