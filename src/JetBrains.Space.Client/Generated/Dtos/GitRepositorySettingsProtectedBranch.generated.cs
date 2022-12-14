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

public sealed class GitRepositorySettingsProtectedBranch
     : IPropagatePropertyAccessPath
{
    public GitRepositorySettingsProtectedBranch() { }
    
    public GitRepositorySettingsProtectedBranch(List<string> pattern, bool? regex = null, List<string>? allowCreate = null, List<string>? allowPush = null, List<string>? allowDelete = null, List<string>? allowForcePush = null, GitRepositorySettingsQualityGate? qualityGate = null, GitRepositorySettingsSafeMerge? safeMerge = null, bool? linearHistory = null)
    {
        Pattern = pattern;
        IsRegex = regex;
        AllowCreate = allowCreate;
        AllowPush = allowPush;
        AllowDelete = allowDelete;
        AllowForcePush = allowForcePush;
        QualityGate = qualityGate;
        SafeMerge = safeMerge;
        IsLinearHistory = linearHistory;
    }
    
    private PropertyValue<List<string>> _pattern = new PropertyValue<List<string>>(nameof(GitRepositorySettingsProtectedBranch), nameof(Pattern), "pattern", new List<string>());
    
    [Required]
    [JsonPropertyName("pattern")]
    public List<string> Pattern
    {
        get => _pattern.GetValue(InlineErrors);
        set => _pattern.SetValue(value);
    }

    private PropertyValue<bool?> _regex = new PropertyValue<bool?>(nameof(GitRepositorySettingsProtectedBranch), nameof(IsRegex), "regex");
    
    [JsonPropertyName("regex")]
    public bool? IsRegex
    {
        get => _regex.GetValue(InlineErrors);
        set => _regex.SetValue(value);
    }

    private PropertyValue<List<string>?> _allowCreate = new PropertyValue<List<string>?>(nameof(GitRepositorySettingsProtectedBranch), nameof(AllowCreate), "allowCreate");
    
    [JsonPropertyName("allowCreate")]
    public List<string>? AllowCreate
    {
        get => _allowCreate.GetValue(InlineErrors);
        set => _allowCreate.SetValue(value);
    }

    private PropertyValue<List<string>?> _allowPush = new PropertyValue<List<string>?>(nameof(GitRepositorySettingsProtectedBranch), nameof(AllowPush), "allowPush");
    
    [JsonPropertyName("allowPush")]
    public List<string>? AllowPush
    {
        get => _allowPush.GetValue(InlineErrors);
        set => _allowPush.SetValue(value);
    }

    private PropertyValue<List<string>?> _allowDelete = new PropertyValue<List<string>?>(nameof(GitRepositorySettingsProtectedBranch), nameof(AllowDelete), "allowDelete");
    
    [JsonPropertyName("allowDelete")]
    public List<string>? AllowDelete
    {
        get => _allowDelete.GetValue(InlineErrors);
        set => _allowDelete.SetValue(value);
    }

    private PropertyValue<List<string>?> _allowForcePush = new PropertyValue<List<string>?>(nameof(GitRepositorySettingsProtectedBranch), nameof(AllowForcePush), "allowForcePush");
    
    [JsonPropertyName("allowForcePush")]
    public List<string>? AllowForcePush
    {
        get => _allowForcePush.GetValue(InlineErrors);
        set => _allowForcePush.SetValue(value);
    }

    private PropertyValue<GitRepositorySettingsQualityGate?> _qualityGate = new PropertyValue<GitRepositorySettingsQualityGate?>(nameof(GitRepositorySettingsProtectedBranch), nameof(QualityGate), "qualityGate");
    
    [JsonPropertyName("qualityGate")]
    public GitRepositorySettingsQualityGate? QualityGate
    {
        get => _qualityGate.GetValue(InlineErrors);
        set => _qualityGate.SetValue(value);
    }

    private PropertyValue<GitRepositorySettingsSafeMerge?> _safeMerge = new PropertyValue<GitRepositorySettingsSafeMerge?>(nameof(GitRepositorySettingsProtectedBranch), nameof(SafeMerge), "safeMerge");
    
    [JsonPropertyName("safeMerge")]
    public GitRepositorySettingsSafeMerge? SafeMerge
    {
        get => _safeMerge.GetValue(InlineErrors);
        set => _safeMerge.SetValue(value);
    }

    private PropertyValue<bool?> _linearHistory = new PropertyValue<bool?>(nameof(GitRepositorySettingsProtectedBranch), nameof(IsLinearHistory), "linearHistory");
    
    [JsonPropertyName("linearHistory")]
    public bool? IsLinearHistory
    {
        get => _linearHistory.GetValue(InlineErrors);
        set => _linearHistory.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _pattern.SetAccessPath(parentChainPath, validateHasBeenSet);
        _regex.SetAccessPath(parentChainPath, validateHasBeenSet);
        _allowCreate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _allowPush.SetAccessPath(parentChainPath, validateHasBeenSet);
        _allowDelete.SetAccessPath(parentChainPath, validateHasBeenSet);
        _allowForcePush.SetAccessPath(parentChainPath, validateHasBeenSet);
        _qualityGate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _safeMerge.SetAccessPath(parentChainPath, validateHasBeenSet);
        _linearHistory.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

