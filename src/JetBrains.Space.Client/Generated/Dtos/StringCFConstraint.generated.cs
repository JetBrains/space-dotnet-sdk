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

public sealed class StringCFConstraint
     : CFConstraint, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "StringCFConstraint";
    
    public StringCFConstraint() { }
    
    public StringCFConstraint(int? min = null, int? max = null, string? pattern = null, string? message = null)
    {
        Min = min;
        Max = max;
        Pattern = pattern;
        Message = message;
    }
    
    private PropertyValue<int?> _min = new PropertyValue<int?>(nameof(StringCFConstraint), nameof(Min), "min");
    
    [JsonPropertyName("min")]
    public int? Min
    {
        get => _min.GetValue(InlineErrors);
        set => _min.SetValue(value);
    }

    private PropertyValue<int?> _max = new PropertyValue<int?>(nameof(StringCFConstraint), nameof(Max), "max");
    
    [JsonPropertyName("max")]
    public int? Max
    {
        get => _max.GetValue(InlineErrors);
        set => _max.SetValue(value);
    }

    private PropertyValue<string?> _pattern = new PropertyValue<string?>(nameof(StringCFConstraint), nameof(Pattern), "pattern");
    
    [JsonPropertyName("pattern")]
    public string? Pattern
    {
        get => _pattern.GetValue(InlineErrors);
        set => _pattern.SetValue(value);
    }

    private PropertyValue<string?> _message = new PropertyValue<string?>(nameof(StringCFConstraint), nameof(Message), "message");
    
    [JsonPropertyName("message")]
    public string? Message
    {
        get => _message.GetValue(InlineErrors);
        set => _message.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _min.SetAccessPath(parentChainPath, validateHasBeenSet);
        _max.SetAccessPath(parentChainPath, validateHasBeenSet);
        _pattern.SetAccessPath(parentChainPath, validateHasBeenSet);
        _message.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

