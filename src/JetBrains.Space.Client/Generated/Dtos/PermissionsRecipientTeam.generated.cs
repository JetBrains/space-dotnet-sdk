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

public sealed class PermissionsRecipientTeam
     : PermissionsRecipient, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "PermissionsRecipient.Team";
    
    public PermissionsRecipientTeam() { }
    
    public PermissionsRecipientTeam(TDTeam team)
    {
        Team = team;
    }
    
    private PropertyValue<TDTeam> _team = new PropertyValue<TDTeam>(nameof(PermissionsRecipientTeam), nameof(Team), "team");
    
    [Required]
    [JsonPropertyName("team")]
    public TDTeam Team
    {
        get => _team.GetValue(InlineErrors);
        set => _team.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _team.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

