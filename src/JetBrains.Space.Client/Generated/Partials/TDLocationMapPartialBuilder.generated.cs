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

namespace JetBrains.Space.Client.TDLocationMapPartialBuilder
{
    public static class TDLocationMapPartialExtensions
    {
        public static Partial<TDLocationMap> WithId(this Partial<TDLocationMap> it)
            => it.AddFieldName("id");
        
        public static Partial<TDLocationMap> WithPicture(this Partial<TDLocationMap> it)
            => it.AddFieldName("picture");
        
        public static Partial<TDLocationMap> WithCreated(this Partial<TDLocationMap> it)
            => it.AddFieldName("created");
        
        public static Partial<TDLocationMap> WithWidth(this Partial<TDLocationMap> it)
            => it.AddFieldName("width");
        
        public static Partial<TDLocationMap> WithHeight(this Partial<TDLocationMap> it)
            => it.AddFieldName("height");
        
    }
    
}
