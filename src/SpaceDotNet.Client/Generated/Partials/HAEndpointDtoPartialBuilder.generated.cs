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

namespace SpaceDotNet.Client.HAEndpointDtoPartialBuilder
{
    public static class HAEndpointDtoPartialExtensions
    {
        public static Partial<HAEndpointDto> WithResource(this Partial<HAEndpointDto> it)
            => it.AddFieldName("resource");
        
        public static Partial<HAEndpointDto> WithResource(this Partial<HAEndpointDto> it, Func<Partial<HAResourceDto>, Partial<HAResourceDto>> partialBuilder)
            => it.AddFieldName("resource", partialBuilder(new Partial<HAResourceDto>(it)));
        
        public static Partial<HAEndpointDto> WithMethod(this Partial<HAEndpointDto> it)
            => it.AddFieldName("method");
        
        public static Partial<HAEndpointDto> WithMethod(this Partial<HAEndpointDto> it, Func<Partial<HAMethod>, Partial<HAMethod>> partialBuilder)
            => it.AddFieldName("method", partialBuilder(new Partial<HAMethod>(it)));
        
        public static Partial<HAEndpointDto> WithParameters(this Partial<HAEndpointDto> it)
            => it.AddFieldName("parameters");
        
        public static Partial<HAEndpointDto> WithParameters(this Partial<HAEndpointDto> it, Func<Partial<HAParameterDto>, Partial<HAParameterDto>> partialBuilder)
            => it.AddFieldName("parameters", partialBuilder(new Partial<HAParameterDto>(it)));
        
        public static Partial<HAEndpointDto> WithRequestBody(this Partial<HAEndpointDto> it)
            => it.AddFieldName("requestBody");
        
        public static Partial<HAEndpointDto> WithRequestBody(this Partial<HAEndpointDto> it, Func<Partial<HATypeObjectDto>, Partial<HATypeObjectDto>> partialBuilder)
            => it.AddFieldName("requestBody", partialBuilder(new Partial<HATypeObjectDto>(it)));
        
        public static Partial<HAEndpointDto> WithResponseBody(this Partial<HAEndpointDto> it)
            => it.AddFieldName("responseBody");
        
        public static Partial<HAEndpointDto> WithResponseBody(this Partial<HAEndpointDto> it, Func<Partial<HATypeDto>, Partial<HATypeDto>> partialBuilder)
            => it.AddFieldName("responseBody", partialBuilder(new Partial<HATypeDto>(it)));
        
        public static Partial<HAEndpointDto> WithPath(this Partial<HAEndpointDto> it)
            => it.AddFieldName("path");
        
        public static Partial<HAEndpointDto> WithPath(this Partial<HAEndpointDto> it, Func<Partial<HAPathDto>, Partial<HAPathDto>> partialBuilder)
            => it.AddFieldName("path", partialBuilder(new Partial<HAPathDto>(it)));
        
        public static Partial<HAEndpointDto> WithDisplayName(this Partial<HAEndpointDto> it)
            => it.AddFieldName("displayName");
        
        public static Partial<HAEndpointDto> WithDoc(this Partial<HAEndpointDto> it)
            => it.AddFieldName("doc");
        
        public static Partial<HAEndpointDto> WithDeprecation(this Partial<HAEndpointDto> it)
            => it.AddFieldName("deprecation");
        
        public static Partial<HAEndpointDto> WithDeprecation(this Partial<HAEndpointDto> it, Func<Partial<HADeprecationDto>, Partial<HADeprecationDto>> partialBuilder)
            => it.AddFieldName("deprecation", partialBuilder(new Partial<HADeprecationDto>(it)));
        
    }
    
}
