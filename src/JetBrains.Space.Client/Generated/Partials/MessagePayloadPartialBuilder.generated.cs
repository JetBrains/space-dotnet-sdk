// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.MessagePayloadPartialBuilder
{
    public static class MessagePayloadPartialExtensions
    {
        public static Partial<MessagePayload> WithMessage(this Partial<MessagePayload> it)
            => it.AddFieldName("message");
        
        public static Partial<MessagePayload> WithMessage(this Partial<MessagePayload> it, Func<Partial<MessageContext>, Partial<MessageContext>> partialBuilder)
            => it.AddFieldName("message", partialBuilder(new Partial<MessageContext>(it)));
        
        public static Partial<MessagePayload> WithAccessToken(this Partial<MessagePayload> it)
            => it.AddFieldName("accessToken");
        
        public static Partial<MessagePayload> WithVerificationToken(this Partial<MessagePayload> it)
            => it.AddFieldName("verificationToken");
        
        public static Partial<MessagePayload> WithUserId(this Partial<MessagePayload> it)
            => it.AddFieldName("userId");
        
        public static Partial<MessagePayload> WithServerUrl(this Partial<MessagePayload> it)
            => it.AddFieldName("serverUrl");
        
    }
    
}
