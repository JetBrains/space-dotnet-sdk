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
    public sealed class FTSUserDto
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(FTSUserDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id { get { return _id.GetValue(); } set { _id.SetValue(value); } }
    
        private PropertyValue<string> _username = new PropertyValue<string>(nameof(FTSUserDto), nameof(Username));
        
        [Required]
        [JsonPropertyName("username")]
        public string Username { get { return _username.GetValue(); } set { _username.SetValue(value); } }
    
        private PropertyValue<TDProfileNameDto> _name = new PropertyValue<TDProfileNameDto>(nameof(FTSUserDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public TDProfileNameDto Name { get { return _name.GetValue(); } set { _name.SetValue(value); } }
    
        private PropertyValue<string?> _avatar = new PropertyValue<string?>(nameof(FTSUserDto), nameof(Avatar));
        
        [JsonPropertyName("avatar")]
        public string? Avatar { get { return _avatar.GetValue(); } set { _avatar.SetValue(value); } }
    
        private PropertyValue<List<TDProfileNameDto>> _languages = new PropertyValue<List<TDProfileNameDto>>(nameof(FTSUserDto), nameof(Languages));
        
        [Required]
        [JsonPropertyName("languages")]
        public List<TDProfileNameDto> Languages { get { return _languages.GetValue(); } set { _languages.SetValue(value); } }
    
        private PropertyValue<bool?> _notAMember = new PropertyValue<bool?>(nameof(FTSUserDto), nameof(NotAMember));
        
        [JsonPropertyName("notAMember")]
        public bool? NotAMember { get { return _notAMember.GetValue(); } set { _notAMember.SetValue(value); } }
    
    }
    
}
