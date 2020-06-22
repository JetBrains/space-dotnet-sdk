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
    public sealed class M2ChannelContentMemberDto
         : M2ChannelContactInfoDto, M2ChannelContentInfoDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<TDMemberProfileDto> _member = new PropertyValue<TDMemberProfileDto>(nameof(M2ChannelContentMemberDto), nameof(Member));
        
        [Required]
        [JsonPropertyName("member")]
        public TDMemberProfileDto Member
        {
            get { return _member.GetValue(); }
            set { _member.SetValue(value); }
        }
    
        private PropertyValue<ChannelSpecificDefaultsDto> _notificationDefaults = new PropertyValue<ChannelSpecificDefaultsDto>(nameof(M2ChannelContentMemberDto), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaultsDto NotificationDefaults
        {
            get { return _notificationDefaults.GetValue(); }
            set { _notificationDefaults.SetValue(value); }
        }
    
        private PropertyValue<ProfileAbsencesRecordDto?> _memberAbsences = new PropertyValue<ProfileAbsencesRecordDto?>(nameof(M2ChannelContentMemberDto), nameof(MemberAbsences));
        
        [JsonPropertyName("memberAbsences")]
        public ProfileAbsencesRecordDto? MemberAbsences
        {
            get { return _memberAbsences.GetValue(); }
            set { _memberAbsences.SetValue(value); }
        }
    
        private PropertyValue<ProfileMembershipRecordDto?> _memberTeams = new PropertyValue<ProfileMembershipRecordDto?>(nameof(M2ChannelContentMemberDto), nameof(MemberTeams));
        
        [JsonPropertyName("memberTeams")]
        public ProfileMembershipRecordDto? MemberTeams
        {
            get { return _memberTeams.GetValue(); }
            set { _memberTeams.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _member.SetAccessPath(path + "->WithMember()", validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path + "->WithNotificationDefaults()", validateHasBeenSet);
            _memberAbsences.SetAccessPath(path + "->WithMemberAbsences()", validateHasBeenSet);
            _memberTeams.SetAccessPath(path + "->WithMemberTeams()", validateHasBeenSet);
        }
    
    }
    
}
