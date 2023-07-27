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

public sealed class IssueSearchExpressionFieldFilter
     : IssueSearchExpression, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "IssueSearchExpression.FieldFilter";
    
    public IssueSearchExpressionFieldFilter() { }
    
    public IssueSearchExpressionFieldFilter(IssueFieldFilter fieldFilter)
    {
        FieldFilter = fieldFilter;
    }
    
    private PropertyValue<IssueFieldFilter> _fieldFilter = new PropertyValue<IssueFieldFilter>(nameof(IssueSearchExpressionFieldFilter), nameof(FieldFilter), "fieldFilter");
    
    [Required]
    [JsonPropertyName("fieldFilter")]
    public IssueFieldFilter FieldFilter
    {
        get => _fieldFilter.GetValue(InlineErrors);
        set => _fieldFilter.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _fieldFilter.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

