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

public sealed class QualityGateCodeOwnerTeam
     : QualityGateCodeOwner, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "QualityGateCodeOwner.Team";
    
    public QualityGateCodeOwnerTeam() { }
    
    public QualityGateCodeOwnerTeam(TDTeam team, bool includesAuthor, string? name = null, bool? approved = null, int? approvesNumber = null, bool? preApproved = null)
    {
        Team = team;
        Name = name;
        IsApproved = approved;
        IsIncludesAuthor = includesAuthor;
        ApprovesNumber = approvesNumber;
        IsPreApproved = preApproved;
    }
    
    private PropertyValue<TDTeam> _team = new PropertyValue<TDTeam>(nameof(QualityGateCodeOwnerTeam), nameof(Team), "team");
    
    [Required]
    [JsonPropertyName("team")]
    public TDTeam Team
    {
        get => _team.GetValue(InlineErrors);
        set => _team.SetValue(value);
    }

    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(QualityGateCodeOwnerTeam), nameof(Name), "name");
    
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<bool?> _approved = new PropertyValue<bool?>(nameof(QualityGateCodeOwnerTeam), nameof(IsApproved), "approved");
    
    [JsonPropertyName("approved")]
    public bool? IsApproved
    {
        get => _approved.GetValue(InlineErrors);
        set => _approved.SetValue(value);
    }

    private PropertyValue<bool> _includesAuthor = new PropertyValue<bool>(nameof(QualityGateCodeOwnerTeam), nameof(IsIncludesAuthor), "includesAuthor");
    
    [Required]
    [JsonPropertyName("includesAuthor")]
    public bool IsIncludesAuthor
    {
        get => _includesAuthor.GetValue(InlineErrors);
        set => _includesAuthor.SetValue(value);
    }

    private PropertyValue<int?> _approvesNumber = new PropertyValue<int?>(nameof(QualityGateCodeOwnerTeam), nameof(ApprovesNumber), "approvesNumber");
    
    [JsonPropertyName("approvesNumber")]
    public int? ApprovesNumber
    {
        get => _approvesNumber.GetValue(InlineErrors);
        set => _approvesNumber.SetValue(value);
    }

    private PropertyValue<bool?> _preApproved = new PropertyValue<bool?>(nameof(QualityGateCodeOwnerTeam), nameof(IsPreApproved), "preApproved");
    
    [JsonPropertyName("preApproved")]
    public bool? IsPreApproved
    {
        get => _preApproved.GetValue(InlineErrors);
        set => _preApproved.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _team.SetAccessPath(parentChainPath, validateHasBeenSet);
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
