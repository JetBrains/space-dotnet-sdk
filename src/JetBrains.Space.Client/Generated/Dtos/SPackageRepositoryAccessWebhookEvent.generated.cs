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

public sealed class SPackageRepositoryAccessWebhookEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "SPackageRepositoryAccessWebhookEvent";
    
    public SPackageRepositoryAccessWebhookEvent() { }
    
    public SPackageRepositoryAccessWebhookEvent(ProjectKey projectKey, string repository, PackageType repositoryType)
    {
        ProjectKey = projectKey;
        Repository = repository;
        RepositoryType = repositoryType;
    }
    
    private PropertyValue<ProjectKey> _projectKey = new PropertyValue<ProjectKey>(nameof(SPackageRepositoryAccessWebhookEvent), nameof(ProjectKey), "projectKey");
    
    [Required]
    [JsonPropertyName("projectKey")]
    public ProjectKey ProjectKey
    {
        get => _projectKey.GetValue(InlineErrors);
        set => _projectKey.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(SPackageRepositoryAccessWebhookEvent), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<PackageType> _repositoryType = new PropertyValue<PackageType>(nameof(SPackageRepositoryAccessWebhookEvent), nameof(RepositoryType), "repositoryType");
    
    [Required]
    [JsonPropertyName("repositoryType")]
    public PackageType RepositoryType
    {
        get => _repositoryType.GetValue(InlineErrors);
        set => _repositoryType.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _projectKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositoryType.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

