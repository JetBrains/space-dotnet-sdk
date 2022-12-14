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

public sealed class IdeNames
     : IPropagatePropertyAccessPath
{
    public IdeNames() { }
    
    public IdeNames(string backendFullName, string backendShortName, string clientFullName, string clientShortName, bool usesSeparateClientProduct)
    {
        BackendFullName = backendFullName;
        BackendShortName = backendShortName;
        ClientFullName = clientFullName;
        ClientShortName = clientShortName;
        IsUsesSeparateClientProduct = usesSeparateClientProduct;
    }
    
    private PropertyValue<string> _backendFullName = new PropertyValue<string>(nameof(IdeNames), nameof(BackendFullName), "backendFullName");
    
    [Required]
    [JsonPropertyName("backendFullName")]
    public string BackendFullName
    {
        get => _backendFullName.GetValue(InlineErrors);
        set => _backendFullName.SetValue(value);
    }

    private PropertyValue<string> _backendShortName = new PropertyValue<string>(nameof(IdeNames), nameof(BackendShortName), "backendShortName");
    
    [Required]
    [JsonPropertyName("backendShortName")]
    public string BackendShortName
    {
        get => _backendShortName.GetValue(InlineErrors);
        set => _backendShortName.SetValue(value);
    }

    private PropertyValue<string> _clientFullName = new PropertyValue<string>(nameof(IdeNames), nameof(ClientFullName), "clientFullName");
    
    [Required]
    [JsonPropertyName("clientFullName")]
    public string ClientFullName
    {
        get => _clientFullName.GetValue(InlineErrors);
        set => _clientFullName.SetValue(value);
    }

    private PropertyValue<string> _clientShortName = new PropertyValue<string>(nameof(IdeNames), nameof(ClientShortName), "clientShortName");
    
    [Required]
    [JsonPropertyName("clientShortName")]
    public string ClientShortName
    {
        get => _clientShortName.GetValue(InlineErrors);
        set => _clientShortName.SetValue(value);
    }

    private PropertyValue<bool> _usesSeparateClientProduct = new PropertyValue<bool>(nameof(IdeNames), nameof(IsUsesSeparateClientProduct), "usesSeparateClientProduct");
    
    [Required]
    [JsonPropertyName("usesSeparateClientProduct")]
    public bool IsUsesSeparateClientProduct
    {
        get => _usesSeparateClientProduct.GetValue(InlineErrors);
        set => _usesSeparateClientProduct.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _backendFullName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _backendShortName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientFullName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientShortName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _usesSeparateClientProduct.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
