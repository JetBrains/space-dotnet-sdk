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

namespace JetBrains.Space.Client.TeamDirectoryTeamsForIdPatchRequestPartialBuilder
{
    public static class TeamDirectoryTeamsForIdPatchRequestPartialExtensions
    {
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithName(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithDescription(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithEmails(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("emails");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithParentId(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("parentId");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithDefaultManager(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("defaultManager");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithCustomFieldValues(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithCustomFieldValues(this Partial<TeamDirectoryTeamsForIdPatchRequest> it, Func<Partial<CustomFieldInputValue>, Partial<CustomFieldInputValue>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldInputValue>(it)));
        
        public static Partial<TeamDirectoryTeamsForIdPatchRequest> WithExternalId(this Partial<TeamDirectoryTeamsForIdPatchRequest> it)
            => it.AddFieldName("externalId");
        
    }
    
}
