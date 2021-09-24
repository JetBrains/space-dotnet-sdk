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
    [JsonConverter(typeof(UrlParameterConverter))]
    public abstract class CFEntityTypeIdentifier : IUrlParameter
    {
        public static CFEntityTypeIdentifier CFAbsenceEntityType
            => new CFAbsenceEntityType();
        
        public static CFEntityTypeIdentifier CFIssueTrackerEntityType(IssueTrackerIdentifier issueTracker)
            => new CFIssueTrackerEntityType(issueTracker);
        
        public static CFEntityTypeIdentifier CFMembershipEntityType
            => new CFMembershipEntityType();
        
        public static CFEntityTypeIdentifier CFProfileEntityType
            => new CFProfileEntityType();
        
        public static CFEntityTypeIdentifier CFTeamEntityType
            => new CFTeamEntityType();
        
        private class CFAbsenceEntityType : CFEntityTypeIdentifier
        {
            public override string ToString()
                => "absence";
        }
        
        private class CFIssueTrackerEntityType : CFEntityTypeIdentifier
        {
            private readonly IssueTrackerIdentifier _issueTracker;
            
            public CFIssueTrackerEntityType(IssueTrackerIdentifier issueTracker)
            {
                _issueTracker = issueTracker;
            }
            
            public override string ToString()
                => $"issueTracker:{_issueTracker}";
        }
        
        private class CFMembershipEntityType : CFEntityTypeIdentifier
        {
            public override string ToString()
                => "membership";
        }
        
        private class CFProfileEntityType : CFEntityTypeIdentifier
        {
            public override string ToString()
                => "profile";
        }
        
        private class CFTeamEntityType : CFEntityTypeIdentifier
        {
            public override string ToString()
                => "team";
        }
        
    }
    
}
