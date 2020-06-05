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
    public class UpdateMembershipRequest
    {
        private PropertyValue<string?> _memberId = new PropertyValue<string?>(nameof(UpdateMembershipRequest), nameof(MemberId));
        
        [JsonPropertyName("memberId")]
        public string? MemberId { get { return _memberId.GetValue(); } set { _memberId.SetValue(value); } }
    
        private PropertyValue<string?> _teamId = new PropertyValue<string?>(nameof(UpdateMembershipRequest), nameof(TeamId));
        
        [JsonPropertyName("teamId")]
        public string? TeamId { get { return _teamId.GetValue(); } set { _teamId.SetValue(value); } }
    
        private PropertyValue<string?> _roleId = new PropertyValue<string?>(nameof(UpdateMembershipRequest), nameof(RoleId));
        
        [JsonPropertyName("roleId")]
        public string? RoleId { get { return _roleId.GetValue(); } set { _roleId.SetValue(value); } }
    
        private PropertyValue<bool?> _lead = new PropertyValue<bool?>(nameof(UpdateMembershipRequest), nameof(Lead));
        
        [JsonPropertyName("lead")]
        public bool? Lead { get { return _lead.GetValue(); } set { _lead.SetValue(value); } }
    
        private PropertyValue<string?> _managerId = new PropertyValue<string?>(nameof(UpdateMembershipRequest), nameof(ManagerId));
        
        [JsonPropertyName("managerId")]
        public string? ManagerId { get { return _managerId.GetValue(); } set { _managerId.SetValue(value); } }
    
        private PropertyValue<SpaceDate?> _since = new PropertyValue<SpaceDate?>(nameof(UpdateMembershipRequest), nameof(Since));
        
        [JsonPropertyName("since")]
        public SpaceDate? Since { get { return _since.GetValue(); } set { _since.SetValue(value); } }
    
        private PropertyValue<SpaceDate?> _till = new PropertyValue<SpaceDate?>(nameof(UpdateMembershipRequest), nameof(Till));
        
        [JsonPropertyName("till")]
        public SpaceDate? Till { get { return _till.GetValue(); } set { _till.SetValue(value); } }
    
        private PropertyValue<SpaceTime?> _activeSince = new PropertyValue<SpaceTime?>(nameof(UpdateMembershipRequest), nameof(ActiveSince));
        
        [JsonPropertyName("activeSince")]
        public SpaceTime? ActiveSince { get { return _activeSince.GetValue(); } set { _activeSince.SetValue(value); } }
    
        private PropertyValue<SpaceTime?> _activeTill = new PropertyValue<SpaceTime?>(nameof(UpdateMembershipRequest), nameof(ActiveTill));
        
        [JsonPropertyName("activeTill")]
        public SpaceTime? ActiveTill { get { return _activeTill.GetValue(); } set { _activeTill.SetValue(value); } }
    
        private PropertyValue<string?> _previousMembershipId = new PropertyValue<string?>(nameof(UpdateMembershipRequest), nameof(PreviousMembershipId));
        
        [JsonPropertyName("previousMembershipId")]
        public string? PreviousMembershipId { get { return _previousMembershipId.GetValue(); } set { _previousMembershipId.SetValue(value); } }
    
        private PropertyValue<bool> _requiresApproval = new PropertyValue<bool>(nameof(UpdateMembershipRequest), nameof(RequiresApproval));
        
        [Required]
        [JsonPropertyName("requiresApproval")]
        public bool RequiresApproval { get { return _requiresApproval.GetValue(); } set { _requiresApproval.SetValue(value); } }
    
        private PropertyValue<List<CustomFieldValueDto>?> _customFieldValues = new PropertyValue<List<CustomFieldValueDto>?>(nameof(UpdateMembershipRequest), nameof(CustomFieldValues));
        
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldValueDto>? CustomFieldValues { get { return _customFieldValues.GetValue(); } set { _customFieldValues.SetValue(value); } }
    
    }
    
}
