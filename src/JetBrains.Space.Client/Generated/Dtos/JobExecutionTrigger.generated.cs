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

namespace JetBrains.Space.Client;

[JsonConverter(typeof(ClassNameDtoTypeConverter))]
public class JobExecutionTrigger
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "JobExecutionTrigger";
    
    public static JobExecutionTriggerCodeReviewClosed CodeReviewClosed(string reviewId)
        => new JobExecutionTriggerCodeReviewClosed(reviewId: reviewId);
    
    public static JobExecutionTriggerCodeReviewOpened CodeReviewOpened(string reviewId)
        => new JobExecutionTriggerCodeReviewOpened(reviewId: reviewId);
    
    public static JobExecutionTriggerGitBranchDeleted GitBranchDeleted(List<string> branches)
        => new JobExecutionTriggerGitBranchDeleted(branches: branches);
    
    public static JobExecutionTriggerGitPush GitPush(string commit)
        => new JobExecutionTriggerGitPush(commit: commit);
    
    public static JobExecutionTriggerManual Manual(CPrincipal principal)
        => new JobExecutionTriggerManual(principal: principal);
    
    public static JobExecutionTriggerSafeMerge SafeMerge(CPrincipal principal)
        => new JobExecutionTriggerSafeMerge(principal: principal);
    
    public static JobExecutionTriggerSchedule Schedule()
        => new JobExecutionTriggerSchedule();
    
    public JobExecutionTrigger() { }
    
    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

