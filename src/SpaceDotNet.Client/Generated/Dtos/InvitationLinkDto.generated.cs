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
    public sealed class InvitationLinkDto
         : IPropagatePropertyAccessPath
    {
        public InvitationLinkDto() { }
        
        public InvitationLinkDto(string id, string name, CPrincipalDto createdBy, SpaceTime createdAt, int inviteeLimit, int inviteeUsage, bool deleted, SpaceTime? expiresAt = null)
        {
            Id = id;
            Name = name;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            ExpiresAt = expiresAt;
            InviteeLimit = inviteeLimit;
            InviteeUsage = inviteeUsage;
            Deleted = deleted;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(InvitationLinkDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(InvitationLinkDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<CPrincipalDto> _createdBy = new PropertyValue<CPrincipalDto>(nameof(InvitationLinkDto), nameof(CreatedBy));
        
        [Required]
        [JsonPropertyName("createdBy")]
        public CPrincipalDto CreatedBy
        {
            get { return _createdBy.GetValue(); }
            set { _createdBy.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _createdAt = new PropertyValue<SpaceTime>(nameof(InvitationLinkDto), nameof(CreatedAt));
        
        [Required]
        [JsonPropertyName("createdAt")]
        public SpaceTime CreatedAt
        {
            get { return _createdAt.GetValue(); }
            set { _createdAt.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _expiresAt = new PropertyValue<SpaceTime?>(nameof(InvitationLinkDto), nameof(ExpiresAt));
        
        [JsonPropertyName("expiresAt")]
        public SpaceTime? ExpiresAt
        {
            get { return _expiresAt.GetValue(); }
            set { _expiresAt.SetValue(value); }
        }
    
        private PropertyValue<int> _inviteeLimit = new PropertyValue<int>(nameof(InvitationLinkDto), nameof(InviteeLimit));
        
        [Required]
        [JsonPropertyName("inviteeLimit")]
        public int InviteeLimit
        {
            get { return _inviteeLimit.GetValue(); }
            set { _inviteeLimit.SetValue(value); }
        }
    
        private PropertyValue<int> _inviteeUsage = new PropertyValue<int>(nameof(InvitationLinkDto), nameof(InviteeUsage));
        
        [Required]
        [JsonPropertyName("inviteeUsage")]
        public int InviteeUsage
        {
            get { return _inviteeUsage.GetValue(); }
            set { _inviteeUsage.SetValue(value); }
        }
    
        private PropertyValue<bool> _deleted = new PropertyValue<bool>(nameof(InvitationLinkDto), nameof(Deleted));
        
        [Required]
        [JsonPropertyName("deleted")]
        public bool Deleted
        {
            get { return _deleted.GetValue(); }
            set { _deleted.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _createdBy.SetAccessPath(path, validateHasBeenSet);
            _createdAt.SetAccessPath(path, validateHasBeenSet);
            _expiresAt.SetAccessPath(path, validateHasBeenSet);
            _inviteeLimit.SetAccessPath(path, validateHasBeenSet);
            _inviteeUsage.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
