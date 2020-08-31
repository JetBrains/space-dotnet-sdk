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

namespace SpaceDotNet.Client.AuthModulesPostRequestPartialBuilder
{
    public static class AuthModulesPostRequestPartialExtensions
    {
        public static Partial<AuthModulesPostRequest> WithKey(this Partial<AuthModulesPostRequest> it)
            => it.AddFieldName("key");
        
        public static Partial<AuthModulesPostRequest> WithName(this Partial<AuthModulesPostRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<AuthModulesPostRequest> WithIsEnabled(this Partial<AuthModulesPostRequest> it)
            => it.AddFieldName("enabled");
        
        public static Partial<AuthModulesPostRequest> WithSettings(this Partial<AuthModulesPostRequest> it)
            => it.AddFieldName("settings");
        
        public static Partial<AuthModulesPostRequest> WithSettings(this Partial<AuthModulesPostRequest> it, Func<Partial<ESAuthModuleSettings>, Partial<ESAuthModuleSettings>> partialBuilder)
            => it.AddFieldName("settings", partialBuilder(new Partial<ESAuthModuleSettings>(it)));
        
    }
    
}
