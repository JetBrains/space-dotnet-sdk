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

public sealed class GitRepositorySettingsMergeOptions
     : IPropagatePropertyAccessPath
{
    public GitRepositorySettingsMergeOptions() { }
    
    public GitRepositorySettingsMergeOptions(bool? allowMerge = null, bool? allowFFMerge = null, GitRepositorySettingsMergeOptionsMergeMessageOption? mergeMessageOption = null, bool? allowRebase = null, bool? allowSquash = null, GitRepositorySettingsMergeOptionsSquashMessageOption? squashMessageOption = null)
    {
        IsAllowMerge = allowMerge;
        IsAllowFFMerge = allowFFMerge;
        MergeMessageOption = mergeMessageOption;
        IsAllowRebase = allowRebase;
        IsAllowSquash = allowSquash;
        SquashMessageOption = squashMessageOption;
    }
    
    private PropertyValue<bool?> _allowMerge = new PropertyValue<bool?>(nameof(GitRepositorySettingsMergeOptions), nameof(IsAllowMerge), "allowMerge");
    
    [JsonPropertyName("allowMerge")]
    public bool? IsAllowMerge
    {
        get => _allowMerge.GetValue(InlineErrors);
        set => _allowMerge.SetValue(value);
    }

    private PropertyValue<bool?> _allowFFMerge = new PropertyValue<bool?>(nameof(GitRepositorySettingsMergeOptions), nameof(IsAllowFFMerge), "allowFFMerge");
    
    [JsonPropertyName("allowFFMerge")]
    public bool? IsAllowFFMerge
    {
        get => _allowFFMerge.GetValue(InlineErrors);
        set => _allowFFMerge.SetValue(value);
    }

    private PropertyValue<GitRepositorySettingsMergeOptionsMergeMessageOption?> _mergeMessageOption = new PropertyValue<GitRepositorySettingsMergeOptionsMergeMessageOption?>(nameof(GitRepositorySettingsMergeOptions), nameof(MergeMessageOption), "mergeMessageOption");
    
    [JsonPropertyName("mergeMessageOption")]
    public GitRepositorySettingsMergeOptionsMergeMessageOption? MergeMessageOption
    {
        get => _mergeMessageOption.GetValue(InlineErrors);
        set => _mergeMessageOption.SetValue(value);
    }

    private PropertyValue<bool?> _allowRebase = new PropertyValue<bool?>(nameof(GitRepositorySettingsMergeOptions), nameof(IsAllowRebase), "allowRebase");
    
    [JsonPropertyName("allowRebase")]
    public bool? IsAllowRebase
    {
        get => _allowRebase.GetValue(InlineErrors);
        set => _allowRebase.SetValue(value);
    }

    private PropertyValue<bool?> _allowSquash = new PropertyValue<bool?>(nameof(GitRepositorySettingsMergeOptions), nameof(IsAllowSquash), "allowSquash");
    
    [JsonPropertyName("allowSquash")]
    public bool? IsAllowSquash
    {
        get => _allowSquash.GetValue(InlineErrors);
        set => _allowSquash.SetValue(value);
    }

    private PropertyValue<GitRepositorySettingsMergeOptionsSquashMessageOption?> _squashMessageOption = new PropertyValue<GitRepositorySettingsMergeOptionsSquashMessageOption?>(nameof(GitRepositorySettingsMergeOptions), nameof(SquashMessageOption), "squashMessageOption");
    
    [JsonPropertyName("squashMessageOption")]
    public GitRepositorySettingsMergeOptionsSquashMessageOption? SquashMessageOption
    {
        get => _squashMessageOption.GetValue(InlineErrors);
        set => _squashMessageOption.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _allowMerge.SetAccessPath(parentChainPath, validateHasBeenSet);
        _allowFFMerge.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mergeMessageOption.SetAccessPath(parentChainPath, validateHasBeenSet);
        _allowRebase.SetAccessPath(parentChainPath, validateHasBeenSet);
        _allowSquash.SetAccessPath(parentChainPath, validateHasBeenSet);
        _squashMessageOption.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

