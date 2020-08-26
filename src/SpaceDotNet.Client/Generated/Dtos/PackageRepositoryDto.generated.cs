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
    public sealed class PackageRepositoryDto
         : IPropagatePropertyAccessPath
    {
        public PackageRepositoryDto() { }
        
        public PackageRepositoryDto(string id, PackageTypeDto type, bool @public, bool archived, string? name = null, string? description = null, ESPackageRepositorySettingsDto? settings = null)
        {
            Id = id;
            Type = type;
            Name = name;
            Description = description;
            Public = @public;
            Settings = settings;
            Archived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PackageRepositoryDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<PackageTypeDto> _type = new PropertyValue<PackageTypeDto>(nameof(PackageRepositoryDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public PackageTypeDto Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(PackageRepositoryDto), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(PackageRepositoryDto), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<bool> _public = new PropertyValue<bool>(nameof(PackageRepositoryDto), nameof(Public));
        
        [Required]
        [JsonPropertyName("public")]
        public bool Public
        {
            get { return _public.GetValue(); }
            set { _public.SetValue(value); }
        }
    
        private PropertyValue<ESPackageRepositorySettingsDto?> _settings = new PropertyValue<ESPackageRepositorySettingsDto?>(nameof(PackageRepositoryDto), nameof(Settings));
        
        [JsonPropertyName("settings")]
        public ESPackageRepositorySettingsDto? Settings
        {
            get { return _settings.GetValue(); }
            set { _settings.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(PackageRepositoryDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _public.SetAccessPath(path, validateHasBeenSet);
            _settings.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
