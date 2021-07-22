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

namespace JetBrains.Space.Client.TeamDirectoryLocationsForIdPatchRequestPartialBuilder
{
    public static class TeamDirectoryLocationsForIdPatchRequestPartialExtensions
    {
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithName(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithTimezone(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("timezone");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithIsCustomWorkdays(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("customWorkdays");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithWorkdays(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("workdays");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithPhones(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("phones");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithEmails(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("emails");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithEquipment(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("equipment");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithDescription(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithAddress(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("address");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithType(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("type");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithParentId(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("parentId");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithMapId(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("mapId");
        
        public static Partial<TeamDirectoryLocationsForIdPatchRequest> WithCapacity(this Partial<TeamDirectoryLocationsForIdPatchRequest> it)
            => it.AddFieldName("capacity");
        
    }
    
}
