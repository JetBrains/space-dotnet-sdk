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

namespace SpaceDotNet.Client.ESOIDCAuthModuleSettingsDtoPartialBuilder
{
    public static class ESOIDCAuthModuleSettingsDtoPartialExtensions
    {
        public static Partial<ESOIDCAuthModuleSettingsDto> WithClientId(this Partial<ESOIDCAuthModuleSettingsDto> it)
            => it.AddFieldName("clientId");
        
        public static Partial<ESOIDCAuthModuleSettingsDto> WithClientSecret(this Partial<ESOIDCAuthModuleSettingsDto> it)
            => it.AddFieldName("clientSecret");
        
        public static Partial<ESOIDCAuthModuleSettingsDto> WithRegisterNewUsers(this Partial<ESOIDCAuthModuleSettingsDto> it)
            => it.AddFieldName("registerNewUsers");
        
        public static Partial<ESOIDCAuthModuleSettingsDto> WithDiscoveryUrl(this Partial<ESOIDCAuthModuleSettingsDto> it)
            => it.AddFieldName("discoveryUrl");
        
        public static Partial<ESOIDCAuthModuleSettingsDto> WithIssuer(this Partial<ESOIDCAuthModuleSettingsDto> it)
            => it.AddFieldName("issuer");
        
        public static Partial<ESOIDCAuthModuleSettingsDto> WithAuthorizationEndpoint(this Partial<ESOIDCAuthModuleSettingsDto> it)
            => it.AddFieldName("authorizationEndpoint");
        
        public static Partial<ESOIDCAuthModuleSettingsDto> WithTokenEndpoint(this Partial<ESOIDCAuthModuleSettingsDto> it)
            => it.AddFieldName("tokenEndpoint");
        
        public static Partial<ESOIDCAuthModuleSettingsDto> WithTokenKeysEndpoint(this Partial<ESOIDCAuthModuleSettingsDto> it)
            => it.AddFieldName("tokenKeysEndpoint");
        
        public static Partial<ESOIDCAuthModuleSettingsDto> WithUserInfoEndpoint(this Partial<ESOIDCAuthModuleSettingsDto> it)
            => it.AddFieldName("userInfoEndpoint");
        
        public static Partial<ESOIDCAuthModuleSettingsDto> WithDomains(this Partial<ESOIDCAuthModuleSettingsDto> it)
            => it.AddFieldName("domains");
        
    }
    
}
