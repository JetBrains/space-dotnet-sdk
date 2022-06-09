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

public sealed class UnfurlDetailsTextDiff
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsTextDiff";
    
    public UnfurlDetailsTextDiff() { }
    
    public UnfurlDetailsTextDiff(string textBefore, string textAfter)
    {
        TextBefore = textBefore;
        TextAfter = textAfter;
    }
    
    private PropertyValue<string> _textBefore = new PropertyValue<string>(nameof(UnfurlDetailsTextDiff), nameof(TextBefore), "textBefore");
    
    [Required]
    [JsonPropertyName("textBefore")]
    public string TextBefore
    {
        get => _textBefore.GetValue(InlineErrors);
        set => _textBefore.SetValue(value);
    }

    private PropertyValue<string> _textAfter = new PropertyValue<string>(nameof(UnfurlDetailsTextDiff), nameof(TextAfter), "textAfter");
    
    [Required]
    [JsonPropertyName("textAfter")]
    public string TextAfter
    {
        get => _textAfter.GetValue(InlineErrors);
        set => _textAfter.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _textBefore.SetAccessPath(parentChainPath, validateHasBeenSet);
        _textAfter.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

