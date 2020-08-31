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

namespace SpaceDotNet.Client.ReviewerChangedEventPartialBuilder
{
    public static class ReviewerChangedEventPartialExtensions
    {
        public static Partial<ReviewerChangedEvent> WithUid(this Partial<ReviewerChangedEvent> it)
            => it.AddFieldName("uid");
        
        public static Partial<ReviewerChangedEvent> WithUid(this Partial<ReviewerChangedEvent> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("uid", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<ReviewerChangedEvent> WithChangeType(this Partial<ReviewerChangedEvent> it)
            => it.AddFieldName("changeType");
        
        public static Partial<ReviewerChangedEvent> WithChangeType(this Partial<ReviewerChangedEvent> it, Func<Partial<ReviewerChangedType>, Partial<ReviewerChangedType>> partialBuilder)
            => it.AddFieldName("changeType", partialBuilder(new Partial<ReviewerChangedType>(it)));
        
    }
    
}
