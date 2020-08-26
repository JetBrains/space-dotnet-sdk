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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.RecurrenceRuleFreqMonthlyOnFirstWeekdayDtoPartialBuilder
{
    public static class RecurrenceRuleFreqMonthlyOnFirstWeekdayDtoPartialExtensions
    {
        public static Partial<RecurrenceRuleFreqMonthlyOnFirstWeekdayDto> WithWeekday(this Partial<RecurrenceRuleFreqMonthlyOnFirstWeekdayDto> it)
            => it.AddFieldName("weekday");
        
        public static Partial<RecurrenceRuleFreqMonthlyOnFirstWeekdayDto> WithWeekday(this Partial<RecurrenceRuleFreqMonthlyOnFirstWeekdayDto> it, Func<Partial<Weekday>, Partial<Weekday>> partialBuilder)
            => it.AddFieldName("weekday", partialBuilder(new Partial<Weekday>(it)));
        
        public static Partial<RecurrenceRuleFreqMonthlyOnFirstWeekdayDto> WithShift(this Partial<RecurrenceRuleFreqMonthlyOnFirstWeekdayDto> it)
            => it.AddFieldName("shift");
        
        public static Partial<RecurrenceRuleFreqMonthlyOnFirstWeekdayDto> WithInterval(this Partial<RecurrenceRuleFreqMonthlyOnFirstWeekdayDto> it)
            => it.AddFieldName("interval");
        
    }
    
}
