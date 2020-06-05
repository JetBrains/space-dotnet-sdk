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
    public sealed class DTOAbsenceSubscriptionDto
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(DTOAbsenceSubscriptionDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id { get { return _id.GetValue(); } set { _id.SetValue(value); } }
    
        private PropertyValue<TDLocationDto?> _location = new PropertyValue<TDLocationDto?>(nameof(DTOAbsenceSubscriptionDto), nameof(Location));
        
        [JsonPropertyName("location")]
        public TDLocationDto? Location { get { return _location.GetValue(); } set { _location.SetValue(value); } }
    
        private PropertyValue<TDTeamDto?> _team = new PropertyValue<TDTeamDto?>(nameof(DTOAbsenceSubscriptionDto), nameof(Team));
        
        [JsonPropertyName("team")]
        public TDTeamDto? Team { get { return _team.GetValue(); } set { _team.SetValue(value); } }
    
        private PropertyValue<AbsenceReasonRecordDto?> _reason = new PropertyValue<AbsenceReasonRecordDto?>(nameof(DTOAbsenceSubscriptionDto), nameof(Reason));
        
        [JsonPropertyName("reason")]
        public AbsenceReasonRecordDto? Reason { get { return _reason.GetValue(); } set { _reason.SetValue(value); } }
    
    }
    
}
