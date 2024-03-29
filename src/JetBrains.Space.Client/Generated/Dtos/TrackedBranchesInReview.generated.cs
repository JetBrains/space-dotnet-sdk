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

public sealed class TrackedBranchesInReview
     : IPropagatePropertyAccessPath
{
    public TrackedBranchesInReview() { }
    
    public TrackedBranchesInReview(string repository, List<BranchInfo> branches)
    {
        Repository = repository;
        Branches = branches;
    }
    
    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(TrackedBranchesInReview), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<List<BranchInfo>> _branches = new PropertyValue<List<BranchInfo>>(nameof(TrackedBranchesInReview), nameof(Branches), "branches", new List<BranchInfo>());
    
    [Required]
    [JsonPropertyName("branches")]
    public List<BranchInfo> Branches
    {
        get => _branches.GetValue(InlineErrors);
        set => _branches.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _branches.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

