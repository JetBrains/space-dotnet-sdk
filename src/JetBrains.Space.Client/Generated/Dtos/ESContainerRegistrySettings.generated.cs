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

public sealed class ESContainerRegistrySettings
     : ESPackageRepositorySettings, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "ES_ContainerRegistrySettings";
    
    public ESContainerRegistrySettings() { }
    
    public ESContainerRegistrySettings(bool immutableTags, RetentionPolicyParams? retentionPolicyParams = null, bool? immutablePackageVersions = null, bool? writePermissionForCachingArtifacts = null)
    {
        IsImmutableTags = immutableTags;
        RetentionPolicyParams = retentionPolicyParams;
        IsImmutablePackageVersions = immutablePackageVersions;
        IsWritePermissionForCachingArtifacts = writePermissionForCachingArtifacts;
    }
    
    private PropertyValue<bool> _immutableTags = new PropertyValue<bool>(nameof(ESContainerRegistrySettings), nameof(IsImmutableTags), "immutableTags");
    
    [Required]
    [JsonPropertyName("immutableTags")]
    public bool IsImmutableTags
    {
        get => _immutableTags.GetValue(InlineErrors);
        set => _immutableTags.SetValue(value);
    }

    private PropertyValue<RetentionPolicyParams?> _retentionPolicyParams = new PropertyValue<RetentionPolicyParams?>(nameof(ESContainerRegistrySettings), nameof(RetentionPolicyParams), "retentionPolicyParams");
    
    [JsonPropertyName("retentionPolicyParams")]
    public RetentionPolicyParams? RetentionPolicyParams
    {
        get => _retentionPolicyParams.GetValue(InlineErrors);
        set => _retentionPolicyParams.SetValue(value);
    }

    private PropertyValue<bool?> _immutablePackageVersions = new PropertyValue<bool?>(nameof(ESContainerRegistrySettings), nameof(IsImmutablePackageVersions), "immutablePackageVersions");
    
    [JsonPropertyName("immutablePackageVersions")]
    public bool? IsImmutablePackageVersions
    {
        get => _immutablePackageVersions.GetValue(InlineErrors);
        set => _immutablePackageVersions.SetValue(value);
    }

    private PropertyValue<bool?> _writePermissionForCachingArtifacts = new PropertyValue<bool?>(nameof(ESContainerRegistrySettings), nameof(IsWritePermissionForCachingArtifacts), "writePermissionForCachingArtifacts");
    
    [JsonPropertyName("writePermissionForCachingArtifacts")]
    public bool? IsWritePermissionForCachingArtifacts
    {
        get => _writePermissionForCachingArtifacts.GetValue(InlineErrors);
        set => _writePermissionForCachingArtifacts.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _immutableTags.SetAccessPath(parentChainPath, validateHasBeenSet);
        _retentionPolicyParams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _immutablePackageVersions.SetAccessPath(parentChainPath, validateHasBeenSet);
        _writePermissionForCachingArtifacts.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

