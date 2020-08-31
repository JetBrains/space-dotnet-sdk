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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public class ChatChannel
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "ChatChannel";
        
        public static ChatChannelFromId FromId(string id)
            => new ChatChannelFromId(id: id);
        
        public static ChatChannelFromName FromName(string name)
            => new ChatChannelFromName(name: name);
        
        public ChatChannel() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
