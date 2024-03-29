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

public sealed class IssueSearchExpressionAnd
     : IssueSearchExpression, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "IssueSearchExpression.And";
    
    public IssueSearchExpressionAnd() { }
    
    public IssueSearchExpressionAnd(List<IssueSearchExpression> subExpressions)
    {
        SubExpressions = subExpressions;
    }
    
    private PropertyValue<List<IssueSearchExpression>> _subExpressions = new PropertyValue<List<IssueSearchExpression>>(nameof(IssueSearchExpressionAnd), nameof(SubExpressions), "subExpressions", new List<IssueSearchExpression>());
    
    [Required]
    [JsonPropertyName("subExpressions")]
    public List<IssueSearchExpression> SubExpressions
    {
        get => _subExpressions.GetValue(InlineErrors);
        set => _subExpressions.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _subExpressions.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

