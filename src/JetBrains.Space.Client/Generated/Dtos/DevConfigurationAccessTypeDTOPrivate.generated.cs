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

public sealed class DevConfigurationAccessTypeDTOPrivate
     : DevConfigurationAccessTypeDTO, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "DevConfigurationAccessTypeDTO_Private";
    
    public DevConfigurationAccessTypeDTOPrivate() { }
    
    public DevConfigurationAccessTypeDTOPrivate(List<DevConfigurationParticipantDTO> participants)
    {
        Participants = participants;
    }
    
    private PropertyValue<List<DevConfigurationParticipantDTO>> _participants = new PropertyValue<List<DevConfigurationParticipantDTO>>(nameof(DevConfigurationAccessTypeDTOPrivate), nameof(Participants), "participants", new List<DevConfigurationParticipantDTO>());
    
    [Required]
    [JsonPropertyName("participants")]
    public List<DevConfigurationParticipantDTO> Participants
    {
        get => _participants.GetValue(InlineErrors);
        set => _participants.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _participants.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
