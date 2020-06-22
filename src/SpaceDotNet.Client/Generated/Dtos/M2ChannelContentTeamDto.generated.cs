// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class M2ChannelContentTeamDto
         : M2ChannelContactInfoDto, M2ChannelContentInfoDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<TDTeamDto> _team = new PropertyValue<TDTeamDto>(nameof(M2ChannelContentTeamDto), nameof(Team));
        
        [Required]
        [JsonPropertyName("team")]
        public TDTeamDto Team
        {
            get { return _team.GetValue(); }
            set { _team.SetValue(value); }
        }
    
        private PropertyValue<ChannelSpecificDefaultsDto> _notificationDefaults = new PropertyValue<ChannelSpecificDefaultsDto>(nameof(M2ChannelContentTeamDto), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaultsDto NotificationDefaults
        {
            get { return _notificationDefaults.GetValue(); }
            set { _notificationDefaults.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _team.SetAccessPath(path + "->WithTeam()", validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path + "->WithNotificationDefaults()", validateHasBeenSet);
        }
    
    }
    
}
