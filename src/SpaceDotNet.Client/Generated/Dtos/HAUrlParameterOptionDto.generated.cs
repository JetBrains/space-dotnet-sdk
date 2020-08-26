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

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public class HAUrlParameterOptionDto
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "HA_UrlParameterOption";
        
        public static HAUrlParameterOptionConstDto Const(string value, string optionName, HADeprecationDto? deprecation = null)
            => new HAUrlParameterOptionConstDto(value: value, optionName: optionName, deprecation: null);
        
        public static HAUrlParameterOptionVarDto Var(HAFieldDto parameter, bool prefixRequired, string optionName, HADeprecationDto? deprecation = null)
            => new HAUrlParameterOptionVarDto(parameter: parameter, prefixRequired: prefixRequired, optionName: optionName, deprecation: null);
        
        public HAUrlParameterOptionDto() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
