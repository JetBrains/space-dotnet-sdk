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

namespace JetBrains.Space.Client.BoardInfoPartialBuilder
{
    public static class BoardInfoPartialExtensions
    {
        public static Partial<BoardInfo> WithOwners(this Partial<BoardInfo> it)
            => it.AddFieldName("owners");
        
        public static Partial<BoardInfo> WithOwners(this Partial<BoardInfo> it, Func<Partial<BoardOwners>, Partial<BoardOwners>> partialBuilder)
            => it.AddFieldName("owners", partialBuilder(new Partial<BoardOwners>(it)));
        
        public static Partial<BoardInfo> WithColumns(this Partial<BoardInfo> it)
            => it.AddFieldName("columns");
        
        public static Partial<BoardInfo> WithColumns(this Partial<BoardInfo> it, Func<Partial<BoardColumns>, Partial<BoardColumns>> partialBuilder)
            => it.AddFieldName("columns", partialBuilder(new Partial<BoardColumns>(it)));
        
        public static Partial<BoardInfo> WithDescription(this Partial<BoardInfo> it)
            => it.AddFieldName("description");
        
    }
    
}
