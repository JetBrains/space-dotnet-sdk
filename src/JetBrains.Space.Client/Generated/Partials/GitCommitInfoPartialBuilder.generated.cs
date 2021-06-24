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
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.GitCommitInfoPartialBuilder
{
    public static class GitCommitInfoPartialExtensions
    {
        public static Partial<GitCommitInfo> WithId(this Partial<GitCommitInfo> it)
            => it.AddFieldName("id");
        
        public static Partial<GitCommitInfo> WithMessage(this Partial<GitCommitInfo> it)
            => it.AddFieldName("message");
        
        public static Partial<GitCommitInfo> WithAuthorDate(this Partial<GitCommitInfo> it)
            => it.AddFieldName("authorDate");
        
        public static Partial<GitCommitInfo> WithCommitDate(this Partial<GitCommitInfo> it)
            => it.AddFieldName("commitDate");
        
        public static Partial<GitCommitInfo> WithAuthor(this Partial<GitCommitInfo> it)
            => it.AddFieldName("author");
        
        public static Partial<GitCommitInfo> WithAuthor(this Partial<GitCommitInfo> it, Func<Partial<GitAuthorInfo>, Partial<GitAuthorInfo>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<GitAuthorInfo>(it)));
        
        public static Partial<GitCommitInfo> WithAuthorProfile(this Partial<GitCommitInfo> it)
            => it.AddFieldName("authorProfile");
        
        public static Partial<GitCommitInfo> WithAuthorProfile(this Partial<GitCommitInfo> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("authorProfile", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<GitCommitInfo> WithCommitter(this Partial<GitCommitInfo> it)
            => it.AddFieldName("committer");
        
        public static Partial<GitCommitInfo> WithCommitter(this Partial<GitCommitInfo> it, Func<Partial<GitAuthorInfo>, Partial<GitAuthorInfo>> partialBuilder)
            => it.AddFieldName("committer", partialBuilder(new Partial<GitAuthorInfo>(it)));
        
        public static Partial<GitCommitInfo> WithCommitterProfile(this Partial<GitCommitInfo> it)
            => it.AddFieldName("committerProfile");
        
        public static Partial<GitCommitInfo> WithCommitterProfile(this Partial<GitCommitInfo> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("committerProfile", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<GitCommitInfo> WithParents(this Partial<GitCommitInfo> it)
            => it.AddFieldName("parents");
        
        public static Partial<GitCommitInfo> WithHeads(this Partial<GitCommitInfo> it)
            => it.AddFieldName("heads");
        
        public static Partial<GitCommitInfo> WithSignature(this Partial<GitCommitInfo> it)
            => it.AddFieldName("signature");
        
        public static Partial<GitCommitInfo> WithSignature(this Partial<GitCommitInfo> it, Func<Partial<GitCommitSignature>, Partial<GitCommitSignature>> partialBuilder)
            => it.AddFieldName("signature", partialBuilder(new Partial<GitCommitSignature>(it)));
        
    }
    
}
