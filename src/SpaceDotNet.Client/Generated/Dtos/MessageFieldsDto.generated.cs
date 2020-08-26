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
    public sealed class MessageFieldsDto
         : MessageElementDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MessageFields";
        
        public MessageFieldsDto() { }
        
        public MessageFieldsDto(List<MessageFieldElementDto> fields)
        {
            Fields = fields;
        }
        
        private PropertyValue<List<MessageFieldElementDto>> _fields = new PropertyValue<List<MessageFieldElementDto>>(nameof(MessageFieldsDto), nameof(Fields));
        
        [Required]
        [JsonPropertyName("fields")]
        public List<MessageFieldElementDto> Fields
        {
            get { return _fields.GetValue(); }
            set { _fields.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _fields.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
