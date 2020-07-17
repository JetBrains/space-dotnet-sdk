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
    public class ProjectsForProjectPackagesRepositoriesPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPackagesRepositoriesPostRequest() { }
        
        public ProjectsForProjectPackagesRepositoriesPostRequest(string type, string name, bool @public, ESPackageRepositorySettingsDto settings, string? description = null)
        {
            Type = type;
            Name = name;
            Description = description;
            Public = @public;
            Settings = settings;
        }
        
        private PropertyValue<string> _type = new PropertyValue<string>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public string Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<bool> _public = new PropertyValue<bool>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Public));
        
        [Required]
        [JsonPropertyName("public")]
        public bool Public
        {
            get { return _public.GetValue(); }
            set { _public.SetValue(value); }
        }
    
        private PropertyValue<ESPackageRepositorySettingsDto> _settings = new PropertyValue<ESPackageRepositorySettingsDto>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Settings));
        
        [Required]
        [JsonPropertyName("settings")]
        public ESPackageRepositorySettingsDto Settings
        {
            get { return _settings.GetValue(); }
            set { _settings.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _public.SetAccessPath(path, validateHasBeenSet);
            _settings.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}