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

public sealed class QualityGateCodeOwnerUser
     : QualityGateCodeOwner, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "QualityGateCodeOwner.User";
    
    public QualityGateCodeOwnerUser() { }
    
    public QualityGateCodeOwnerUser(TDMemberProfile profile, bool includesAuthor, string? name = null, bool? approved = null, bool? preApproved = null)
    {
        Profile = profile;
        Name = name;
        IsApproved = approved;
        IsIncludesAuthor = includesAuthor;
        IsPreApproved = preApproved;
    }
    
    private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(QualityGateCodeOwnerUser), nameof(Profile), "profile");
    
    [Required]
    [JsonPropertyName("profile")]
    public TDMemberProfile Profile
    {
        get => _profile.GetValue(InlineErrors);
        set => _profile.SetValue(value);
    }

    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(QualityGateCodeOwnerUser), nameof(Name), "name");
    
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<bool?> _approved = new PropertyValue<bool?>(nameof(QualityGateCodeOwnerUser), nameof(IsApproved), "approved");
    
    [JsonPropertyName("approved")]
    public bool? IsApproved
    {
        get => _approved.GetValue(InlineErrors);
        set => _approved.SetValue(value);
    }

    private PropertyValue<bool> _includesAuthor = new PropertyValue<bool>(nameof(QualityGateCodeOwnerUser), nameof(IsIncludesAuthor), "includesAuthor");
    
    [Required]
    [JsonPropertyName("includesAuthor")]
    public bool IsIncludesAuthor
    {
        get => _includesAuthor.GetValue(InlineErrors);
        set => _includesAuthor.SetValue(value);
    }

    private PropertyValue<bool?> _preApproved = new PropertyValue<bool?>(nameof(QualityGateCodeOwnerUser), nameof(IsPreApproved), "preApproved");
    
    [JsonPropertyName("preApproved")]
    public bool? IsPreApproved
    {
        get => _preApproved.GetValue(InlineErrors);
        set => _preApproved.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _profile.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _approved.SetAccessPath(parentChainPath, validateHasBeenSet);
        _includesAuthor.SetAccessPath(parentChainPath, validateHasBeenSet);
        _preApproved.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

