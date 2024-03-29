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

public sealed class HARight
     : IPropagatePropertyAccessPath
{
    public HARight() { }
    
    public HARight(string rightUniqueCode, string title, string? description = null)
    {
        RightUniqueCode = rightUniqueCode;
        Title = title;
        Description = description;
    }
    
    private PropertyValue<string> _rightUniqueCode = new PropertyValue<string>(nameof(HARight), nameof(RightUniqueCode), "rightUniqueCode");
    
    [Required]
    [JsonPropertyName("rightUniqueCode")]
    public string RightUniqueCode
    {
        get => _rightUniqueCode.GetValue(InlineErrors);
        set => _rightUniqueCode.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(HARight), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(HARight), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _rightUniqueCode.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

