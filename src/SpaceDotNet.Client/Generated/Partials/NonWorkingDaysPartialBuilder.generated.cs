// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.NonWorkingDaysPartialBuilder
{
    public static class NonWorkingDaysPartialExtensions
    {
        public static Partial<NonWorkingDays> WithSince(this Partial<NonWorkingDays> it)
            => it.AddFieldName("since");
        
        public static Partial<NonWorkingDays> WithTill(this Partial<NonWorkingDays> it)
            => it.AddFieldName("till");
        
        public static Partial<NonWorkingDays> WithIsStartsEarlier(this Partial<NonWorkingDays> it)
            => it.AddFieldName("startsEarlier");
        
        public static Partial<NonWorkingDays> WithIsEndsLater(this Partial<NonWorkingDays> it)
            => it.AddFieldName("endsLater");
        
    }
    
}
