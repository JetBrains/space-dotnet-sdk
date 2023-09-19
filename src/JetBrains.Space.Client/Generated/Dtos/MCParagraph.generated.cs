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

public sealed class MCParagraph
     : MCDetailsWithElements, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MCParagraph";
    
    public MCParagraph() { }
    
    public MCParagraph(List<MCElement> elements, MCElement? accessory = null)
    {
        Accessory = accessory;
        Elements = elements;
    }
    
    private PropertyValue<MCElement?> _accessory = new PropertyValue<MCElement?>(nameof(MCParagraph), nameof(Accessory), "accessory");
    
    [JsonPropertyName("accessory")]
    public MCElement? Accessory
    {
        get => _accessory.GetValue(InlineErrors);
        set => _accessory.SetValue(value);
    }

    private PropertyValue<List<MCElement>> _elements = new PropertyValue<List<MCElement>>(nameof(MCParagraph), nameof(Elements), "elements", new List<MCElement>());
    
    [Required]
    [JsonPropertyName("elements")]
    public List<MCElement> Elements
    {
        get => _elements.GetValue(InlineErrors);
        set => _elements.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _accessory.SetAccessPath(parentChainPath, validateHasBeenSet);
        _elements.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

