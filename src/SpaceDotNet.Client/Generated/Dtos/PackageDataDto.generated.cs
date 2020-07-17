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
    public sealed class PackageDataDto
         : IPropagatePropertyAccessPath
    {
        public PackageDataDto() { }
        
        public PackageDataDto(PackageTypeDto type, string repository, string name, long versions, long updated, string lastVersion)
        {
            Type = type;
            Repository = repository;
            Name = name;
            Versions = versions;
            Updated = updated;
            LastVersion = lastVersion;
        }
        
        private PropertyValue<PackageTypeDto> _type = new PropertyValue<PackageTypeDto>(nameof(PackageDataDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public PackageTypeDto Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(PackageDataDto), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PackageDataDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<long> _versions = new PropertyValue<long>(nameof(PackageDataDto), nameof(Versions));
        
        [Required]
        [JsonPropertyName("versions")]
        public long Versions
        {
            get { return _versions.GetValue(); }
            set { _versions.SetValue(value); }
        }
    
        private PropertyValue<long> _updated = new PropertyValue<long>(nameof(PackageDataDto), nameof(Updated));
        
        [Required]
        [JsonPropertyName("updated")]
        public long Updated
        {
            get { return _updated.GetValue(); }
            set { _updated.SetValue(value); }
        }
    
        private PropertyValue<string> _lastVersion = new PropertyValue<string>(nameof(PackageDataDto), nameof(LastVersion));
        
        [Required]
        [JsonPropertyName("lastVersion")]
        public string LastVersion
        {
            get { return _lastVersion.GetValue(); }
            set { _lastVersion.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _versions.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
            _lastVersion.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}