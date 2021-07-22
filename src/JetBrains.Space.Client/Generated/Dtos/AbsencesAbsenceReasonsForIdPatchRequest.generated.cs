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

namespace JetBrains.Space.Client
{
    public class AbsencesAbsenceReasonsForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public AbsencesAbsenceReasonsForIdPatchRequest() { }
        
        public AbsencesAbsenceReasonsForIdPatchRequest(string name, string description, bool defaultAvailability, bool approvalRequired, string? icon = null)
        {
            Name = name;
            Description = description;
            IsDefaultAvailability = defaultAvailability;
            IsApprovalRequired = approvalRequired;
            Icon = icon;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(AbsencesAbsenceReasonsForIdPatchRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(AbsencesAbsenceReasonsForIdPatchRequest), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<bool> _defaultAvailability = new PropertyValue<bool>(nameof(AbsencesAbsenceReasonsForIdPatchRequest), nameof(IsDefaultAvailability));
        
        [Required]
        [JsonPropertyName("defaultAvailability")]
        public bool IsDefaultAvailability
        {
            get => _defaultAvailability.GetValue();
            set => _defaultAvailability.SetValue(value);
        }
    
        private PropertyValue<bool> _approvalRequired = new PropertyValue<bool>(nameof(AbsencesAbsenceReasonsForIdPatchRequest), nameof(IsApprovalRequired));
        
        [Required]
        [JsonPropertyName("approvalRequired")]
        public bool IsApprovalRequired
        {
            get => _approvalRequired.GetValue();
            set => _approvalRequired.SetValue(value);
        }
    
        private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(AbsencesAbsenceReasonsForIdPatchRequest), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public string? Icon
        {
            get => _icon.GetValue();
            set => _icon.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _defaultAvailability.SetAccessPath(path, validateHasBeenSet);
            _approvalRequired.SetAccessPath(path, validateHasBeenSet);
            _icon.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
