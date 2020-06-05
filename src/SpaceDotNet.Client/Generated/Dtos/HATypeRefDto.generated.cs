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
    public sealed class HATypeRefDto
         : HATypeDto, IClassNameConvertible
    {
        private PropertyValue<HADtoDto> _dto = new PropertyValue<HADtoDto>(nameof(HATypeRefDto), nameof(Dto));
        
        [Required]
        [JsonPropertyName("dto")]
        public HADtoDto Dto { get { return _dto.GetValue(); } set { _dto.SetValue(value); } }
    
        private PropertyValue<bool> _nullable = new PropertyValue<bool>(nameof(HATypeRefDto), nameof(Nullable));
        
        [Required]
        [JsonPropertyName("nullable")]
        public bool Nullable { get { return _nullable.GetValue(); } set { _nullable.SetValue(value); } }
    
        private PropertyValue<bool> _optional = new PropertyValue<bool>(nameof(HATypeRefDto), nameof(Optional));
        
        [Required]
        [JsonPropertyName("optional")]
        public bool Optional { get { return _optional.GetValue(); } set { _optional.SetValue(value); } }
    
    }
    
}
