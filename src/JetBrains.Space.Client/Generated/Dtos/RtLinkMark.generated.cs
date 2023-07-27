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

public sealed class RtLinkMark
     : RtDocumentMark, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "RtLinkMark";
    
    public RtLinkMark() { }
    
    public RtLinkMark(string href, string? title = null, string? mention = null, RtLinkDetails? details = null, RtLinkAttrs? attrs = null)
    {
        Href = href;
        Title = title;
        Mention = mention;
        Details = details;
        Attrs = attrs;
    }
    
    private PropertyValue<string> _href = new PropertyValue<string>(nameof(RtLinkMark), nameof(Href), "href");
    
    [Required]
    [JsonPropertyName("href")]
    public string Href
    {
        get => _href.GetValue(InlineErrors);
        set => _href.SetValue(value);
    }

    private PropertyValue<string?> _title = new PropertyValue<string?>(nameof(RtLinkMark), nameof(Title), "title");
    
    [JsonPropertyName("title")]
    public string? Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<string?> _mention = new PropertyValue<string?>(nameof(RtLinkMark), nameof(Mention), "mention");
    
    [JsonPropertyName("mention")]
    public string? Mention
    {
        get => _mention.GetValue(InlineErrors);
        set => _mention.SetValue(value);
    }

    private PropertyValue<RtLinkDetails?> _details = new PropertyValue<RtLinkDetails?>(nameof(RtLinkMark), nameof(Details), "details");
    
    [JsonPropertyName("details")]
    public RtLinkDetails? Details
    {
        get => _details.GetValue(InlineErrors);
        set => _details.SetValue(value);
    }

    private PropertyValue<RtLinkAttrs?> _attrs = new PropertyValue<RtLinkAttrs?>(nameof(RtLinkMark), nameof(Attrs), "attrs");
    
    [Obsolete("Use RtLinkMark fields instead (since 2023-03-28) (will be removed in a future version)")]
    [JsonPropertyName("attrs")]
    public RtLinkAttrs? Attrs
    {
        get => _attrs.GetValue(InlineErrors);
        set => _attrs.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _href.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mention.SetAccessPath(parentChainPath, validateHasBeenSet);
        _details.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attrs.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

