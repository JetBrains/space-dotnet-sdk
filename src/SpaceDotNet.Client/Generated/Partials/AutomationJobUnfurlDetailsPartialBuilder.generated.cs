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

namespace SpaceDotNet.Client.AutomationJobUnfurlDetailsPartialBuilder
{
    public static class AutomationJobUnfurlDetailsPartialExtensions
    {
        public static Partial<AutomationJobUnfurlDetails> WithJobId(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("jobId");
        
        public static Partial<AutomationJobUnfurlDetails> WithJobName(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("jobName");
        
        public static Partial<AutomationJobUnfurlDetails> WithProjectRef(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("projectRef");
        
        public static Partial<AutomationJobUnfurlDetails> WithProjectRef(this Partial<AutomationJobUnfurlDetails> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("projectRef", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<AutomationJobUnfurlDetails> WithRepoName(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("repoName");
        
        public static Partial<AutomationJobUnfurlDetails> WithJobExecutionDisplayStatusFilter(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("jobExecutionDisplayStatusFilter");
        
        public static Partial<AutomationJobUnfurlDetails> WithJobExecutionDisplayStatusFilter(this Partial<AutomationJobUnfurlDetails> it, Func<Partial<ExecutionDisplayStatus>, Partial<ExecutionDisplayStatus>> partialBuilder)
            => it.AddFieldName("jobExecutionDisplayStatusFilter", partialBuilder(new Partial<ExecutionDisplayStatus>(it)));
        
        public static Partial<AutomationJobUnfurlDetails> WithJobTriggerFilter(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("jobTriggerFilter");
        
        public static Partial<AutomationJobUnfurlDetails> WithJobTriggerFilter(this Partial<AutomationJobUnfurlDetails> it, Func<Partial<JobTriggerType>, Partial<JobTriggerType>> partialBuilder)
            => it.AddFieldName("jobTriggerFilter", partialBuilder(new Partial<JobTriggerType>(it)));
        
        public static Partial<AutomationJobUnfurlDetails> WithBranch(this Partial<AutomationJobUnfurlDetails> it)
            => it.AddFieldName("branch");
        
        public static Partial<AutomationJobUnfurlDetails> WithBranch(this Partial<AutomationJobUnfurlDetails> it, Func<Partial<Branch>, Partial<Branch>> partialBuilder)
            => it.AddFieldName("branch", partialBuilder(new Partial<Branch>(it)));
        
    }
    
}