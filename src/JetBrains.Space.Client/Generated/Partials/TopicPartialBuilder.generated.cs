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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.TopicPartialBuilder
{
    public static class TopicPartialExtensions
    {
        public static Partial<Topic> WithId(this Partial<Topic> it)
            => it.AddFieldName("id");
        
        public static Partial<Topic> WithIsArchived(this Partial<Topic> it)
            => it.AddFieldName("archived");
        
        public static Partial<Topic> WithName(this Partial<Topic> it)
            => it.AddFieldName("name");
        
        public static Partial<Topic> WithParent(this Partial<Topic> it)
            => it.AddFieldName("parent");
        
        public static Partial<Topic> WithParentRecursive(this Partial<Topic> it)
            => it.AddFieldName("parent!");
        
        public static Partial<Topic> WithParent(this Partial<Topic> it, Func<Partial<Topic>, Partial<Topic>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<Topic>(it)));
        
        public static Partial<Topic> WithResponsible(this Partial<Topic> it)
            => it.AddFieldName("responsible");
        
        public static Partial<Topic> WithResponsible(this Partial<Topic> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("responsible", partialBuilder(new Partial<TDMemberProfile>(it)));
        
    }
    
}
