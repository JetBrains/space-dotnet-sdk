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

public sealed class SafeMergeMessage
     : IPropagatePropertyAccessPath
{
    public SafeMergeMessage() { }
    
    public SafeMergeMessage(SafeMergeMessageType type, string message)
    {
        Type = type;
        Message = message;
    }
    
    private PropertyValue<SafeMergeMessageType> _type = new PropertyValue<SafeMergeMessageType>(nameof(SafeMergeMessage), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public SafeMergeMessageType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<string> _message = new PropertyValue<string>(nameof(SafeMergeMessage), nameof(Message), "message");
    
    [Required]
    [JsonPropertyName("message")]
    public string Message
    {
        get => _message.GetValue(InlineErrors);
        set => _message.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _message.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

