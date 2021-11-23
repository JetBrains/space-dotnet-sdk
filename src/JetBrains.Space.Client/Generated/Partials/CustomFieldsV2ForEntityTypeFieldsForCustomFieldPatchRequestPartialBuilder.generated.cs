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

namespace JetBrains.Space.Client.CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequestPartialBuilder;

public static class CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequestPartialExtensions
{
    public static Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> WithName(this Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> it)
        => it.AddFieldName("name");
    
    public static Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> WithParameters(this Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> it)
        => it.AddFieldName("parameters");
    
    public static Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> WithParameters(this Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> it, Func<Partial<CFUpdateParameters>, Partial<CFUpdateParameters>> partialBuilder)
        => it.AddFieldName("parameters", partialBuilder(new Partial<CFUpdateParameters>(it)));
    
    public static Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> WithIsRequired(this Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> it)
        => it.AddFieldName("required");
    
    public static Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> WithDefaultValue(this Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> it)
        => it.AddFieldName("defaultValue");
    
    public static Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> WithDefaultValue(this Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> it, Func<Partial<CFInputValue>, Partial<CFInputValue>> partialBuilder)
        => it.AddFieldName("defaultValue", partialBuilder(new Partial<CFInputValue>(it)));
    
    public static Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> WithConstraint(this Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> it)
        => it.AddFieldName("constraint");
    
    public static Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> WithConstraint(this Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> it, Func<Partial<CFConstraint>, Partial<CFConstraint>> partialBuilder)
        => it.AddFieldName("constraint", partialBuilder(new Partial<CFConstraint>(it)));
    
    public static Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> WithDescription(this Partial<CustomFieldsV2ForEntityTypeFieldsForCustomFieldPatchRequest> it)
        => it.AddFieldName("description");
    
}
