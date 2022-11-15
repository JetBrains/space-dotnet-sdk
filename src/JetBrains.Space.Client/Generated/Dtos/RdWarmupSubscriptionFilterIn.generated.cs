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

public sealed class RdWarmupSubscriptionFilterIn
     : SubscriptionFilterIn, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "RdWarmupSubscriptionFilterIn";
    
    public RdWarmupSubscriptionFilterIn() { }
    
    public RdWarmupSubscriptionFilterIn(string project, string? repositoryName = null, List<string>? branchSpec = null)
    {
        Project = project;
        RepositoryName = repositoryName;
        BranchSpec = branchSpec;
    }
    
    private PropertyValue<string> _project = new PropertyValue<string>(nameof(RdWarmupSubscriptionFilterIn), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public string Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string?> _repositoryName = new PropertyValue<string?>(nameof(RdWarmupSubscriptionFilterIn), nameof(RepositoryName), "repositoryName");
    
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName
    {
        get => _repositoryName.GetValue(InlineErrors);
        set => _repositoryName.SetValue(value);
    }

    private PropertyValue<List<string>?> _branchSpec = new PropertyValue<List<string>?>(nameof(RdWarmupSubscriptionFilterIn), nameof(BranchSpec), "branchSpec");
    
    [JsonPropertyName("branchSpec")]
    public List<string>? BranchSpec
    {
        get => _branchSpec.GetValue(InlineErrors);
        set => _branchSpec.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositoryName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _branchSpec.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

