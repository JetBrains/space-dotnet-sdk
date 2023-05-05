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

public sealed class DocumentCFFilter
     : AnyOfCFFilter, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "DocumentCFFilter";
    
    public DocumentCFFilter() { }
    
    public DocumentCFFilter(List<DocumentCFInputValue> values)
    {
        Values = values;
    }
    
    private PropertyValue<List<DocumentCFInputValue>> _values = new PropertyValue<List<DocumentCFInputValue>>(nameof(DocumentCFFilter), nameof(Values), "values", new List<DocumentCFInputValue>());
    
    [Required]
    [JsonPropertyName("values")]
    public List<DocumentCFInputValue> Values
    {
        get => _values.GetValue(InlineErrors);
        set => _values.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _values.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

