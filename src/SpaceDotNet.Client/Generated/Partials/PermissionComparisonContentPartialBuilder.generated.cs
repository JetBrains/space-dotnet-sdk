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

namespace SpaceDotNet.Client.PermissionComparisonContentPartialBuilder
{
    public static class PermissionComparisonContentPartialExtensions
    {
        public static Partial<PermissionComparisonContent> WithEntries(this Partial<PermissionComparisonContent> it)
            => it.AddFieldName("entries");
        
        public static Partial<PermissionComparisonContent> WithEntries(this Partial<PermissionComparisonContent> it, Func<Partial<PermissionComparisonEntry>, Partial<PermissionComparisonEntry>> partialBuilder)
            => it.AddFieldName("entries", partialBuilder(new Partial<PermissionComparisonEntry>(it)));
        
        public static Partial<PermissionComparisonContent> WithPrincipals(this Partial<PermissionComparisonContent> it)
            => it.AddFieldName("principals");
        
        public static Partial<PermissionComparisonContent> WithPrincipals(this Partial<PermissionComparisonContent> it, Func<Partial<PermissionSnapshotPrincipal>, Partial<PermissionSnapshotPrincipal>> partialBuilder)
            => it.AddFieldName("principals", partialBuilder(new Partial<PermissionSnapshotPrincipal>(it)));
        
        public static Partial<PermissionComparisonContent> WithRights(this Partial<PermissionComparisonContent> it)
            => it.AddFieldName("rights");
        
        public static Partial<PermissionComparisonContent> WithRights(this Partial<PermissionComparisonContent> it, Func<Partial<PermissionSnapshotRight>, Partial<PermissionSnapshotRight>> partialBuilder)
            => it.AddFieldName("rights", partialBuilder(new Partial<PermissionSnapshotRight>(it)));
        
        public static Partial<PermissionComparisonContent> WithTargets(this Partial<PermissionComparisonContent> it)
            => it.AddFieldName("targets");
        
        public static Partial<PermissionComparisonContent> WithTargets(this Partial<PermissionComparisonContent> it, Func<Partial<PermissionSnapshotTarget>, Partial<PermissionSnapshotTarget>> partialBuilder)
            => it.AddFieldName("targets", partialBuilder(new Partial<PermissionSnapshotTarget>(it)));
        
    }
    
}
