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
    public sealed class MessageImageDto
         : MessageAccessoryElementDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MessageImage";
        
        public MessageImageDto() { }
        
        public MessageImageDto(string src)
        {
            Src = src;
        }
        
        private PropertyValue<string> _src = new PropertyValue<string>(nameof(MessageImageDto), nameof(Src));
        
        [Required]
        [JsonPropertyName("src")]
        public string Src
        {
            get { return _src.GetValue(); }
            set { _src.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _src.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
