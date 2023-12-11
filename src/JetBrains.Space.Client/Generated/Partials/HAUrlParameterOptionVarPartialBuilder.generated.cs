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

namespace JetBrains.Space.Client.HAUrlParameterOptionVarPartialBuilder;

public static class HAUrlParameterOptionVarPartialExtensions
{
    [Obsolete("Use 'parameters' (since 2021-08-17)")]
    public static Partial<HAUrlParameterOptionVar> WithParameter(this Partial<HAUrlParameterOptionVar> it)
        => it.AddFieldName("parameter");
    
    [Obsolete("Use 'parameters' (since 2021-08-17)")]
    public static Partial<HAUrlParameterOptionVar> WithParameter(this Partial<HAUrlParameterOptionVar> it, Func<Partial<HAField>, Partial<HAField>> partialBuilder)
        => it.AddFieldName("parameter", partialBuilder(new Partial<HAField>(it)));
    
    public static Partial<HAUrlParameterOptionVar> WithParameters(this Partial<HAUrlParameterOptionVar> it)
        => it.AddFieldName("parameters");
    
    public static Partial<HAUrlParameterOptionVar> WithParameters(this Partial<HAUrlParameterOptionVar> it, Func<Partial<HAField>, Partial<HAField>> partialBuilder)
        => it.AddFieldName("parameters", partialBuilder(new Partial<HAField>(it)));
    
    public static Partial<HAUrlParameterOptionVar> WithIsPrefixRequired(this Partial<HAUrlParameterOptionVar> it)
        => it.AddFieldName("prefixRequired");
    
    public static Partial<HAUrlParameterOptionVar> WithOptionName(this Partial<HAUrlParameterOptionVar> it)
        => it.AddFieldName("optionName");
    
    public static Partial<HAUrlParameterOptionVar> WithDescription(this Partial<HAUrlParameterOptionVar> it)
        => it.AddFieldName("description");
    
    public static Partial<HAUrlParameterOptionVar> WithDescription(this Partial<HAUrlParameterOptionVar> it, Func<Partial<HADescription>, Partial<HADescription>> partialBuilder)
        => it.AddFieldName("description", partialBuilder(new Partial<HADescription>(it)));
    
    public static Partial<HAUrlParameterOptionVar> WithDeprecation(this Partial<HAUrlParameterOptionVar> it)
        => it.AddFieldName("deprecation");
    
    public static Partial<HAUrlParameterOptionVar> WithDeprecation(this Partial<HAUrlParameterOptionVar> it, Func<Partial<HADeprecation>, Partial<HADeprecation>> partialBuilder)
        => it.AddFieldName("deprecation", partialBuilder(new Partial<HADeprecation>(it)));
    
    public static Partial<HAUrlParameterOptionVar> WithExperimental(this Partial<HAUrlParameterOptionVar> it)
        => it.AddFieldName("experimental");
    
    public static Partial<HAUrlParameterOptionVar> WithExperimental(this Partial<HAUrlParameterOptionVar> it, Func<Partial<HAExperimental>, Partial<HAExperimental>> partialBuilder)
        => it.AddFieldName("experimental", partialBuilder(new Partial<HAExperimental>(it)));
    
    public static Partial<HAUrlParameterOptionVar> WithFeatureFlag(this Partial<HAUrlParameterOptionVar> it)
        => it.AddFieldName("featureFlag");
    
    public static Partial<HAUrlParameterOptionVar> WithOptionalFeature(this Partial<HAUrlParameterOptionVar> it)
        => it.AddFieldName("optionalFeature");
    
}

