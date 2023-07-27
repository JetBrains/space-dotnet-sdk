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

public class ChannelFilterValue
     : AnyOfFilterValue, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "ChannelFilterValue";
    
    public ChannelFilterValue() { }
    
    public ChannelFilterValue(ChannelIdentifier? identifier = null, ChannelFilterValueDetails? details = null)
    {
        Identifier = identifier;
        Details = details;
    }
    
    private PropertyValue<ChannelIdentifier?> _identifier = new PropertyValue<ChannelIdentifier?>(nameof(ChannelFilterValue), nameof(Identifier), "identifier");
    
    [JsonPropertyName("identifier")]
    public ChannelIdentifier? Identifier
    {
        get => _identifier.GetValue(InlineErrors);
        set => _identifier.SetValue(value);
    }

    private PropertyValue<ChannelFilterValueDetails?> _details = new PropertyValue<ChannelFilterValueDetails?>(nameof(ChannelFilterValue), nameof(Details), "details");
    
    [JsonPropertyName("details")]
    public ChannelFilterValueDetails? Details
    {
        get => _details.GetValue(InlineErrors);
        set => _details.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _identifier.SetAccessPath(parentChainPath, validateHasBeenSet);
        _details.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

