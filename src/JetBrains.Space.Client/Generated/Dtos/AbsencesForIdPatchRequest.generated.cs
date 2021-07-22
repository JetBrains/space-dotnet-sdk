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
    public class AbsencesForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public AbsencesForIdPatchRequest() { }
        
        public AbsencesForIdPatchRequest(bool available, string? member = null, string? reason = null, string? description = null, string? location = null, DateTime? since = null, DateTime? till = null, string? icon = null, List<CustomFieldInputValue>? customFieldValues = null)
        {
            Member = member;
            Reason = reason;
            Description = description;
            Location = location;
            Since = since;
            Till = till;
            IsAvailable = available;
            Icon = icon;
            CustomFieldValues = customFieldValues;
        }
        
        private PropertyValue<string?> _member = new PropertyValue<string?>(nameof(AbsencesForIdPatchRequest), nameof(Member));
        
        [JsonPropertyName("member")]
        public string? Member
        {
            get => _member.GetValue();
            set => _member.SetValue(value);
        }
    
        private PropertyValue<string?> _reason = new PropertyValue<string?>(nameof(AbsencesForIdPatchRequest), nameof(Reason));
        
        [JsonPropertyName("reason")]
        public string? Reason
        {
            get => _reason.GetValue();
            set => _reason.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(AbsencesForIdPatchRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<string?> _location = new PropertyValue<string?>(nameof(AbsencesForIdPatchRequest), nameof(Location));
        
        [JsonPropertyName("location")]
        public string? Location
        {
            get => _location.GetValue();
            set => _location.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _since = new PropertyValue<DateTime?>(nameof(AbsencesForIdPatchRequest), nameof(Since));
        
        [JsonPropertyName("since")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? Since
        {
            get => _since.GetValue();
            set => _since.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _till = new PropertyValue<DateTime?>(nameof(AbsencesForIdPatchRequest), nameof(Till));
        
        [JsonPropertyName("till")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? Till
        {
            get => _till.GetValue();
            set => _till.SetValue(value);
        }
    
        private PropertyValue<bool> _available = new PropertyValue<bool>(nameof(AbsencesForIdPatchRequest), nameof(IsAvailable));
        
        [Required]
        [JsonPropertyName("available")]
        public bool IsAvailable
        {
            get => _available.GetValue();
            set => _available.SetValue(value);
        }
    
        private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(AbsencesForIdPatchRequest), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public string? Icon
        {
            get => _icon.GetValue();
            set => _icon.SetValue(value);
        }
    
        private PropertyValue<List<CustomFieldInputValue>?> _customFieldValues = new PropertyValue<List<CustomFieldInputValue>?>(nameof(AbsencesForIdPatchRequest), nameof(CustomFieldValues));
        
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldInputValue>? CustomFieldValues
        {
            get => _customFieldValues.GetValue();
            set => _customFieldValues.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _member.SetAccessPath(path, validateHasBeenSet);
            _reason.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _location.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _available.SetAccessPath(path, validateHasBeenSet);
            _icon.SetAccessPath(path, validateHasBeenSet);
            _customFieldValues.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
