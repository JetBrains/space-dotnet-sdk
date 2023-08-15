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

internal class ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest() { }
    
    public ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest(string? name = null, string? description = null, bool? @public = null, bool? cleanupEnabled = null, ESPackageRepositorySettings? settings = null)
    {
        Name = name;
        Description = description;
        IsPublic = @public;
        IsCleanupEnabled = cleanupEnabled;
        Settings = settings;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest), nameof(Name), "name");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<bool?> _public = new PropertyValue<bool?>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest), nameof(IsPublic), "public");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("public")]
    public bool? IsPublic
    {
        get => _public.GetValue(InlineErrors);
        set => _public.SetValue(value);
    }

    private PropertyValue<bool?> _cleanupEnabled = new PropertyValue<bool?>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest), nameof(IsCleanupEnabled), "cleanupEnabled");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("cleanupEnabled")]
    public bool? IsCleanupEnabled
    {
        get => _cleanupEnabled.GetValue(InlineErrors);
        set => _cleanupEnabled.SetValue(value);
    }

    private PropertyValue<ESPackageRepositorySettings?> _settings = new PropertyValue<ESPackageRepositorySettings?>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest), nameof(Settings), "settings");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("settings")]
    public ESPackageRepositorySettings? Settings
    {
        get => _settings.GetValue(InlineErrors);
        set => _settings.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _public.SetAccessPath(parentChainPath, validateHasBeenSet);
        _cleanupEnabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _settings.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

