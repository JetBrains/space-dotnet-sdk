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
    public class AuthModulesTestLdapPostRequest
         : IPropagatePropertyAccessPath
    {
        public AuthModulesTestLdapPostRequest() { }
        
        public AuthModulesTestLdapPostRequest(ESLdapAuthModuleSettings settings, string username, string password)
        {
            Settings = settings;
            Username = username;
            Password = password;
        }
        
        private PropertyValue<ESLdapAuthModuleSettings> _settings = new PropertyValue<ESLdapAuthModuleSettings>(nameof(AuthModulesTestLdapPostRequest), nameof(Settings));
        
        [Required]
        [JsonPropertyName("settings")]
        public ESLdapAuthModuleSettings Settings
        {
            get => _settings.GetValue();
            set => _settings.SetValue(value);
        }
    
        private PropertyValue<string> _username = new PropertyValue<string>(nameof(AuthModulesTestLdapPostRequest), nameof(Username));
        
        [Required]
        [JsonPropertyName("username")]
        public string Username
        {
            get => _username.GetValue();
            set => _username.SetValue(value);
        }
    
        private PropertyValue<string> _password = new PropertyValue<string>(nameof(AuthModulesTestLdapPostRequest), nameof(Password));
        
        [Required]
        [JsonPropertyName("password")]
        public string Password
        {
            get => _password.GetValue();
            set => _password.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _settings.SetAccessPath(path, validateHasBeenSet);
            _username.SetAccessPath(path, validateHasBeenSet);
            _password.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
