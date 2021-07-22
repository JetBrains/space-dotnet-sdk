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

namespace JetBrains.Space.Client.CustomFieldPartialBuilder
{
    public static class CustomFieldPartialExtensions
    {
        public static Partial<CustomField> WithExtendedType(this Partial<CustomField> it)
            => it.AddFieldName("extendedType");
        
        public static Partial<CustomField> WithExtendedType(this Partial<CustomField> it, Func<Partial<ExtendedType>, Partial<ExtendedType>> partialBuilder)
            => it.AddFieldName("extendedType", partialBuilder(new Partial<ExtendedType>(it)));
        
        public static Partial<CustomField> WithId(this Partial<CustomField> it)
            => it.AddFieldName("id");
        
        public static Partial<CustomField> WithName(this Partial<CustomField> it)
            => it.AddFieldName("name");
        
        public static Partial<CustomField> WithDescription(this Partial<CustomField> it)
            => it.AddFieldName("description");
        
        public static Partial<CustomField> WithKey(this Partial<CustomField> it)
            => it.AddFieldName("key");
        
        public static Partial<CustomField> WithType(this Partial<CustomField> it)
            => it.AddFieldName("type");
        
        public static Partial<CustomField> WithType(this Partial<CustomField> it, Func<Partial<CFType>, Partial<CFType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<CFType>(it)));
        
        public static Partial<CustomField> WithConstraint(this Partial<CustomField> it)
            => it.AddFieldName("constraint");
        
        public static Partial<CustomField> WithConstraint(this Partial<CustomField> it, Func<Partial<CFConstraint>, Partial<CFConstraint>> partialBuilder)
            => it.AddFieldName("constraint", partialBuilder(new Partial<CFConstraint>(it)));
        
        public static Partial<CustomField> WithIsRequired(this Partial<CustomField> it)
            => it.AddFieldName("required");
        
        public static Partial<CustomField> WithIsPrivate(this Partial<CustomField> it)
            => it.AddFieldName("private");
        
        public static Partial<CustomField> WithAccess(this Partial<CustomField> it)
            => it.AddFieldName("access");
        
        public static Partial<CustomField> WithAccess(this Partial<CustomField> it, Func<Partial<AccessType>, Partial<AccessType>> partialBuilder)
            => it.AddFieldName("access", partialBuilder(new Partial<AccessType>(it)));
        
        public static Partial<CustomField> WithDefaultValue(this Partial<CustomField> it)
            => it.AddFieldName("defaultValue");
        
        public static Partial<CustomField> WithDefaultValue(this Partial<CustomField> it, Func<Partial<CFValue>, Partial<CFValue>> partialBuilder)
            => it.AddFieldName("defaultValue", partialBuilder(new Partial<CFValue>(it)));
        
        public static Partial<CustomField> WithOrder(this Partial<CustomField> it)
            => it.AddFieldName("order");
        
        public static Partial<CustomField> WithScope(this Partial<CustomField> it)
            => it.AddFieldName("scope");
        
        public static Partial<CustomField> WithScope(this Partial<CustomField> it, Func<Partial<ExtendedTypeScope>, Partial<ExtendedTypeScope>> partialBuilder)
            => it.AddFieldName("scope", partialBuilder(new Partial<ExtendedTypeScope>(it)));
        
        public static Partial<CustomField> WithIsDeleted(this Partial<CustomField> it)
            => it.AddFieldName("deleted");
        
        public static Partial<CustomField> WithParameters(this Partial<CustomField> it)
            => it.AddFieldName("parameters");
        
        public static Partial<CustomField> WithParameters(this Partial<CustomField> it, Func<Partial<CFParameters>, Partial<CFParameters>> partialBuilder)
            => it.AddFieldName("parameters", partialBuilder(new Partial<CFParameters>(it)));
        
        public static Partial<CustomField> WithIsArchived(this Partial<CustomField> it)
            => it.AddFieldName("archived");
        
    }
    
}
