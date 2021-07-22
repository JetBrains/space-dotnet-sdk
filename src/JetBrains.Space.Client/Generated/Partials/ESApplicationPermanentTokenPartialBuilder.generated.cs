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

namespace JetBrains.Space.Client.ESApplicationPermanentTokenPartialBuilder
{
    public static class ESApplicationPermanentTokenPartialExtensions
    {
        public static Partial<ESApplicationPermanentToken> WithId(this Partial<ESApplicationPermanentToken> it)
            => it.AddFieldName("id");
        
        public static Partial<ESApplicationPermanentToken> WithName(this Partial<ESApplicationPermanentToken> it)
            => it.AddFieldName("name");
        
        public static Partial<ESApplicationPermanentToken> WithApplication(this Partial<ESApplicationPermanentToken> it)
            => it.AddFieldName("application");
        
        public static Partial<ESApplicationPermanentToken> WithApplication(this Partial<ESApplicationPermanentToken> it, Func<Partial<ESApp>, Partial<ESApp>> partialBuilder)
            => it.AddFieldName("application", partialBuilder(new Partial<ESApp>(it)));
        
        public static Partial<ESApplicationPermanentToken> WithScope(this Partial<ESApplicationPermanentToken> it)
            => it.AddFieldName("scope");
        
        public static Partial<ESApplicationPermanentToken> WithCreated(this Partial<ESApplicationPermanentToken> it)
            => it.AddFieldName("created");
        
        public static Partial<ESApplicationPermanentToken> WithExpires(this Partial<ESApplicationPermanentToken> it)
            => it.AddFieldName("expires");
        
        public static Partial<ESApplicationPermanentToken> WithLastAccess(this Partial<ESApplicationPermanentToken> it)
            => it.AddFieldName("lastAccess");
        
        public static Partial<ESApplicationPermanentToken> WithLastAccess(this Partial<ESApplicationPermanentToken> it, Func<Partial<AccessRecord>, Partial<AccessRecord>> partialBuilder)
            => it.AddFieldName("lastAccess", partialBuilder(new Partial<AccessRecord>(it)));
        
    }
    
}
