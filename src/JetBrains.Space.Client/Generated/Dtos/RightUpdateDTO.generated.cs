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

public sealed class RightUpdateDTO
     : IPropagatePropertyAccessPath
{
    public RightUpdateDTO() { }
    
    public RightUpdateDTO(string rightCode, RightStatus status)
    {
        RightCode = rightCode;
        Status = status;
    }
    
    private PropertyValue<string> _rightCode = new PropertyValue<string>(nameof(RightUpdateDTO), nameof(RightCode), "rightCode");
    
    [Required]
    [JsonPropertyName("rightCode")]
    public string RightCode
    {
        get => _rightCode.GetValue(InlineErrors);
        set => _rightCode.SetValue(value);
    }

    private PropertyValue<RightStatus> _status = new PropertyValue<RightStatus>(nameof(RightUpdateDTO), nameof(Status), "status");
    
    [Required]
    [JsonPropertyName("status")]
    public RightStatus Status
    {
        get => _status.GetValue(InlineErrors);
        set => _status.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _rightCode.SetAccessPath(parentChainPath, validateHasBeenSet);
        _status.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
