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

namespace JetBrains.Space.Client.HAUrlParameterPartialBuilder
{
    public static class HAUrlParameterPartialExtensions
    {
        public static Partial<HAUrlParameter> WithId(this Partial<HAUrlParameter> it)
            => it.AddFieldName("id");
        
        public static Partial<HAUrlParameter> WithName(this Partial<HAUrlParameter> it)
            => it.AddFieldName("name");
        
        public static Partial<HAUrlParameter> WithOptions(this Partial<HAUrlParameter> it)
            => it.AddFieldName("options");
        
        public static Partial<HAUrlParameter> WithOptions(this Partial<HAUrlParameter> it, Func<Partial<HAUrlParameterOption>, Partial<HAUrlParameterOption>> partialBuilder)
            => it.AddFieldName("options", partialBuilder(new Partial<HAUrlParameterOption>(it)));
        
        public static Partial<HAUrlParameter> WithDeprecation(this Partial<HAUrlParameter> it)
            => it.AddFieldName("deprecation");
        
        public static Partial<HAUrlParameter> WithDeprecation(this Partial<HAUrlParameter> it, Func<Partial<HADeprecation>, Partial<HADeprecation>> partialBuilder)
            => it.AddFieldName("deprecation", partialBuilder(new Partial<HADeprecation>(it)));
        
    }
    
}
