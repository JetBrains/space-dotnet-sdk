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

[Obsolete("Use RtImage fields instead (since 2023-03-28) (will be removed in a future version)")]
public sealed class RtImageAttrs
     : IPropagatePropertyAccessPath
{
    public RtImageAttrs() { }
    
    public RtImageAttrs(string src, string? title = null, string? alt = null)
    {
        Src = src;
        Title = title;
        Alt = alt;
    }
    
    private PropertyValue<string> _src = new PropertyValue<string>(nameof(RtImageAttrs), nameof(Src), "src");
    
    [Required]
    [JsonPropertyName("src")]
    public string Src
    {
        get => _src.GetValue(InlineErrors);
        set => _src.SetValue(value);
    }

    private PropertyValue<string?> _title = new PropertyValue<string?>(nameof(RtImageAttrs), nameof(Title), "title");
    
    [JsonPropertyName("title")]
    public string? Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<string?> _alt = new PropertyValue<string?>(nameof(RtImageAttrs), nameof(Alt), "alt");
    
    [JsonPropertyName("alt")]
    public string? Alt
    {
        get => _alt.GetValue(InlineErrors);
        set => _alt.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _src.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _alt.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

