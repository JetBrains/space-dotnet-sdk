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

namespace SpaceDotNet.Client.AbsencesSubscriptionsPostRequestPartialBuilder
{
    public static class AbsencesSubscriptionsPostRequestPartialExtensions
    {
        public static Partial<AbsencesSubscriptionsPostRequest> WithLocationId(this Partial<AbsencesSubscriptionsPostRequest> it)
            => it.AddFieldName("locationId");
        
        public static Partial<AbsencesSubscriptionsPostRequest> WithTeamId(this Partial<AbsencesSubscriptionsPostRequest> it)
            => it.AddFieldName("teamId");
        
        public static Partial<AbsencesSubscriptionsPostRequest> WithReasonId(this Partial<AbsencesSubscriptionsPostRequest> it)
            => it.AddFieldName("reasonId");
        
    }
    
}
