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

public sealed class TestConnectionResult
     : IPropagatePropertyAccessPath
{
    public TestConnectionResult() { }
    
    public TestConnectionResult(bool success, List<string> dangerBranches, string? reason = null)
    {
        IsSuccess = success;
        Reason = reason;
        DangerBranches = dangerBranches;
    }
    
    private PropertyValue<bool> _success = new PropertyValue<bool>(nameof(TestConnectionResult), nameof(IsSuccess), "success");
    
    [Required]
    [JsonPropertyName("success")]
    public bool IsSuccess
    {
        get => _success.GetValue(InlineErrors);
        set => _success.SetValue(value);
    }

    private PropertyValue<string?> _reason = new PropertyValue<string?>(nameof(TestConnectionResult), nameof(Reason), "reason");
    
    [JsonPropertyName("reason")]
    public string? Reason
    {
        get => _reason.GetValue(InlineErrors);
        set => _reason.SetValue(value);
    }

    private PropertyValue<List<string>> _dangerBranches = new PropertyValue<List<string>>(nameof(TestConnectionResult), nameof(DangerBranches), "dangerBranches", new List<string>());
    
    [Required]
    [JsonPropertyName("dangerBranches")]
    public List<string> DangerBranches
    {
        get => _dangerBranches.GetValue(InlineErrors);
        set => _dangerBranches.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _success.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reason.SetAccessPath(parentChainPath, validateHasBeenSet);
        _dangerBranches.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
