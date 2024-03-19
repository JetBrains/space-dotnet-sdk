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

[JsonConverter(typeof(ClassNameDtoTypeConverter))]
public class SafeMergeCommand
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "SafeMergeCommand";
    
    public static SafeMergeCommandFetchStatus FetchStatus(string project, string buildId)
        => new SafeMergeCommandFetchStatus(project: project, buildId: buildId);
    
    public static SafeMergeCommandStart Start(string project, string spaceProjectId, string mergeRequestId, string branch, string commit, bool isDryRun, string? startedByUserId = null)
        => new SafeMergeCommandStart(project: project, spaceProjectId: spaceProjectId, mergeRequestId: mergeRequestId, branch: branch, commit: commit, isDryRun: isDryRun, startedByUserId: startedByUserId);
    
    public static SafeMergeCommandStop Stop(string project, string buildId)
        => new SafeMergeCommandStop(project: project, buildId: buildId);
    
    public SafeMergeCommand() { }
    
    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

