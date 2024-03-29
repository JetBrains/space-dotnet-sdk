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

public sealed class EnvVar
     : IPropagatePropertyAccessPath
{
    public EnvVar() { }
    
    public EnvVar(EnvVarType type, string key, string value)
    {
        Type = type;
        Key = key;
        Value = value;
    }
    
    private PropertyValue<EnvVarType> _type = new PropertyValue<EnvVarType>(nameof(EnvVar), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public EnvVarType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<string> _key = new PropertyValue<string>(nameof(EnvVar), nameof(Key), "key");
    
    [Required]
    [JsonPropertyName("key")]
    public string Key
    {
        get => _key.GetValue(InlineErrors);
        set => _key.SetValue(value);
    }

    private PropertyValue<string> _value = new PropertyValue<string>(nameof(EnvVar), nameof(Value), "value");
    
    [Required]
    [JsonPropertyName("value")]
    public string Value
    {
        get => _value.GetValue(InlineErrors);
        set => _value.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _key.SetAccessPath(parentChainPath, validateHasBeenSet);
        _value.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

