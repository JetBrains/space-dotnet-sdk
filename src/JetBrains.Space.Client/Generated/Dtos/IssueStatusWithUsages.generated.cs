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

public sealed class IssueStatusWithUsages
     : IPropagatePropertyAccessPath
{
    public IssueStatusWithUsages() { }
    
    public IssueStatusWithUsages(IssueStatus status, int usages)
    {
        Status = status;
        Usages = usages;
    }
    
    private PropertyValue<IssueStatus> _status = new PropertyValue<IssueStatus>(nameof(IssueStatusWithUsages), nameof(Status), "status");
    
    [Required]
    [JsonPropertyName("status")]
    public IssueStatus Status
    {
        get => _status.GetValue(InlineErrors);
        set => _status.SetValue(value);
    }

    private PropertyValue<int> _usages = new PropertyValue<int>(nameof(IssueStatusWithUsages), nameof(Usages), "usages");
    
    [Required]
    [JsonPropertyName("usages")]
    public int Usages
    {
        get => _usages.GetValue(InlineErrors);
        set => _usages.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _status.SetAccessPath(parentChainPath, validateHasBeenSet);
        _usages.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

