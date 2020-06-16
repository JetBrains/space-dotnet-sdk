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

namespace SpaceDotNet.Client.MessageIconDtoExtensions
{
    public static class MessageIconDtoPartialExtensions
    {
        public static Partial<MessageIconDto> WithIcon(this Partial<MessageIconDto> it)
            => it.AddFieldName("icon");
        
        public static Partial<MessageIconDto> WithStyle(this Partial<MessageIconDto> it)
            => it.AddFieldName("style");
        
        public static Partial<MessageIconDto> WithStyle(this Partial<MessageIconDto> it, Func<Partial<MessageStyle>, Partial<MessageStyle>> partialBuilder)
            => it.AddFieldName("style", partialBuilder(new Partial<MessageStyle>(it)));
        
    }
    
}