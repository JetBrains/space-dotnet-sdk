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

namespace JetBrains.Space.Client.CustomFieldValueDataPartialBuilder;

public static class CustomFieldValueDataPartialExtensions
{
    public static Partial<CustomFieldValueData> WithCustomField(this Partial<CustomFieldValueData> it)
        => it.AddFieldName("customField");
    
    public static Partial<CustomFieldValueData> WithCustomField(this Partial<CustomFieldValueData> it, Func<Partial<CustomFieldData>, Partial<CustomFieldData>> partialBuilder)
        => it.AddFieldName("customField", partialBuilder(new Partial<CustomFieldData>(it)));
    
    public static Partial<CustomFieldValueData> WithValue(this Partial<CustomFieldValueData> it)
        => it.AddFieldName("value");
    
    public static Partial<CustomFieldValueData> WithValue(this Partial<CustomFieldValueData> it, Func<Partial<CFValue>, Partial<CFValue>> partialBuilder)
        => it.AddFieldName("value", partialBuilder(new Partial<CFValue>(it)));
    
}

