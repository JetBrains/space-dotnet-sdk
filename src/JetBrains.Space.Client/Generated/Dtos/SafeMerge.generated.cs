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

public sealed class SafeMerge
     : IPropagatePropertyAccessPath
{
    public SafeMerge() { }
    
    public SafeMerge(string mergeCommitId, List<SafeMergeCheck> checks, MergeSelectOptions mergeOptions, SafeMergeState? state = null, TDMemberProfile? startedBy = null, DateTime? startedAt = null, long? duration = null, int? attempts = null)
    {
        State = state;
        MergeCommitId = mergeCommitId;
        Checks = checks;
        MergeOptions = mergeOptions;
        StartedBy = startedBy;
        StartedAt = startedAt;
        Duration = duration;
        Attempts = attempts;
    }
    
    private PropertyValue<SafeMergeState?> _state = new PropertyValue<SafeMergeState?>(nameof(SafeMerge), nameof(State), "state");
    
    [JsonPropertyName("state")]
    public SafeMergeState? State
    {
        get => _state.GetValue(InlineErrors);
        set => _state.SetValue(value);
    }

    private PropertyValue<string> _mergeCommitId = new PropertyValue<string>(nameof(SafeMerge), nameof(MergeCommitId), "mergeCommitId");
    
    [Required]
    [JsonPropertyName("mergeCommitId")]
    public string MergeCommitId
    {
        get => _mergeCommitId.GetValue(InlineErrors);
        set => _mergeCommitId.SetValue(value);
    }

    private PropertyValue<List<SafeMergeCheck>> _checks = new PropertyValue<List<SafeMergeCheck>>(nameof(SafeMerge), nameof(Checks), "checks", new List<SafeMergeCheck>());
    
    [Required]
    [JsonPropertyName("checks")]
    public List<SafeMergeCheck> Checks
    {
        get => _checks.GetValue(InlineErrors);
        set => _checks.SetValue(value);
    }

    private PropertyValue<MergeSelectOptions> _mergeOptions = new PropertyValue<MergeSelectOptions>(nameof(SafeMerge), nameof(MergeOptions), "mergeOptions");
    
    [Required]
    [JsonPropertyName("mergeOptions")]
    public MergeSelectOptions MergeOptions
    {
        get => _mergeOptions.GetValue(InlineErrors);
        set => _mergeOptions.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _startedBy = new PropertyValue<TDMemberProfile?>(nameof(SafeMerge), nameof(StartedBy), "startedBy");
    
    [JsonPropertyName("startedBy")]
    public TDMemberProfile? StartedBy
    {
        get => _startedBy.GetValue(InlineErrors);
        set => _startedBy.SetValue(value);
    }

    private PropertyValue<DateTime?> _startedAt = new PropertyValue<DateTime?>(nameof(SafeMerge), nameof(StartedAt), "startedAt");
    
    [JsonPropertyName("startedAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? StartedAt
    {
        get => _startedAt.GetValue(InlineErrors);
        set => _startedAt.SetValue(value);
    }

    private PropertyValue<long?> _duration = new PropertyValue<long?>(nameof(SafeMerge), nameof(Duration), "duration");
    
    [JsonPropertyName("duration")]
    public long? Duration
    {
        get => _duration.GetValue(InlineErrors);
        set => _duration.SetValue(value);
    }

    private PropertyValue<int?> _attempts = new PropertyValue<int?>(nameof(SafeMerge), nameof(Attempts), "attempts");
    
    [JsonPropertyName("attempts")]
    public int? Attempts
    {
        get => _attempts.GetValue(InlineErrors);
        set => _attempts.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _state.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mergeCommitId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _checks.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mergeOptions.SetAccessPath(parentChainPath, validateHasBeenSet);
        _startedBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _startedAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _duration.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attempts.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

