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
    public sealed class ESSamlAttributeNamesDto
    {
        private PropertyValue<string?> _loginAttributeName = new PropertyValue<string?>(nameof(ESSamlAttributeNamesDto), nameof(LoginAttributeName));
        
        [JsonPropertyName("loginAttributeName")]
        public string? LoginAttributeName { get { return _loginAttributeName.GetValue(); } set { _loginAttributeName.SetValue(value); } }
    
        private PropertyValue<string?> _firstNameAttributeName = new PropertyValue<string?>(nameof(ESSamlAttributeNamesDto), nameof(FirstNameAttributeName));
        
        [JsonPropertyName("firstNameAttributeName")]
        public string? FirstNameAttributeName { get { return _firstNameAttributeName.GetValue(); } set { _firstNameAttributeName.SetValue(value); } }
    
        private PropertyValue<string?> _lastNameAttributeName = new PropertyValue<string?>(nameof(ESSamlAttributeNamesDto), nameof(LastNameAttributeName));
        
        [JsonPropertyName("lastNameAttributeName")]
        public string? LastNameAttributeName { get { return _lastNameAttributeName.GetValue(); } set { _lastNameAttributeName.SetValue(value); } }
    
        private PropertyValue<string?> _fullNameAttributeName = new PropertyValue<string?>(nameof(ESSamlAttributeNamesDto), nameof(FullNameAttributeName));
        
        [JsonPropertyName("fullNameAttributeName")]
        public string? FullNameAttributeName { get { return _fullNameAttributeName.GetValue(); } set { _fullNameAttributeName.SetValue(value); } }
    
        private PropertyValue<string?> _emailAttributeName = new PropertyValue<string?>(nameof(ESSamlAttributeNamesDto), nameof(EmailAttributeName));
        
        [JsonPropertyName("emailAttributeName")]
        public string? EmailAttributeName { get { return _emailAttributeName.GetValue(); } set { _emailAttributeName.SetValue(value); } }
    
        private PropertyValue<bool> _emailVerified = new PropertyValue<bool>(nameof(ESSamlAttributeNamesDto), nameof(EmailVerified));
        
        [Required]
        [JsonPropertyName("emailVerified")]
        public bool EmailVerified { get { return _emailVerified.GetValue(); } set { _emailVerified.SetValue(value); } }
    
    }
    
}
