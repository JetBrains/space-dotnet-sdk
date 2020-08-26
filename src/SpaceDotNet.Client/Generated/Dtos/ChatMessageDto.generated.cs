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
    public class ChatMessageDto
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "ChatMessage";
        
        public static ChatMessageBlockDto Block(List<MessageSectionElementDto> sections, MessageStyle? style = null, MessageOutlineDto? outline = null, string? messageData = null)
            => new ChatMessageBlockDto(sections: sections, style: null, outline: null, messageData: null);
        
        public static ChatMessageTextDto Text(string text)
            => new ChatMessageTextDto(text: text);
        
        public ChatMessageDto() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
