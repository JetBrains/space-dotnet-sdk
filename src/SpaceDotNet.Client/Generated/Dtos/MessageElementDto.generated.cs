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
    public interface MessageElementDto
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static MessageControlGroupDto MessageControlGroup(List<MessageControlElementDto> elements)
            => new MessageControlGroupDto(elements: elements);
        
        public static MessageDividerDto MessageDivider()
            => new MessageDividerDto();
        
        public static MessageFieldsDto MessageFields(List<MessageFieldElementDto> fields)
            => new MessageFieldsDto(fields: fields);
        
        public static MessageTextDto MessageText(string content, MessageAccessoryElementDto? accessory = null)
            => new MessageTextDto(content: content, accessory: null);
        
    }
    
}
