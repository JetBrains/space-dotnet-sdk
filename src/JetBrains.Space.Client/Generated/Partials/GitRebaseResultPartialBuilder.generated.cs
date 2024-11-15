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

namespace JetBrains.Space.Client.GitRebaseResultPartialBuilder;

public static class GitRebaseResultPartialExtensions
{
    public static Partial<GitRebaseResult> WithIsSuccess(this Partial<GitRebaseResult> it)
        => it.AddFieldName("success");
    
    public static Partial<GitRebaseResult> WithMessage(this Partial<GitRebaseResult> it)
        => it.AddFieldName("message");
    
    public static Partial<GitRebaseResult> WithResultCommitIds(this Partial<GitRebaseResult> it)
        => it.AddFieldName("resultCommitIds");
    
    public static Partial<GitRebaseResult> WithUpdatedHeads(this Partial<GitRebaseResult> it)
        => it.AddFieldName("updatedHeads");
    
    public static Partial<GitRebaseResult> WithUpdatedHeads(this Partial<GitRebaseResult> it, Func<Partial<GitUpdatedHead>, Partial<GitUpdatedHead>> partialBuilder)
        => it.AddFieldName("updatedHeads", partialBuilder(new Partial<GitUpdatedHead>(it)));
    
}

