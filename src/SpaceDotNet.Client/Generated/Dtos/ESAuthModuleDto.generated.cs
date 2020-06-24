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
    public sealed class ESAuthModuleDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESAuthModuleDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(ESAuthModuleDto), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ESAuthModuleDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<int> _ordinal = new PropertyValue<int>(nameof(ESAuthModuleDto), nameof(Ordinal));
        
        [Required]
        [JsonPropertyName("ordinal")]
        public int Ordinal
        {
            get { return _ordinal.GetValue(); }
            set { _ordinal.SetValue(value); }
        }
    
        private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(ESAuthModuleDto), nameof(Enabled));
        
        [Required]
        [JsonPropertyName("enabled")]
        public bool Enabled
        {
            get { return _enabled.GetValue(); }
            set { _enabled.SetValue(value); }
        }
    
        private PropertyValue<string?> _iconDataURI = new PropertyValue<string?>(nameof(ESAuthModuleDto), nameof(IconDataURI));
        
        [JsonPropertyName("iconDataURI")]
        public string? IconDataURI
        {
            get { return _iconDataURI.GetValue(); }
            set { _iconDataURI.SetValue(value); }
        }
    
        private PropertyValue<ESAuthModuleSettingsDto> _settings = new PropertyValue<ESAuthModuleSettingsDto>(nameof(ESAuthModuleDto), nameof(Settings));
        
        [Required]
        [JsonPropertyName("settings")]
        public ESAuthModuleSettingsDto Settings
        {
            get { return _settings.GetValue(); }
            set { _settings.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _key.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _ordinal.SetAccessPath(path, validateHasBeenSet);
            _enabled.SetAccessPath(path, validateHasBeenSet);
            _iconDataURI.SetAccessPath(path, validateHasBeenSet);
            _settings.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
