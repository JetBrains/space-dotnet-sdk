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

public sealed class PermissionsRecipientProjectRole
     : PermissionsRecipient, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "PermissionsRecipient.ProjectRole";
    
    public PermissionsRecipientProjectRole() { }
    
    public PermissionsRecipientProjectRole(PRProject project, string roleId, string name)
    {
        Project = project;
        RoleId = roleId;
        Name = name;
    }
    
    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(PermissionsRecipientProjectRole), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _roleId = new PropertyValue<string>(nameof(PermissionsRecipientProjectRole), nameof(RoleId), "roleId");
    
    [Required]
    [JsonPropertyName("roleId")]
    public string RoleId
    {
        get => _roleId.GetValue(InlineErrors);
        set => _roleId.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(PermissionsRecipientProjectRole), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _roleId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

