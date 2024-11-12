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

public sealed class QualityGateCodeOwnersApproval
     : IPropagatePropertyAccessPath
{
    public QualityGateCodeOwnersApproval() { }
    
    public QualityGateCodeOwnersApproval(string pattern, List<QualityGateCodeOwner> owners, bool? passed = null, int? minApproves = null, bool? preApproved = null)
    {
        Pattern = pattern;
        Owners = owners;
        IsPassed = passed;
        MinApproves = minApproves;
        IsPreApproved = preApproved;
    }
    
    private PropertyValue<string> _pattern = new PropertyValue<string>(nameof(QualityGateCodeOwnersApproval), nameof(Pattern), "pattern");
    
    [Required]
    [JsonPropertyName("pattern")]
    public string Pattern
    {
        get => _pattern.GetValue(InlineErrors);
        set => _pattern.SetValue(value);
    }

    private PropertyValue<List<QualityGateCodeOwner>> _owners = new PropertyValue<List<QualityGateCodeOwner>>(nameof(QualityGateCodeOwnersApproval), nameof(Owners), "owners", new List<QualityGateCodeOwner>());
    
    [Required]
    [JsonPropertyName("owners")]
    public List<QualityGateCodeOwner> Owners
    {
        get => _owners.GetValue(InlineErrors);
        set => _owners.SetValue(value);
    }

    private PropertyValue<bool?> _passed = new PropertyValue<bool?>(nameof(QualityGateCodeOwnersApproval), nameof(IsPassed), "passed");
    
    [JsonPropertyName("passed")]
    public bool? IsPassed
    {
        get => _passed.GetValue(InlineErrors);
        set => _passed.SetValue(value);
    }

    private PropertyValue<int?> _minApproves = new PropertyValue<int?>(nameof(QualityGateCodeOwnersApproval), nameof(MinApproves), "minApproves");
    
    [JsonPropertyName("minApproves")]
    public int? MinApproves
    {
        get => _minApproves.GetValue(InlineErrors);
        set => _minApproves.SetValue(value);
    }

    private PropertyValue<bool?> _preApproved = new PropertyValue<bool?>(nameof(QualityGateCodeOwnersApproval), nameof(IsPreApproved), "preApproved");
    
    [JsonPropertyName("preApproved")]
    public bool? IsPreApproved
    {
        get => _preApproved.GetValue(InlineErrors);
        set => _preApproved.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _pattern.SetAccessPath(parentChainPath, validateHasBeenSet);
        _owners.SetAccessPath(parentChainPath, validateHasBeenSet);
        _passed.SetAccessPath(parentChainPath, validateHasBeenSet);
        _minApproves.SetAccessPath(parentChainPath, validateHasBeenSet);
        _preApproved.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
