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
    public class ProjectsPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsPostRequest() { }
        
        public ProjectsPostRequest(ProjectKeyDto key, string name, bool @private = false, List<string>? tags = null, string? description = null)
        {
            Key = key;
            Name = name;
            Description = description;
            Private = @private;
            Tags = (tags ?? new List<string>());
        }
        
        private PropertyValue<ProjectKeyDto> _key = new PropertyValue<ProjectKeyDto>(nameof(ProjectsPostRequest), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public ProjectKeyDto Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsPostRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsPostRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<bool> _private = new PropertyValue<bool>(nameof(ProjectsPostRequest), nameof(Private));
        
        [JsonPropertyName("private")]
        public bool Private
        {
            get { return _private.GetValue(); }
            set { _private.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _tags = new PropertyValue<List<string>>(nameof(ProjectsPostRequest), nameof(Tags));
        
        [JsonPropertyName("tags")]
        public List<string> Tags
        {
            get { return _tags.GetValue(); }
            set { _tags.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _key.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _private.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
