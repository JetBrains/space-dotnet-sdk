// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class AbsenceEventDto
         : IPropagatePropertyAccessPath
    {
        public AbsenceEventDto() { }
        
        public AbsenceEventDto(TDMemberWithTeamDto profile, List<AbsenceRecordDto> events)
        {
            Profile = profile;
            Events = events;
        }
        
        private PropertyValue<TDMemberWithTeamDto> _profile = new PropertyValue<TDMemberWithTeamDto>(nameof(AbsenceEventDto), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberWithTeamDto Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<List<AbsenceRecordDto>> _events = new PropertyValue<List<AbsenceRecordDto>>(nameof(AbsenceEventDto), nameof(Events));
        
        [Required]
        [JsonPropertyName("events")]
        public List<AbsenceRecordDto> Events
        {
            get { return _events.GetValue(); }
            set { _events.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _events.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
