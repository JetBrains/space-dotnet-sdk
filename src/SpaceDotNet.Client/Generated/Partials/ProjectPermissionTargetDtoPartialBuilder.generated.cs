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

namespace SpaceDotNet.Client.ProjectPermissionTargetDtoPartialBuilder
{
    public static class ProjectPermissionTargetDtoPartialExtensions
    {
        public static Partial<ProjectPermissionTargetDto> WithProject(this Partial<ProjectPermissionTargetDto> it)
            => it.AddFieldName("project");
        
        public static Partial<ProjectPermissionTargetDto> WithProject(this Partial<ProjectPermissionTargetDto> it, Func<Partial<ProjectIdentifier>, Partial<ProjectIdentifier>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<ProjectIdentifier>(it)));
        
    }
    
}