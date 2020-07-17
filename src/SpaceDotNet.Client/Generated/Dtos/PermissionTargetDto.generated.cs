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

namespace SpaceDotNet.Client
{
    public interface PermissionTargetDto
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static GlobalPermissionTargetDto Global()
            => new GlobalPermissionTargetDto();
        
        public static ProfilePermissionTargetDto Profile(ProfileIdentifier profile)
            => new ProfilePermissionTargetDto(profile: profile);
        
        public static ProjectPermissionTargetDto Project(ProjectIdentifier project)
            => new ProjectPermissionTargetDto(project: project);
        
        public static TeamPermissionTargetDto Team(string team)
            => new TeamPermissionTargetDto(team: team);
        
    }
    
}