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

namespace SpaceDotNet.Client
{
    public sealed class CExternalServicePrincipalDetailsDto
         : CPrincipalDetailsDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<ESServiceDto> _service = new PropertyValue<ESServiceDto>(nameof(CExternalServicePrincipalDetailsDto), nameof(Service));
        
        [Required]
        [JsonPropertyName("service")]
        public ESServiceDto Service { get { return _service.GetValue(); } set { _service.SetValue(value); } }
    
    }
    
}
