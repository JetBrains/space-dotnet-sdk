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

public sealed class MergeRequestQualityGateSettings
     : IPropagatePropertyAccessPath
{
    public MergeRequestQualityGateSettings() { }
    
    public MergeRequestQualityGateSettings(List<MergeRequestQualityGateSettingsRule> rules, List<TDMemberProfile> users, List<ESApp> applications, List<Role> roles, bool safeMerge, List<RoleDTO>? roles2 = null)
    {
        Rules = rules;
        Users = users;
        Applications = applications;
        Roles = roles;
        Roles2 = roles2;
        IsSafeMerge = safeMerge;
    }
    
    private PropertyValue<List<MergeRequestQualityGateSettingsRule>> _rules = new PropertyValue<List<MergeRequestQualityGateSettingsRule>>(nameof(MergeRequestQualityGateSettings), nameof(Rules), "rules", new List<MergeRequestQualityGateSettingsRule>());
    
    [Required]
    [JsonPropertyName("rules")]
    public List<MergeRequestQualityGateSettingsRule> Rules
    {
        get => _rules.GetValue(InlineErrors);
        set => _rules.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>> _users = new PropertyValue<List<TDMemberProfile>>(nameof(MergeRequestQualityGateSettings), nameof(Users), "users", new List<TDMemberProfile>());
    
    [Required]
    [JsonPropertyName("users")]
    public List<TDMemberProfile> Users
    {
        get => _users.GetValue(InlineErrors);
        set => _users.SetValue(value);
    }

    private PropertyValue<List<ESApp>> _applications = new PropertyValue<List<ESApp>>(nameof(MergeRequestQualityGateSettings), nameof(Applications), "applications", new List<ESApp>());
    
    [Required]
    [JsonPropertyName("applications")]
    public List<ESApp> Applications
    {
        get => _applications.GetValue(InlineErrors);
        set => _applications.SetValue(value);
    }

    private PropertyValue<List<Role>> _roles = new PropertyValue<List<Role>>(nameof(MergeRequestQualityGateSettings), nameof(Roles), "roles", new List<Role>());
    
    [Required]
    [JsonPropertyName("roles")]
    public List<Role> Roles
    {
        get => _roles.GetValue(InlineErrors);
        set => _roles.SetValue(value);
    }

    private PropertyValue<List<RoleDTO>?> _roles2 = new PropertyValue<List<RoleDTO>?>(nameof(MergeRequestQualityGateSettings), nameof(Roles2), "roles2");
    
    [JsonPropertyName("roles2")]
    public List<RoleDTO>? Roles2
    {
        get => _roles2.GetValue(InlineErrors);
        set => _roles2.SetValue(value);
    }

    private PropertyValue<bool> _safeMerge = new PropertyValue<bool>(nameof(MergeRequestQualityGateSettings), nameof(IsSafeMerge), "safeMerge");
    
    [Required]
    [JsonPropertyName("safeMerge")]
    public bool IsSafeMerge
    {
        get => _safeMerge.GetValue(InlineErrors);
        set => _safeMerge.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _rules.SetAccessPath(parentChainPath, validateHasBeenSet);
        _users.SetAccessPath(parentChainPath, validateHasBeenSet);
        _applications.SetAccessPath(parentChainPath, validateHasBeenSet);
        _roles.SetAccessPath(parentChainPath, validateHasBeenSet);
        _roles2.SetAccessPath(parentChainPath, validateHasBeenSet);
        _safeMerge.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

