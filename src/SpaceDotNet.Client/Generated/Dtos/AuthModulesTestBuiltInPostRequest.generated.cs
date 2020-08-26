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
    public class AuthModulesTestBuiltInPostRequest
         : IPropagatePropertyAccessPath
    {
        public AuthModulesTestBuiltInPostRequest() { }
        
        public AuthModulesTestBuiltInPostRequest(ESBuiltinAuthModuleSettingsDto settings, string username, string password)
        {
            Settings = settings;
            Username = username;
            Password = password;
        }
        
        private PropertyValue<ESBuiltinAuthModuleSettingsDto> _settings = new PropertyValue<ESBuiltinAuthModuleSettingsDto>(nameof(AuthModulesTestBuiltInPostRequest), nameof(Settings));
        
        [Required]
        [JsonPropertyName("settings")]
        public ESBuiltinAuthModuleSettingsDto Settings
        {
            get { return _settings.GetValue(); }
            set { _settings.SetValue(value); }
        }
    
        private PropertyValue<string> _username = new PropertyValue<string>(nameof(AuthModulesTestBuiltInPostRequest), nameof(Username));
        
        [Required]
        [JsonPropertyName("username")]
        public string Username
        {
            get { return _username.GetValue(); }
            set { _username.SetValue(value); }
        }
    
        private PropertyValue<string> _password = new PropertyValue<string>(nameof(AuthModulesTestBuiltInPostRequest), nameof(Password));
        
        [Required]
        [JsonPropertyName("password")]
        public string Password
        {
            get { return _password.GetValue(); }
            set { _password.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _settings.SetAccessPath(path, validateHasBeenSet);
            _username.SetAccessPath(path, validateHasBeenSet);
            _password.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
