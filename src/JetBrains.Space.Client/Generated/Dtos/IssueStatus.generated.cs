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
    public sealed class IssueStatus
         : IPropagatePropertyAccessPath
    {
        public IssueStatus() { }
        
        public IssueStatus(string id, bool archived, string name, bool resolved, string color)
        {
            Id = id;
            IsArchived = archived;
            Name = name;
            IsResolved = resolved;
            Color = color;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(IssueStatus), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(IssueStatus), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(IssueStatus), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<bool> _resolved = new PropertyValue<bool>(nameof(IssueStatus), nameof(IsResolved));
        
        [Required]
        [JsonPropertyName("resolved")]
        public bool IsResolved
        {
            get => _resolved.GetValue();
            set => _resolved.SetValue(value);
        }
    
        private PropertyValue<string> _color = new PropertyValue<string>(nameof(IssueStatus), nameof(Color));
        
        [Required]
        [JsonPropertyName("color")]
        public string Color
        {
            get => _color.GetValue();
            set => _color.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _resolved.SetAccessPath(path, validateHasBeenSet);
            _color.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
