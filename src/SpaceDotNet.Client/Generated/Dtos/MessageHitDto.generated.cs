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
    public class MessageHitDto
         : EntityHitDto, IClassNameConvertible
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("score")]
        public double Score { get; set; }        
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecordDto Channel { get; set; }        
        
        [Required]
        [JsonPropertyName("ref")]
        public ChannelItemRecordDto Ref { get; set; }        
        
        [Required]
        [JsonPropertyName("message")]
        public string Message { get; set; }        
        
    }
    
}
