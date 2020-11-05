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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.HATypeUrlParamPartialBuilder
{
    public static class HATypeUrlParamPartialExtensions
    {
        public static Partial<HATypeUrlParam> WithUrlParam(this Partial<HATypeUrlParam> it)
            => it.AddFieldName("urlParam");
        
        public static Partial<HATypeUrlParam> WithUrlParam(this Partial<HATypeUrlParam> it, Func<Partial<HAUrlParameter>, Partial<HAUrlParameter>> partialBuilder)
            => it.AddFieldName("urlParam", partialBuilder(new Partial<HAUrlParameter>(it)));
        
        public static Partial<HATypeUrlParam> WithIsNullable(this Partial<HATypeUrlParam> it)
            => it.AddFieldName("nullable");
        
    }
    
}