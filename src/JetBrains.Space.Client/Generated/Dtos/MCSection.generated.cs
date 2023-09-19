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

public sealed class MCSection
     : MCDetailsWithElements, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MCSection";
    
    public MCSection() { }
    
    public MCSection(List<MCElement> elements, MessageStyle? style = null, MCText? header = null, MCText? footer = null)
    {
        Elements = elements;
        Style = style;
        Header = header;
        Footer = footer;
    }
    
    private PropertyValue<List<MCElement>> _elements = new PropertyValue<List<MCElement>>(nameof(MCSection), nameof(Elements), "elements", new List<MCElement>());
    
    [Required]
    [JsonPropertyName("elements")]
    public List<MCElement> Elements
    {
        get => _elements.GetValue(InlineErrors);
        set => _elements.SetValue(value);
    }

    private PropertyValue<MessageStyle?> _style = new PropertyValue<MessageStyle?>(nameof(MCSection), nameof(Style), "style");
    
    [JsonPropertyName("style")]
    public MessageStyle? Style
    {
        get => _style.GetValue(InlineErrors);
        set => _style.SetValue(value);
    }

    private PropertyValue<MCText?> _header = new PropertyValue<MCText?>(nameof(MCSection), nameof(Header), "header");
    
    [JsonPropertyName("header")]
    public MCText? Header
    {
        get => _header.GetValue(InlineErrors);
        set => _header.SetValue(value);
    }

    private PropertyValue<MCText?> _footer = new PropertyValue<MCText?>(nameof(MCSection), nameof(Footer), "footer");
    
    [JsonPropertyName("footer")]
    public MCText? Footer
    {
        get => _footer.GetValue(InlineErrors);
        set => _footer.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _elements.SetAccessPath(parentChainPath, validateHasBeenSet);
        _style.SetAccessPath(parentChainPath, validateHasBeenSet);
        _header.SetAccessPath(parentChainPath, validateHasBeenSet);
        _footer.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

