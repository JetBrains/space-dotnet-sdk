// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.UpdateHolidayRequestExtensions
{
    public static class UpdateHolidayRequestPartialExtensions
    {
        public static Partial<UpdateHolidayRequest> WithCalendar(this Partial<UpdateHolidayRequest> it)    => it.AddFieldName("calendar");
        
        public static Partial<UpdateHolidayRequest> WithName(this Partial<UpdateHolidayRequest> it)    => it.AddFieldName("name");
        
        public static Partial<UpdateHolidayRequest> WithDate(this Partial<UpdateHolidayRequest> it)    => it.AddFieldName("date");
        
        public static Partial<UpdateHolidayRequest> WithWorkingDay(this Partial<UpdateHolidayRequest> it)    => it.AddFieldName("workingDay");
        
    }
    
}