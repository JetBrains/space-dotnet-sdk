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

public sealed class RepositoryDetails
     : IPropagatePropertyAccessPath
{
    public RepositoryDetails() { }
    
    public RepositoryDetails(string projectKey, string repository, bool starred)
    {
        ProjectKey = projectKey;
        Repository = repository;
        IsStarred = starred;
    }
    
    private PropertyValue<string> _projectKey = new PropertyValue<string>(nameof(RepositoryDetails), nameof(ProjectKey), "projectKey");
    
    [Required]
    [JsonPropertyName("projectKey")]
    public string ProjectKey
    {
        get => _projectKey.GetValue(InlineErrors);
        set => _projectKey.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(RepositoryDetails), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<bool> _starred = new PropertyValue<bool>(nameof(RepositoryDetails), nameof(IsStarred), "starred");
    
    [Required]
    [JsonPropertyName("starred")]
    public bool IsStarred
    {
        get => _starred.GetValue(InlineErrors);
        set => _starred.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _projectKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _starred.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
