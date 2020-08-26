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
    public sealed class CExternalServicePrincipalDetailsDto
         : CPrincipalDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "CExternalServicePrincipalDetails";
        
        public CExternalServicePrincipalDetailsDto() { }
        
        public CExternalServicePrincipalDetailsDto(ESServiceDto service)
        {
            Service = service;
        }
        
        private PropertyValue<ESServiceDto> _service = new PropertyValue<ESServiceDto>(nameof(CExternalServicePrincipalDetailsDto), nameof(Service));
        
        [Required]
        [JsonPropertyName("service")]
        public ESServiceDto Service
        {
            get { return _service.GetValue(); }
            set { _service.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _service.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
