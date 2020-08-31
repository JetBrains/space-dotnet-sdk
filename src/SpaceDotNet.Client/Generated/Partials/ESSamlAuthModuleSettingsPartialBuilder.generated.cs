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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.ESSamlAuthModuleSettingsPartialBuilder
{
    public static class ESSamlAuthModuleSettingsPartialExtensions
    {
        public static Partial<ESSamlAuthModuleSettings> WithIdpUrl(this Partial<ESSamlAuthModuleSettings> it)
            => it.AddFieldName("idpUrl");
        
        public static Partial<ESSamlAuthModuleSettings> WithIdpEntityId(this Partial<ESSamlAuthModuleSettings> it)
            => it.AddFieldName("idpEntityId");
        
        public static Partial<ESSamlAuthModuleSettings> WithIdpCertificateSHA256(this Partial<ESSamlAuthModuleSettings> it)
            => it.AddFieldName("idpCertificateSHA256");
        
        public static Partial<ESSamlAuthModuleSettings> WithSpEntityId(this Partial<ESSamlAuthModuleSettings> it)
            => it.AddFieldName("spEntityId");
        
        public static Partial<ESSamlAuthModuleSettings> WithSslKeystore(this Partial<ESSamlAuthModuleSettings> it)
            => it.AddFieldName("sslKeystore");
        
        public static Partial<ESSamlAuthModuleSettings> WithSslKeystore(this Partial<ESSamlAuthModuleSettings> it, Func<Partial<SSLKeystore>, Partial<SSLKeystore>> partialBuilder)
            => it.AddFieldName("sslKeystore", partialBuilder(new Partial<SSLKeystore>(it)));
        
        public static Partial<ESSamlAuthModuleSettings> WithIsRegisterNewUsers(this Partial<ESSamlAuthModuleSettings> it)
            => it.AddFieldName("registerNewUsers");
        
        public static Partial<ESSamlAuthModuleSettings> WithContactProfileId(this Partial<ESSamlAuthModuleSettings> it)
            => it.AddFieldName("contactProfileId");
        
        public static Partial<ESSamlAuthModuleSettings> WithAttributeNames(this Partial<ESSamlAuthModuleSettings> it)
            => it.AddFieldName("attributeNames");
        
        public static Partial<ESSamlAuthModuleSettings> WithAttributeNames(this Partial<ESSamlAuthModuleSettings> it, Func<Partial<ESSamlAttributeNames>, Partial<ESSamlAttributeNames>> partialBuilder)
            => it.AddFieldName("attributeNames", partialBuilder(new Partial<ESSamlAttributeNames>(it)));
        
    }
    
}
