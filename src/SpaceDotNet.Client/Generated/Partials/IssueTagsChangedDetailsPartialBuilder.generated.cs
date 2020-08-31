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

namespace SpaceDotNet.Client.IssueTagsChangedDetailsPartialBuilder
{
    public static class IssueTagsChangedDetailsPartialExtensions
    {
        public static Partial<IssueTagsChangedDetails> WithAddedTags(this Partial<IssueTagsChangedDetails> it)
            => it.AddFieldName("addedTags");
        
        public static Partial<IssueTagsChangedDetails> WithAddedTags(this Partial<IssueTagsChangedDetails> it, Func<Partial<PlanningTag>, Partial<PlanningTag>> partialBuilder)
            => it.AddFieldName("addedTags", partialBuilder(new Partial<PlanningTag>(it)));
        
        public static Partial<IssueTagsChangedDetails> WithRemovedTags(this Partial<IssueTagsChangedDetails> it)
            => it.AddFieldName("removedTags");
        
        public static Partial<IssueTagsChangedDetails> WithRemovedTags(this Partial<IssueTagsChangedDetails> it, Func<Partial<PlanningTag>, Partial<PlanningTag>> partialBuilder)
            => it.AddFieldName("removedTags", partialBuilder(new Partial<PlanningTag>(it)));
        
    }
    
}
