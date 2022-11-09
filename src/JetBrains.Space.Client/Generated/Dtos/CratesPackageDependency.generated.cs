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

public sealed class CratesPackageDependency
     : IPropagatePropertyAccessPath
{
    public CratesPackageDependency() { }
    
    public CratesPackageDependency(string name, string versionReq, List<string> features, bool optional, bool defaultFeatures, string kind, string? target = null, string? registry = null, string? explicitNameInToml = null)
    {
        Name = name;
        VersionReq = versionReq;
        Features = features;
        IsOptional = optional;
        IsDefaultFeatures = defaultFeatures;
        Target = target;
        Kind = kind;
        Registry = registry;
        ExplicitNameInToml = explicitNameInToml;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(CratesPackageDependency), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _versionReq = new PropertyValue<string>(nameof(CratesPackageDependency), nameof(VersionReq), "versionReq");
    
    [Required]
    [JsonPropertyName("versionReq")]
    public string VersionReq
    {
        get => _versionReq.GetValue(InlineErrors);
        set => _versionReq.SetValue(value);
    }

    private PropertyValue<List<string>> _features = new PropertyValue<List<string>>(nameof(CratesPackageDependency), nameof(Features), "features", new List<string>());
    
    [Required]
    [JsonPropertyName("features")]
    public List<string> Features
    {
        get => _features.GetValue(InlineErrors);
        set => _features.SetValue(value);
    }

    private PropertyValue<bool> _optional = new PropertyValue<bool>(nameof(CratesPackageDependency), nameof(IsOptional), "optional");
    
    [Required]
    [JsonPropertyName("optional")]
    public bool IsOptional
    {
        get => _optional.GetValue(InlineErrors);
        set => _optional.SetValue(value);
    }

    private PropertyValue<bool> _defaultFeatures = new PropertyValue<bool>(nameof(CratesPackageDependency), nameof(IsDefaultFeatures), "defaultFeatures");
    
    [Required]
    [JsonPropertyName("defaultFeatures")]
    public bool IsDefaultFeatures
    {
        get => _defaultFeatures.GetValue(InlineErrors);
        set => _defaultFeatures.SetValue(value);
    }

    private PropertyValue<string?> _target = new PropertyValue<string?>(nameof(CratesPackageDependency), nameof(Target), "target");
    
    [JsonPropertyName("target")]
    public string? Target
    {
        get => _target.GetValue(InlineErrors);
        set => _target.SetValue(value);
    }

    private PropertyValue<string> _kind = new PropertyValue<string>(nameof(CratesPackageDependency), nameof(Kind), "kind");
    
    [Required]
    [JsonPropertyName("kind")]
    public string Kind
    {
        get => _kind.GetValue(InlineErrors);
        set => _kind.SetValue(value);
    }

    private PropertyValue<string?> _registry = new PropertyValue<string?>(nameof(CratesPackageDependency), nameof(Registry), "registry");
    
    [JsonPropertyName("registry")]
    public string? Registry
    {
        get => _registry.GetValue(InlineErrors);
        set => _registry.SetValue(value);
    }

    private PropertyValue<string?> _explicitNameInToml = new PropertyValue<string?>(nameof(CratesPackageDependency), nameof(ExplicitNameInToml), "explicitNameInToml");
    
    [JsonPropertyName("explicitNameInToml")]
    public string? ExplicitNameInToml
    {
        get => _explicitNameInToml.GetValue(InlineErrors);
        set => _explicitNameInToml.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _versionReq.SetAccessPath(parentChainPath, validateHasBeenSet);
        _features.SetAccessPath(parentChainPath, validateHasBeenSet);
        _optional.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultFeatures.SetAccessPath(parentChainPath, validateHasBeenSet);
        _target.SetAccessPath(parentChainPath, validateHasBeenSet);
        _kind.SetAccessPath(parentChainPath, validateHasBeenSet);
        _registry.SetAccessPath(parentChainPath, validateHasBeenSet);
        _explicitNameInToml.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
