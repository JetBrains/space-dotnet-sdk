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

namespace SpaceDotNet.Client.JobSubscriptionDtoPartialBuilder
{
    public static class JobSubscriptionDtoPartialExtensions
    {
        public static Partial<JobSubscriptionDto> WithId(this Partial<JobSubscriptionDto> it)
            => it.AddFieldName("id");
        
        public static Partial<JobSubscriptionDto> WithJobId(this Partial<JobSubscriptionDto> it)
            => it.AddFieldName("jobId");
        
        public static Partial<JobSubscriptionDto> WithProject(this Partial<JobSubscriptionDto> it)
            => it.AddFieldName("project");
        
        public static Partial<JobSubscriptionDto> WithProject(this Partial<JobSubscriptionDto> it, Func<Partial<PRProjectDto>, Partial<PRProjectDto>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProjectDto>(it)));
        
        public static Partial<JobSubscriptionDto> WithState(this Partial<JobSubscriptionDto> it)
            => it.AddFieldName("state");
        
        public static Partial<JobSubscriptionDto> WithState(this Partial<JobSubscriptionDto> it, Func<Partial<JobSubscriptionStateDto>, Partial<JobSubscriptionStateDto>> partialBuilder)
            => it.AddFieldName("state", partialBuilder(new Partial<JobSubscriptionStateDto>(it)));
        
        public static Partial<JobSubscriptionDto> WithArchived(this Partial<JobSubscriptionDto> it)
            => it.AddFieldName("archived");
        
    }
    
}