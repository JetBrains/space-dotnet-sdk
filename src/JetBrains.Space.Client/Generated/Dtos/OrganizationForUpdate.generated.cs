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
    public sealed class OrganizationForUpdate
         : IPropagatePropertyAccessPath
    {
        public OrganizationForUpdate() { }
        
        public OrganizationForUpdate(string name, string? slogan = null, string? logoSmall = null, string? logo = null, string? logoId = null, string? slackWorkspace = null, bool? onboardingRequired = null, ATimeZone? timezone = null)
        {
            Name = name;
            Slogan = slogan;
            LogoSmall = logoSmall;
            Logo = logo;
            LogoId = logoId;
            SlackWorkspace = slackWorkspace;
            IsOnboardingRequired = onboardingRequired;
            Timezone = timezone;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(OrganizationForUpdate), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string?> _slogan = new PropertyValue<string?>(nameof(OrganizationForUpdate), nameof(Slogan));
        
        [JsonPropertyName("slogan")]
        public string? Slogan
        {
            get => _slogan.GetValue();
            set => _slogan.SetValue(value);
        }
    
        private PropertyValue<string?> _logoSmall = new PropertyValue<string?>(nameof(OrganizationForUpdate), nameof(LogoSmall));
        
        [JsonPropertyName("logoSmall")]
        public string? LogoSmall
        {
            get => _logoSmall.GetValue();
            set => _logoSmall.SetValue(value);
        }
    
        private PropertyValue<string?> _logo = new PropertyValue<string?>(nameof(OrganizationForUpdate), nameof(Logo));
        
        [JsonPropertyName("logo")]
        public string? Logo
        {
            get => _logo.GetValue();
            set => _logo.SetValue(value);
        }
    
        private PropertyValue<string?> _logoId = new PropertyValue<string?>(nameof(OrganizationForUpdate), nameof(LogoId));
        
        [JsonPropertyName("logoId")]
        public string? LogoId
        {
            get => _logoId.GetValue();
            set => _logoId.SetValue(value);
        }
    
        private PropertyValue<string?> _slackWorkspace = new PropertyValue<string?>(nameof(OrganizationForUpdate), nameof(SlackWorkspace));
        
        [JsonPropertyName("slackWorkspace")]
        public string? SlackWorkspace
        {
            get => _slackWorkspace.GetValue();
            set => _slackWorkspace.SetValue(value);
        }
    
        private PropertyValue<bool?> _onboardingRequired = new PropertyValue<bool?>(nameof(OrganizationForUpdate), nameof(IsOnboardingRequired));
        
        [JsonPropertyName("onboardingRequired")]
        public bool? IsOnboardingRequired
        {
            get => _onboardingRequired.GetValue();
            set => _onboardingRequired.SetValue(value);
        }
    
        private PropertyValue<ATimeZone?> _timezone = new PropertyValue<ATimeZone?>(nameof(OrganizationForUpdate), nameof(Timezone));
        
        [JsonPropertyName("timezone")]
        public ATimeZone? Timezone
        {
            get => _timezone.GetValue();
            set => _timezone.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _slogan.SetAccessPath(path, validateHasBeenSet);
            _logoSmall.SetAccessPath(path, validateHasBeenSet);
            _logo.SetAccessPath(path, validateHasBeenSet);
            _logoId.SetAccessPath(path, validateHasBeenSet);
            _slackWorkspace.SetAccessPath(path, validateHasBeenSet);
            _onboardingRequired.SetAccessPath(path, validateHasBeenSet);
            _timezone.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
