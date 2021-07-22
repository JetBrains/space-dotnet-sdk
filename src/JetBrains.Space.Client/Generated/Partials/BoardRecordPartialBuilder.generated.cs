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

namespace JetBrains.Space.Client.BoardRecordPartialBuilder
{
    public static class BoardRecordPartialExtensions
    {
        public static Partial<BoardRecord> WithId(this Partial<BoardRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<BoardRecord> WithIsArchived(this Partial<BoardRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<BoardRecord> WithName(this Partial<BoardRecord> it)
            => it.AddFieldName("name");
        
        public static Partial<BoardRecord> WithFrom(this Partial<BoardRecord> it)
            => it.AddFieldName("from");
        
        public static Partial<BoardRecord> WithInfo(this Partial<BoardRecord> it)
            => it.AddFieldName("info");
        
        public static Partial<BoardRecord> WithInfo(this Partial<BoardRecord> it, Func<Partial<BoardInfo>, Partial<BoardInfo>> partialBuilder)
            => it.AddFieldName("info", partialBuilder(new Partial<BoardInfo>(it)));
        
        public static Partial<BoardRecord> WithTo(this Partial<BoardRecord> it)
            => it.AddFieldName("to");
        
    }
    
}
