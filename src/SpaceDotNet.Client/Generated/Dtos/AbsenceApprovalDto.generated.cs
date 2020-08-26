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
    public sealed class AbsenceApprovalDto
         : IPropagatePropertyAccessPath
    {
        public AbsenceApprovalDto() { }
        
        public AbsenceApprovalDto(bool approved, TDMemberProfileDto approvedBy, SpaceTime approvedAt)
        {
            Approved = approved;
            ApprovedBy = approvedBy;
            ApprovedAt = approvedAt;
        }
        
        private PropertyValue<bool> _approved = new PropertyValue<bool>(nameof(AbsenceApprovalDto), nameof(Approved));
        
        [Required]
        [JsonPropertyName("approved")]
        public bool Approved
        {
            get { return _approved.GetValue(); }
            set { _approved.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto> _approvedBy = new PropertyValue<TDMemberProfileDto>(nameof(AbsenceApprovalDto), nameof(ApprovedBy));
        
        [Required]
        [JsonPropertyName("approvedBy")]
        public TDMemberProfileDto ApprovedBy
        {
            get { return _approvedBy.GetValue(); }
            set { _approvedBy.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _approvedAt = new PropertyValue<SpaceTime>(nameof(AbsenceApprovalDto), nameof(ApprovedAt));
        
        [Required]
        [JsonPropertyName("approvedAt")]
        public SpaceTime ApprovedAt
        {
            get { return _approvedAt.GetValue(); }
            set { _approvedAt.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _approved.SetAccessPath(path, validateHasBeenSet);
            _approvedBy.SetAccessPath(path, validateHasBeenSet);
            _approvedAt.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
