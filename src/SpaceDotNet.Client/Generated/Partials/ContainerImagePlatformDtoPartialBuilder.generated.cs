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

namespace SpaceDotNet.Client.ContainerImagePlatformDtoPartialBuilder
{
    public static class ContainerImagePlatformDtoPartialExtensions
    {
        public static Partial<ContainerImagePlatformDto> WithOs(this Partial<ContainerImagePlatformDto> it)
            => it.AddFieldName("os");
        
        public static Partial<ContainerImagePlatformDto> WithOsVersion(this Partial<ContainerImagePlatformDto> it)
            => it.AddFieldName("osVersion");
        
        public static Partial<ContainerImagePlatformDto> WithArch(this Partial<ContainerImagePlatformDto> it)
            => it.AddFieldName("arch");
        
    }
    
}