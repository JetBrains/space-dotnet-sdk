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

namespace SpaceDotNet.Client.PackageDataDtoPartialBuilder
{
    public static class PackageDataDtoPartialExtensions
    {
        public static Partial<PackageDataDto> WithType(this Partial<PackageDataDto> it)
            => it.AddFieldName("type");
        
        public static Partial<PackageDataDto> WithType(this Partial<PackageDataDto> it, Func<Partial<PackageTypeDto>, Partial<PackageTypeDto>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<PackageTypeDto>(it)));
        
        public static Partial<PackageDataDto> WithRepository(this Partial<PackageDataDto> it)
            => it.AddFieldName("repository");
        
        public static Partial<PackageDataDto> WithName(this Partial<PackageDataDto> it)
            => it.AddFieldName("name");
        
        public static Partial<PackageDataDto> WithVersions(this Partial<PackageDataDto> it)
            => it.AddFieldName("versions");
        
        public static Partial<PackageDataDto> WithUpdated(this Partial<PackageDataDto> it)
            => it.AddFieldName("updated");
        
        public static Partial<PackageDataDto> WithLastVersion(this Partial<PackageDataDto> it)
            => it.AddFieldName("lastVersion");
        
    }
    
}
