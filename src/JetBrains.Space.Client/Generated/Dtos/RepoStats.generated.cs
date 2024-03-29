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

public sealed class RepoStats
     : IPropagatePropertyAccessPath
{
    public RepoStats() { }
    
    public RepoStats(int totalBranches, int totalCommits, long size, DateTime? latestActivity = null, RepositoryActivity? monthlyActivity = null)
    {
        TotalBranches = totalBranches;
        TotalCommits = totalCommits;
        Size = size;
        LatestActivity = latestActivity;
        MonthlyActivity = monthlyActivity;
    }
    
    private PropertyValue<int> _totalBranches = new PropertyValue<int>(nameof(RepoStats), nameof(TotalBranches), "totalBranches");
    
    [Required]
    [JsonPropertyName("totalBranches")]
    public int TotalBranches
    {
        get => _totalBranches.GetValue(InlineErrors);
        set => _totalBranches.SetValue(value);
    }

    private PropertyValue<int> _totalCommits = new PropertyValue<int>(nameof(RepoStats), nameof(TotalCommits), "totalCommits");
    
    [Required]
    [JsonPropertyName("totalCommits")]
    public int TotalCommits
    {
        get => _totalCommits.GetValue(InlineErrors);
        set => _totalCommits.SetValue(value);
    }

    private PropertyValue<long> _size = new PropertyValue<long>(nameof(RepoStats), nameof(Size), "size");
    
    [Required]
    [JsonPropertyName("size")]
    public long Size
    {
        get => _size.GetValue(InlineErrors);
        set => _size.SetValue(value);
    }

    private PropertyValue<DateTime?> _latestActivity = new PropertyValue<DateTime?>(nameof(RepoStats), nameof(LatestActivity), "latestActivity");
    
    [JsonPropertyName("latestActivity")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? LatestActivity
    {
        get => _latestActivity.GetValue(InlineErrors);
        set => _latestActivity.SetValue(value);
    }

    private PropertyValue<RepositoryActivity?> _monthlyActivity = new PropertyValue<RepositoryActivity?>(nameof(RepoStats), nameof(MonthlyActivity), "monthlyActivity");
    
    [JsonPropertyName("monthlyActivity")]
    public RepositoryActivity? MonthlyActivity
    {
        get => _monthlyActivity.GetValue(InlineErrors);
        set => _monthlyActivity.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _totalBranches.SetAccessPath(parentChainPath, validateHasBeenSet);
        _totalCommits.SetAccessPath(parentChainPath, validateHasBeenSet);
        _size.SetAccessPath(parentChainPath, validateHasBeenSet);
        _latestActivity.SetAccessPath(parentChainPath, validateHasBeenSet);
        _monthlyActivity.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

