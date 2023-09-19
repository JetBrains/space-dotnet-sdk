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

[JsonConverter(typeof(EnumStringConverter))]
public enum StarredItemKind
{
    [EnumMember(Value = "Unknown")]
    Unknown,
    
    [EnumMember(Value = "Profile")]
    Profile,
    
    [EnumMember(Value = "Team")]
    Team,
    
    [EnumMember(Value = "Location")]
    Location,
    
    [EnumMember(Value = "Project")]
    Project,
    
    [EnumMember(Value = "Article")]
    Article,
    
    [EnumMember(Value = "CodeDiscussion")]
    CodeDiscussion,
    
    [EnumMember(Value = "CodeReview")]
    CodeReview,
    
    [EnumMember(Value = "PackageRepository")]
    PackageRepository,
    
    [EnumMember(Value = "Checklist")]
    Checklist,
    
    [EnumMember(Value = "KbBook")]
    KbBook,
    
    [EnumMember(Value = "KbFolder")]
    KbFolder,
    
    [EnumMember(Value = "KbArticle")]
    KbArticle,
    
    [EnumMember(Value = "PlanningIssueTracker")]
    PlanningIssueTracker,
    
    [EnumMember(Value = "PlanningIssueBoard")]
    PlanningIssueBoard,
    
    [EnumMember(Value = "CodeRepository")]
    CodeRepository,
    
    [EnumMember(Value = "AutomationJob")]
    AutomationJob,
    
    [EnumMember(Value = "HostingSite")]
    HostingSite,
    
    [EnumMember(Value = "DocumentSubscription")]
    DocumentSubscription,
    
    [EnumMember(Value = "DocumentFolderSubscription")]
    DocumentFolderSubscription,
    
    [EnumMember(Value = "DocumentBookSubscription")]
    DocumentBookSubscription,
    
    [EnumMember(Value = "Document")]
    Document,
    
    [EnumMember(Value = "DocumentFolder")]
    DocumentFolder,
    
    [EnumMember(Value = "Topic")]
    Topic,
    
    [EnumMember(Value = "ApplicationSubscription")]
    ApplicationSubscription,
    
    [EnumMember(Value = "DeployTarget")]
    DeployTarget,
    
}

