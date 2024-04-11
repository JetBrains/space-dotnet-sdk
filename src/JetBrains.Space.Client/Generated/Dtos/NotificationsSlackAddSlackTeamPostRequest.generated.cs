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

internal class NotificationsSlackAddSlackTeamPostRequest
     : IPropagatePropertyAccessPath
{
    public NotificationsSlackAddSlackTeamPostRequest() { }
    
    public NotificationsSlackAddSlackTeamPostRequest(SlackTeamIn team)
    {
        Team = team;
    }
    
    private PropertyValue<SlackTeamIn> _team = new PropertyValue<SlackTeamIn>(nameof(NotificationsSlackAddSlackTeamPostRequest), nameof(Team), "team");
    
    [Required]
    [JsonPropertyName("team")]
    public SlackTeamIn Team
    {
        get => _team.GetValue(InlineErrors);
        set => _team.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _team.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

