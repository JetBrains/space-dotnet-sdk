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

namespace JetBrains.Space.Client.DevConfigurationParticipantDTOUserPartialBuilder;

public static class DevConfigurationParticipantDTOUserPartialExtensions
{
    public static Partial<DevConfigurationParticipantDTOUser> WithRef(this Partial<DevConfigurationParticipantDTOUser> it)
        => it.AddFieldName("ref");
    
    public static Partial<DevConfigurationParticipantDTOUser> WithRef(this Partial<DevConfigurationParticipantDTOUser> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("ref", partialBuilder(new Partial<TDMemberProfile>(it)));
    
}
