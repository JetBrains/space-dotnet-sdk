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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class TDMembership
         : IPropagatePropertyAccessPath
    {
        public TDMembership() { }
        
        public TDMembership(string id, TDTeam team, TDRole role, bool lead, bool requiresApproval, bool archived, Dictionary<string, CFValue> customFields, TDMemberProfile? member = null, TDMemberProfile? manager = null, DateTime? since = null, DateTime? till = null, DateTime? activeSince = null, DateTime? activeTill = null, TDMembership? editFor = null, TDMembership? pendingEdit = null, TDMemberProfile? approver = null)
        {
            Id = id;
            Member = member;
            Team = team;
            Role = role;
            IsLead = lead;
            Manager = manager;
            Since = since;
            Till = till;
            ActiveSince = activeSince;
            ActiveTill = activeTill;
            IsRequiresApproval = requiresApproval;
            IsArchived = archived;
            EditFor = editFor;
            PendingEdit = pendingEdit;
            Approver = approver;
            CustomFields = customFields;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDMembership), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile?> _member = new PropertyValue<TDMemberProfile?>(nameof(TDMembership), nameof(Member));
        
        [JsonPropertyName("member")]
        public TDMemberProfile? Member
        {
            get => _member.GetValue();
            set => _member.SetValue(value);
        }
    
        private PropertyValue<TDTeam> _team = new PropertyValue<TDTeam>(nameof(TDMembership), nameof(Team));
        
        [Required]
        [JsonPropertyName("team")]
        public TDTeam Team
        {
            get => _team.GetValue();
            set => _team.SetValue(value);
        }
    
        private PropertyValue<TDRole> _role = new PropertyValue<TDRole>(nameof(TDMembership), nameof(Role));
        
        [Required]
        [JsonPropertyName("role")]
        public TDRole Role
        {
            get => _role.GetValue();
            set => _role.SetValue(value);
        }
    
        private PropertyValue<bool> _lead = new PropertyValue<bool>(nameof(TDMembership), nameof(IsLead));
        
        [Required]
        [JsonPropertyName("lead")]
        public bool IsLead
        {
            get => _lead.GetValue();
            set => _lead.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile?> _manager = new PropertyValue<TDMemberProfile?>(nameof(TDMembership), nameof(Manager));
        
        [JsonPropertyName("manager")]
        public TDMemberProfile? Manager
        {
            get => _manager.GetValue();
            set => _manager.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _since = new PropertyValue<DateTime?>(nameof(TDMembership), nameof(Since));
        
        [JsonPropertyName("since")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? Since
        {
            get => _since.GetValue();
            set => _since.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _till = new PropertyValue<DateTime?>(nameof(TDMembership), nameof(Till));
        
        [JsonPropertyName("till")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? Till
        {
            get => _till.GetValue();
            set => _till.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _activeSince = new PropertyValue<DateTime?>(nameof(TDMembership), nameof(ActiveSince));
        
        [JsonPropertyName("activeSince")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? ActiveSince
        {
            get => _activeSince.GetValue();
            set => _activeSince.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _activeTill = new PropertyValue<DateTime?>(nameof(TDMembership), nameof(ActiveTill));
        
        [JsonPropertyName("activeTill")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? ActiveTill
        {
            get => _activeTill.GetValue();
            set => _activeTill.SetValue(value);
        }
    
        private PropertyValue<bool> _requiresApproval = new PropertyValue<bool>(nameof(TDMembership), nameof(IsRequiresApproval));
        
        [Required]
        [JsonPropertyName("requiresApproval")]
        public bool IsRequiresApproval
        {
            get => _requiresApproval.GetValue();
            set => _requiresApproval.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TDMembership), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<TDMembership?> _editFor = new PropertyValue<TDMembership?>(nameof(TDMembership), nameof(EditFor));
        
        [JsonPropertyName("editFor")]
        public TDMembership? EditFor
        {
            get => _editFor.GetValue();
            set => _editFor.SetValue(value);
        }
    
        private PropertyValue<TDMembership?> _pendingEdit = new PropertyValue<TDMembership?>(nameof(TDMembership), nameof(PendingEdit));
        
        [JsonPropertyName("pendingEdit")]
        public TDMembership? PendingEdit
        {
            get => _pendingEdit.GetValue();
            set => _pendingEdit.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile?> _approver = new PropertyValue<TDMemberProfile?>(nameof(TDMembership), nameof(Approver));
        
        [JsonPropertyName("approver")]
        public TDMemberProfile? Approver
        {
            get => _approver.GetValue();
            set => _approver.SetValue(value);
        }
    
        private PropertyValue<Dictionary<string, CFValue>> _customFields = new PropertyValue<Dictionary<string, CFValue>>(nameof(TDMembership), nameof(CustomFields));
        
        [Required]
        [JsonPropertyName("customFields")]
        public Dictionary<string, CFValue> CustomFields
        {
            get => _customFields.GetValue();
            set => _customFields.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _member.SetAccessPath(path, validateHasBeenSet);
            _team.SetAccessPath(path, validateHasBeenSet);
            _role.SetAccessPath(path, validateHasBeenSet);
            _lead.SetAccessPath(path, validateHasBeenSet);
            _manager.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _activeSince.SetAccessPath(path, validateHasBeenSet);
            _activeTill.SetAccessPath(path, validateHasBeenSet);
            _requiresApproval.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _editFor.SetAccessPath(path, validateHasBeenSet);
            _pendingEdit.SetAccessPath(path, validateHasBeenSet);
            _approver.SetAccessPath(path, validateHasBeenSet);
            _customFields.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}