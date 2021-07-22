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

namespace JetBrains.Space.Client
{
    public interface IssueChangedM2Details
         : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static IssueAssigneeChangedDetails IssueAssigneeChangedDetails(TDMemberProfile? oldAssignee = null, TDMemberProfile? newAssignee = null)
            => new IssueAssigneeChangedDetails(oldAssignee: oldAssignee, newAssignee: newAssignee);
        
        public static IssueAttachmentsChangedDetails IssueAttachmentsChangedDetails(List<string>? addedNames = null, List<string>? removedNames = null)
            => new IssueAttachmentsChangedDetails(addedNames: addedNames, removedNames: removedNames);
        
        public static IssueChecklistsChangedDetails IssueChecklistsChangedDetails(List<Checklist>? addedChecklists = null, List<Checklist>? removedChecklists = null)
            => new IssueChecklistsChangedDetails(addedChecklists: addedChecklists, removedChecklists: removedChecklists);
        
        public static IssueCreatedDetails IssueCreatedDetails(Issue? issue = null, MessageLink? originMessage = null)
            => new IssueCreatedDetails(issue: issue, originMessage: originMessage);
        
        public static IssueDeletedDetails IssueDeletedDetails()
            => new IssueDeletedDetails();
        
        public static IssueDescriptionChangedDetails IssueDescriptionChangedDetails(string? oldDescription = null, string? newDescription = null)
            => new IssueDescriptionChangedDetails(oldDescription: oldDescription, newDescription: newDescription);
        
        public static IssueDueDateChangedDetails IssueDueDateChangedDetails(DateTime? oldDueDate = null, DateTime? newDueDate = null)
            => new IssueDueDateChangedDetails(oldDueDate: oldDueDate, newDueDate: newDueDate);
        
        public static IssueMCExtension IssueMCExtension()
            => new IssueMCExtension();
        
        public static IssueStatusChangedDetails IssueStatusChangedDetails(IssueStatus oldStatus, IssueStatus newStatus)
            => new IssueStatusChangedDetails(oldStatus: oldStatus, newStatus: newStatus);
        
        public static IssueTagsChangedDetails IssueTagsChangedDetails(List<PlanningTag>? addedTags = null, List<PlanningTag>? removedTags = null)
            => new IssueTagsChangedDetails(addedTags: addedTags, removedTags: removedTags);
        
        public static IssueTitleChangedDetails IssueTitleChangedDetails(string oldTitle, string newTitle)
            => new IssueTitleChangedDetails(oldTitle: oldTitle, newTitle: newTitle);
        
    }
    
}
