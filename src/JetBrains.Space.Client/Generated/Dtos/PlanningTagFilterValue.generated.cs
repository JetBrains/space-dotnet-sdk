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

public sealed class PlanningTagFilterValue
     : AnyOfFilterValue, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "PlanningTagFilterValue";
    
    public PlanningTagFilterValue() { }
    
    public PlanningTagFilterValue(PlanningTagIn? tagIn = null)
    {
        TagIn = tagIn;
    }
    
    private PropertyValue<PlanningTagIn?> _tagIn = new PropertyValue<PlanningTagIn?>(nameof(PlanningTagFilterValue), nameof(TagIn), "tagIn");
    
    [JsonPropertyName("tagIn")]
    public PlanningTagIn? TagIn
    {
        get => _tagIn.GetValue(InlineErrors);
        set => _tagIn.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _tagIn.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
