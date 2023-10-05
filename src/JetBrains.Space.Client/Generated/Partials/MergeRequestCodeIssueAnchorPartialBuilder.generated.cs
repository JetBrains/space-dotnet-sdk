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

namespace JetBrains.Space.Client.MergeRequestCodeIssueAnchorPartialBuilder;

public static class MergeRequestCodeIssueAnchorPartialExtensions
{
    public static Partial<MergeRequestCodeIssueAnchor> WithCommitId(this Partial<MergeRequestCodeIssueAnchor> it)
        => it.AddFieldName("commitId");
    
    public static Partial<MergeRequestCodeIssueAnchor> WithFilePath(this Partial<MergeRequestCodeIssueAnchor> it)
        => it.AddFieldName("filePath");
    
    public static Partial<MergeRequestCodeIssueAnchor> WithLine(this Partial<MergeRequestCodeIssueAnchor> it)
        => it.AddFieldName("line");
    
    public static Partial<MergeRequestCodeIssueAnchor> WithColumn(this Partial<MergeRequestCodeIssueAnchor> it)
        => it.AddFieldName("column");
    
    public static Partial<MergeRequestCodeIssueAnchor> WithEndLine(this Partial<MergeRequestCodeIssueAnchor> it)
        => it.AddFieldName("endLine");
    
    public static Partial<MergeRequestCodeIssueAnchor> WithEndColumn(this Partial<MergeRequestCodeIssueAnchor> it)
        => it.AddFieldName("endColumn");
    
}

