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

public sealed class IssueFieldOrderSystem
     : IssueFieldOrder, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "IssueFieldOrder.System";
    
    public IssueFieldOrderSystem() { }
    
    public IssueFieldOrderSystem(IssueSystemFieldEnum? field = null)
    {
        Field = field;
    }
    
    private PropertyValue<IssueSystemFieldEnum?> _field = new PropertyValue<IssueSystemFieldEnum?>(nameof(IssueFieldOrderSystem), nameof(Field), "field");
    
    [JsonPropertyName("field")]
    public IssueSystemFieldEnum? Field
    {
        get => _field.GetValue(InlineErrors);
        set => _field.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _field.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

