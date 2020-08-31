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

namespace SpaceDotNet.Client.TDWorkingDaysPartialBuilder
{
    public static class TDWorkingDaysPartialExtensions
    {
        public static Partial<TDWorkingDays> WithId(this Partial<TDWorkingDays> it)
            => it.AddFieldName("id");
        
        public static Partial<TDWorkingDays> WithDateStart(this Partial<TDWorkingDays> it)
            => it.AddFieldName("dateStart");
        
        public static Partial<TDWorkingDays> WithDateEnd(this Partial<TDWorkingDays> it)
            => it.AddFieldName("dateEnd");
        
        public static Partial<TDWorkingDays> WithWorkingDaysSpec(this Partial<TDWorkingDays> it)
            => it.AddFieldName("workingDaysSpec");
        
        public static Partial<TDWorkingDays> WithWorkingDaysSpec(this Partial<TDWorkingDays> it, Func<Partial<WorkingDaysSpec>, Partial<WorkingDaysSpec>> partialBuilder)
            => it.AddFieldName("workingDaysSpec", partialBuilder(new Partial<WorkingDaysSpec>(it)));
        
    }
    
}
