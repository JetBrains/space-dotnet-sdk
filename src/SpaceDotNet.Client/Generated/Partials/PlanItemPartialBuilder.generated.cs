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

namespace SpaceDotNet.Client.PlanItemPartialBuilder
{
    public static class PlanItemPartialExtensions
    {
        public static Partial<PlanItem> WithId(this Partial<PlanItem> it)
            => it.AddFieldName("id");
        
        public static Partial<PlanItem> WithChecklistId(this Partial<PlanItem> it)
            => it.AddFieldName("checklistId");
        
        public static Partial<PlanItem> WithTag(this Partial<PlanItem> it)
            => it.AddFieldName("tag");
        
        public static Partial<PlanItem> WithTag(this Partial<PlanItem> it, Func<Partial<PlanningTag>, Partial<PlanningTag>> partialBuilder)
            => it.AddFieldName("tag", partialBuilder(new Partial<PlanningTag>(it)));
        
        public static Partial<PlanItem> WithSimpleText(this Partial<PlanItem> it)
            => it.AddFieldName("simpleText");
        
        public static Partial<PlanItem> WithIsSimpleDone(this Partial<PlanItem> it)
            => it.AddFieldName("simpleDone");
        
        public static Partial<PlanItem> WithIssue(this Partial<PlanItem> it)
            => it.AddFieldName("issue");
        
        public static Partial<PlanItem> WithIssue(this Partial<PlanItem> it, Func<Partial<Issue>, Partial<Issue>> partialBuilder)
            => it.AddFieldName("issue", partialBuilder(new Partial<Issue>(it)));
        
        public static Partial<PlanItem> WithIssueProblem(this Partial<PlanItem> it)
            => it.AddFieldName("issueProblem");
        
        public static Partial<PlanItem> WithIsCanEditIssue(this Partial<PlanItem> it)
            => it.AddFieldName("canEditIssue");
        
        public static Partial<PlanItem> WithIsHasChildren(this Partial<PlanItem> it)
            => it.AddFieldName("hasChildren");
        
        public static Partial<PlanItem> WithChildren(this Partial<PlanItem> it)
            => it.AddFieldName("children");
        
        public static Partial<PlanItem> WithChildrenRecursive(this Partial<PlanItem> it)
            => it.AddFieldName("children!");
        
        public static Partial<PlanItem> WithChildren(this Partial<PlanItem> it, Func<Partial<PlanItem>, Partial<PlanItem>> partialBuilder)
            => it.AddFieldName("children", partialBuilder(new Partial<PlanItem>(it)));
        
    }
    
}
