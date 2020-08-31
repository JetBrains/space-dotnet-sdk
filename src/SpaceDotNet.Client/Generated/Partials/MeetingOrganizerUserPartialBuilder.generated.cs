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

namespace SpaceDotNet.Client.MeetingOrganizerUserPartialBuilder
{
    public static class MeetingOrganizerUserPartialExtensions
    {
        public static Partial<MeetingOrganizerUser> WithProfileRef(this Partial<MeetingOrganizerUser> it)
            => it.AddFieldName("profileRef");
        
        public static Partial<MeetingOrganizerUser> WithProfileRef(this Partial<MeetingOrganizerUser> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("profileRef", partialBuilder(new Partial<TDMemberProfile>(it)));
        
    }
    
}
