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

namespace JetBrains.Space.Client.CustomFieldDataPartialBuilder;

public static class CustomFieldDataPartialExtensions
{
    public static Partial<CustomFieldData> WithId(this Partial<CustomFieldData> it)
        => it.AddFieldName("id");
    
    public static Partial<CustomFieldData> WithName(this Partial<CustomFieldData> it)
        => it.AddFieldName("name");
    
    public static Partial<CustomFieldData> WithType(this Partial<CustomFieldData> it)
        => it.AddFieldName("type");
    
    public static Partial<CustomFieldData> WithType(this Partial<CustomFieldData> it, Func<Partial<CustomFieldType>, Partial<CustomFieldType>> partialBuilder)
        => it.AddFieldName("type", partialBuilder(new Partial<CustomFieldType>(it)));
    
    public static Partial<CustomFieldData> WithIsMultivalued(this Partial<CustomFieldData> it)
        => it.AddFieldName("multivalued");
    
    public static Partial<CustomFieldData> WithParameters(this Partial<CustomFieldData> it)
        => it.AddFieldName("parameters");
    
    public static Partial<CustomFieldData> WithParameters(this Partial<CustomFieldData> it, Func<Partial<CFParameters>, Partial<CFParameters>> partialBuilder)
        => it.AddFieldName("parameters", partialBuilder(new Partial<CFParameters>(it)));
    
    public static Partial<CustomFieldData> WithIsRequired(this Partial<CustomFieldData> it)
        => it.AddFieldName("required");
    
    public static Partial<CustomFieldData> WithDefaultValue(this Partial<CustomFieldData> it)
        => it.AddFieldName("defaultValue");
    
    public static Partial<CustomFieldData> WithDefaultValue(this Partial<CustomFieldData> it, Func<Partial<CFValue>, Partial<CFValue>> partialBuilder)
        => it.AddFieldName("defaultValue", partialBuilder(new Partial<CFValue>(it)));
    
    public static Partial<CustomFieldData> WithConstraint(this Partial<CustomFieldData> it)
        => it.AddFieldName("constraint");
    
    public static Partial<CustomFieldData> WithConstraint(this Partial<CustomFieldData> it, Func<Partial<CFConstraint>, Partial<CFConstraint>> partialBuilder)
        => it.AddFieldName("constraint", partialBuilder(new Partial<CFConstraint>(it)));
    
    public static Partial<CustomFieldData> WithDescription(this Partial<CustomFieldData> it)
        => it.AddFieldName("description");
    
    public static Partial<CustomFieldData> WithOrder(this Partial<CustomFieldData> it)
        => it.AddFieldName("order");
    
    public static Partial<CustomFieldData> WithIsArchived(this Partial<CustomFieldData> it)
        => it.AddFieldName("archived");
    
}

