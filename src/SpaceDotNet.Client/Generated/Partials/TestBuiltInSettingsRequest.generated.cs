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

namespace SpaceDotNet.Client.TestBuiltInSettingsRequestExtensions
{
    public static class TestBuiltInSettingsRequestPartialExtensions
    {
        public static Partial<TestBuiltInSettingsRequest> WithSettings(this Partial<TestBuiltInSettingsRequest> it)    => it.AddFieldName("settings");
        
        public static Partial<TestBuiltInSettingsRequest> WithSettings(this Partial<TestBuiltInSettingsRequest> it, Func<Partial<ESBuiltinAuthModuleSettingsDto>, Partial<ESBuiltinAuthModuleSettingsDto>> partialBuilder)    => it.AddFieldName("settings", partialBuilder(new Partial<ESBuiltinAuthModuleSettingsDto>()));
        
        public static Partial<TestBuiltInSettingsRequest> WithUsername(this Partial<TestBuiltInSettingsRequest> it)    => it.AddFieldName("username");
        
        public static Partial<TestBuiltInSettingsRequest> WithPassword(this Partial<TestBuiltInSettingsRequest> it)    => it.AddFieldName("password");
        
    }
    
}
