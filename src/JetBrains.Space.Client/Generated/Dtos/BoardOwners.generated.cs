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

public sealed class BoardOwners
     : IPropagatePropertyAccessPath
{
    public BoardOwners() { }
    
    public BoardOwners(BoardMemberOwners members, BoardTeamOwners teams)
    {
        Members = members;
        Teams = teams;
    }
    
    private PropertyValue<BoardMemberOwners> _members = new PropertyValue<BoardMemberOwners>(nameof(BoardOwners), nameof(Members), "members");
    
    [Required]
    [JsonPropertyName("members")]
    public BoardMemberOwners Members
    {
        get => _members.GetValue(InlineErrors);
        set => _members.SetValue(value);
    }

    private PropertyValue<BoardTeamOwners> _teams = new PropertyValue<BoardTeamOwners>(nameof(BoardOwners), nameof(Teams), "teams");
    
    [Required]
    [JsonPropertyName("teams")]
    public BoardTeamOwners Teams
    {
        get => _teams.GetValue(InlineErrors);
        set => _teams.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _members.SetAccessPath(parentChainPath, validateHasBeenSet);
        _teams.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

