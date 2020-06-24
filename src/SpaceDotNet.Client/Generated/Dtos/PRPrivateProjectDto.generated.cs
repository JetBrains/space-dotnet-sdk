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
    public sealed class PRPrivateProjectDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<ProjectKeyDto> _key = new PropertyValue<ProjectKeyDto>(nameof(PRPrivateProjectDto), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public ProjectKeyDto Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PRPrivateProjectDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<bool> _accessAllowed = new PropertyValue<bool>(nameof(PRPrivateProjectDto), nameof(AccessAllowed));
        
        [Required]
        [JsonPropertyName("accessAllowed")]
        public bool AccessAllowed
        {
            get { return _accessAllowed.GetValue(); }
            set { _accessAllowed.SetValue(value); }
        }
    
        private PropertyValue<List<TDMemberProfileDto>> _admins = new PropertyValue<List<TDMemberProfileDto>>(nameof(PRPrivateProjectDto), nameof(Admins));
        
        [Required]
        [JsonPropertyName("admins")]
        public List<TDMemberProfileDto> Admins
        {
            get { return _admins.GetValue(); }
            set { _admins.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _key.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _accessAllowed.SetAccessPath(path, validateHasBeenSet);
            _admins.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
