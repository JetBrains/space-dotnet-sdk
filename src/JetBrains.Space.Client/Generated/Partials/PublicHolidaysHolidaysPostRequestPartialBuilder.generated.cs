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

namespace JetBrains.Space.Client.PublicHolidaysHolidaysPostRequestPartialBuilder
{
    public static class PublicHolidaysHolidaysPostRequestPartialExtensions
    {
        public static Partial<PublicHolidaysHolidaysPostRequest> WithCalendar(this Partial<PublicHolidaysHolidaysPostRequest> it)
            => it.AddFieldName("calendar");
        
        public static Partial<PublicHolidaysHolidaysPostRequest> WithName(this Partial<PublicHolidaysHolidaysPostRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<PublicHolidaysHolidaysPostRequest> WithDate(this Partial<PublicHolidaysHolidaysPostRequest> it)
            => it.AddFieldName("date");
        
        public static Partial<PublicHolidaysHolidaysPostRequest> WithIsWorkingDay(this Partial<PublicHolidaysHolidaysPostRequest> it)
            => it.AddFieldName("workingDay");
        
        public static Partial<PublicHolidaysHolidaysPostRequest> WithIsHalfDay(this Partial<PublicHolidaysHolidaysPostRequest> it)
            => it.AddFieldName("halfDay");
        
    }
    
}
