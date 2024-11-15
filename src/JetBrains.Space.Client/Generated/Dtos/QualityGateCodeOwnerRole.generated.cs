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

public sealed class QualityGateCodeOwnerRole
     : QualityGateCodeOwner, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "QualityGateCodeOwner.Role";
    
    public QualityGateCodeOwnerRole() { }
    
    public QualityGateCodeOwnerRole(string id, bool includesAuthor, string? name = null, bool? approved = null, int? approvesNumber = null, bool? preApproved = null)
    {
        Id = id;
        Name = name;
        IsApproved = approved;
        IsIncludesAuthor = includesAuthor;
        ApprovesNumber = approvesNumber;
        IsPreApproved = preApproved;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(QualityGateCodeOwnerRole), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(QualityGateCodeOwnerRole), nameof(Name), "name");
    
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<bool?> _approved = new PropertyValue<bool?>(nameof(QualityGateCodeOwnerRole), nameof(IsApproved), "approved");
    
    [JsonPropertyName("approved")]
    public bool? IsApproved
    {
        get => _approved.GetValue(InlineErrors);
        set => _approved.SetValue(value);
    }

    private PropertyValue<bool> _includesAuthor = new PropertyValue<bool>(nameof(QualityGateCodeOwnerRole), nameof(IsIncludesAuthor), "includesAuthor");
    
    [Required]
    [JsonPropertyName("includesAuthor")]
    public bool IsIncludesAuthor
    {
        get => _includesAuthor.GetValue(InlineErrors);
        set => _includesAuthor.SetValue(value);
    }

    private PropertyValue<int?> _approvesNumber = new PropertyValue<int?>(nameof(QualityGateCodeOwnerRole), nameof(ApprovesNumber), "approvesNumber");
    
    [JsonPropertyName("approvesNumber")]
    public int? ApprovesNumber
    {
        get => _approvesNumber.GetValue(InlineErrors);
        set => _approvesNumber.SetValue(value);
    }

    private PropertyValue<bool?> _preApproved = new PropertyValue<bool?>(nameof(QualityGateCodeOwnerRole), nameof(IsPreApproved), "preApproved");
    
    [JsonPropertyName("preApproved")]
    public bool? IsPreApproved
    {
        get => _preApproved.GetValue(InlineErrors);
        set => _preApproved.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _approved.SetAccessPath(parentChainPath, validateHasBeenSet);
        _includesAuthor.SetAccessPath(parentChainPath, validateHasBeenSet);
        _approvesNumber.SetAccessPath(parentChainPath, validateHasBeenSet);
        _preApproved.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

