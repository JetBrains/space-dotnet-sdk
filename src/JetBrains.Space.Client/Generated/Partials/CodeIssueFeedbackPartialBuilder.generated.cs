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

namespace JetBrains.Space.Client.CodeIssueFeedbackPartialBuilder;

public static class CodeIssueFeedbackPartialExtensions
{
    public static Partial<CodeIssueFeedback> WithAnchor(this Partial<CodeIssueFeedback> it)
        => it.AddFieldName("anchor");
    
    public static Partial<CodeIssueFeedback> WithAnchor(this Partial<CodeIssueFeedback> it, Func<Partial<MergeRequestCodeIssueAnchor>, Partial<MergeRequestCodeIssueAnchor>> partialBuilder)
        => it.AddFieldName("anchor", partialBuilder(new Partial<MergeRequestCodeIssueAnchor>(it)));
    
    public static Partial<CodeIssueFeedback> WithMessage(this Partial<CodeIssueFeedback> it)
        => it.AddFieldName("message");
    
    public static Partial<CodeIssueFeedback> WithRuleId(this Partial<CodeIssueFeedback> it)
        => it.AddFieldName("ruleId");
    
    public static Partial<CodeIssueFeedback> WithCodeSnippet(this Partial<CodeIssueFeedback> it)
        => it.AddFieldName("codeSnippet");
    
    public static Partial<CodeIssueFeedback> WithIsDismissed(this Partial<CodeIssueFeedback> it)
        => it.AddFieldName("dismissed");
    
    public static Partial<CodeIssueFeedback> WithUpvotesCount(this Partial<CodeIssueFeedback> it)
        => it.AddFieldName("upvotesCount");
    
}

