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

namespace JetBrains.Space.Client.FollowedColleagueSettingsDTOPartialBuilder;

public static class FollowedColleagueSettingsDTOPartialExtensions
{
    public static Partial<FollowedColleagueSettingsDTO> WithFollowedMembers(this Partial<FollowedColleagueSettingsDTO> it)
        => it.AddFieldName("followedMembers");
    
    public static Partial<FollowedColleagueSettingsDTO> WithFollowedMembers(this Partial<FollowedColleagueSettingsDTO> it, Func<Partial<FollowedMembersSettings>, Partial<FollowedMembersSettings>> partialBuilder)
        => it.AddFieldName("followedMembers", partialBuilder(new Partial<FollowedMembersSettings>(it)));
    
    public static Partial<FollowedColleagueSettingsDTO> WithProjectAndTeams(this Partial<FollowedColleagueSettingsDTO> it)
        => it.AddFieldName("projectAndTeams");
    
    public static Partial<FollowedColleagueSettingsDTO> WithProjectAndTeams(this Partial<FollowedColleagueSettingsDTO> it, Func<Partial<FollowedEntityDTO>, Partial<FollowedEntityDTO>> partialBuilder)
        => it.AddFieldName("projectAndTeams", partialBuilder(new Partial<FollowedEntityDTO>(it)));
    
}

