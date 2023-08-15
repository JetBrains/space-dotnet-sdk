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

internal class CustomFieldsForTypeKeyFieldsReorderPostRequest
     : IPropagatePropertyAccessPath
{
    public CustomFieldsForTypeKeyFieldsReorderPostRequest() { }
    
    public CustomFieldsForTypeKeyFieldsReorderPostRequest(List<string> customFieldOrder, ExtendedTypeScope scope)
    {
        CustomFieldOrder = customFieldOrder;
        Scope = scope;
    }
    
    private PropertyValue<List<string>> _customFieldOrder = new PropertyValue<List<string>>(nameof(CustomFieldsForTypeKeyFieldsReorderPostRequest), nameof(CustomFieldOrder), "customFieldOrder", new List<string>());
    
    [Required]
    [JsonPropertyName("customFieldOrder")]
    public List<string> CustomFieldOrder
    {
        get => _customFieldOrder.GetValue(InlineErrors);
        set => _customFieldOrder.SetValue(value);
    }

    private PropertyValue<ExtendedTypeScope> _scope = new PropertyValue<ExtendedTypeScope>(nameof(CustomFieldsForTypeKeyFieldsReorderPostRequest), nameof(Scope), "scope");
    
    [Required]
    [JsonPropertyName("scope")]
    public ExtendedTypeScope Scope
    {
        get => _scope.GetValue(InlineErrors);
        set => _scope.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _customFieldOrder.SetAccessPath(parentChainPath, validateHasBeenSet);
        _scope.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

