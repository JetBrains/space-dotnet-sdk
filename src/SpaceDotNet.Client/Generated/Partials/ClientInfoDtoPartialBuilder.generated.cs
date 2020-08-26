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

namespace SpaceDotNet.Client.ClientInfoDtoPartialBuilder
{
    public static class ClientInfoDtoPartialExtensions
    {
        public static Partial<ClientInfoDto> WithOs(this Partial<ClientInfoDto> it)
            => it.AddFieldName("os");
        
        public static Partial<ClientInfoDto> WithOs(this Partial<ClientInfoDto> it, Func<Partial<ClientOS>, Partial<ClientOS>> partialBuilder)
            => it.AddFieldName("os", partialBuilder(new Partial<ClientOS>(it)));
        
        public static Partial<ClientInfoDto> WithOsVersion(this Partial<ClientInfoDto> it)
            => it.AddFieldName("osVersion");
        
        public static Partial<ClientInfoDto> WithBrowser(this Partial<ClientInfoDto> it)
            => it.AddFieldName("browser");
        
        public static Partial<ClientInfoDto> WithBrowser(this Partial<ClientInfoDto> it, Func<Partial<ClientBrowser>, Partial<ClientBrowser>> partialBuilder)
            => it.AddFieldName("browser", partialBuilder(new Partial<ClientBrowser>(it)));
        
        public static Partial<ClientInfoDto> WithBrowserVersion(this Partial<ClientInfoDto> it)
            => it.AddFieldName("browserVersion");
        
        public static Partial<ClientInfoDto> WithDevice(this Partial<ClientInfoDto> it)
            => it.AddFieldName("device");
        
    }
    
}
