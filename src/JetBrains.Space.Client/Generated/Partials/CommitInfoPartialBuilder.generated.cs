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

namespace JetBrains.Space.Client.CommitInfoPartialBuilder
{
    public static class CommitInfoPartialExtensions
    {
        public static Partial<CommitInfo> WithProject(this Partial<CommitInfo> it)
            => it.AddFieldName("project");
        
        public static Partial<CommitInfo> WithProject(this Partial<CommitInfo> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<CommitInfo> WithRepository(this Partial<CommitInfo> it)
            => it.AddFieldName("repository");
        
        public static Partial<CommitInfo> WithCommitId(this Partial<CommitInfo> it)
            => it.AddFieldName("commitId");
        
        public static Partial<CommitInfo> WithMessage(this Partial<CommitInfo> it)
            => it.AddFieldName("message");
        
        public static Partial<CommitInfo> WithCommitDate(this Partial<CommitInfo> it)
            => it.AddFieldName("commitDate");
        
        public static Partial<CommitInfo> WithAuthorName(this Partial<CommitInfo> it)
            => it.AddFieldName("authorName");
        
        public static Partial<CommitInfo> WithAuthorEmail(this Partial<CommitInfo> it)
            => it.AddFieldName("authorEmail");
        
        public static Partial<CommitInfo> WithAuthorProfile(this Partial<CommitInfo> it)
            => it.AddFieldName("authorProfile");
        
        public static Partial<CommitInfo> WithAuthorProfile(this Partial<CommitInfo> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("authorProfile", partialBuilder(new Partial<TDMemberProfile>(it)));
        
    }
    
}
