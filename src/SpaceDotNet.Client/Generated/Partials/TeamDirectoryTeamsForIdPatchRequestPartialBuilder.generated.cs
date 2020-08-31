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

namespace SpaceDotNet.Client.TeamDirectoryTeamsForIdPatchRequestPartialBuilder
{
    public static class TeamDirectoryTeamsForIdPatchRequestPartialExtensions
    {
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithTeamNameRaw(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("teamNameRaw");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithTeamDescription(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("teamDescription");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithTeamEmails(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("teamEmails");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithParentId(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("parentId");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithCustomFieldValues(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithCustomFieldValues(this Partial<TeamDirectoryTeamsForIdPatchRequest> it, Func<Partial<CustomFieldValue>, Partial<CustomFieldValue>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldValue>(it)));
        
    }
    
}
