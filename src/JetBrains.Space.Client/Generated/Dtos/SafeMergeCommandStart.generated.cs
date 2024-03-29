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

public sealed class SafeMergeCommandStart
     : SafeMergeCommand, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "SafeMergeCommand.Start";
    
    public SafeMergeCommandStart() { }
    
    public SafeMergeCommandStart(string project, string spaceProjectId, string mergeRequestId, string branch, string commit, bool isDryRun, string? startedByUserId = null)
    {
        Project = project;
        SpaceProjectId = spaceProjectId;
        MergeRequestId = mergeRequestId;
        Branch = branch;
        Commit = commit;
        IsDryRun = isDryRun;
        StartedByUserId = startedByUserId;
    }
    
    private PropertyValue<string> _project = new PropertyValue<string>(nameof(SafeMergeCommandStart), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public string Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _spaceProjectId = new PropertyValue<string>(nameof(SafeMergeCommandStart), nameof(SpaceProjectId), "spaceProjectId");
    
    [Required]
    [JsonPropertyName("spaceProjectId")]
    public string SpaceProjectId
    {
        get => _spaceProjectId.GetValue(InlineErrors);
        set => _spaceProjectId.SetValue(value);
    }

    private PropertyValue<string> _mergeRequestId = new PropertyValue<string>(nameof(SafeMergeCommandStart), nameof(MergeRequestId), "mergeRequestId");
    
    [Required]
    [JsonPropertyName("mergeRequestId")]
    public string MergeRequestId
    {
        get => _mergeRequestId.GetValue(InlineErrors);
        set => _mergeRequestId.SetValue(value);
    }

    private PropertyValue<string> _branch = new PropertyValue<string>(nameof(SafeMergeCommandStart), nameof(Branch), "branch");
    
    [Required]
    [JsonPropertyName("branch")]
    public string Branch
    {
        get => _branch.GetValue(InlineErrors);
        set => _branch.SetValue(value);
    }

    private PropertyValue<string> _commit = new PropertyValue<string>(nameof(SafeMergeCommandStart), nameof(Commit), "commit");
    
    [Required]
    [JsonPropertyName("commit")]
    public string Commit
    {
        get => _commit.GetValue(InlineErrors);
        set => _commit.SetValue(value);
    }

    private PropertyValue<bool> _isDryRun = new PropertyValue<bool>(nameof(SafeMergeCommandStart), nameof(IsDryRun), "isDryRun");
    
    [Required]
    [JsonPropertyName("isDryRun")]
    public bool IsDryRun
    {
        get => _isDryRun.GetValue(InlineErrors);
        set => _isDryRun.SetValue(value);
    }

    private PropertyValue<string?> _startedByUserId = new PropertyValue<string?>(nameof(SafeMergeCommandStart), nameof(StartedByUserId), "startedByUserId");
    
    [JsonPropertyName("startedByUserId")]
    public string? StartedByUserId
    {
        get => _startedByUserId.GetValue(InlineErrors);
        set => _startedByUserId.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _spaceProjectId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mergeRequestId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _branch.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commit.SetAccessPath(parentChainPath, validateHasBeenSet);
        _isDryRun.SetAccessPath(parentChainPath, validateHasBeenSet);
        _startedByUserId.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

