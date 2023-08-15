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

internal class PermissionRolesCreatePostRequest
     : IPropagatePropertyAccessPath
{
    public PermissionRolesCreatePostRequest() { }
    
    public PermissionRolesCreatePostRequest(PermissionContextIdentifier contextIdentifier, string name)
    {
        ContextIdentifier = contextIdentifier;
        Name = name;
    }
    
    private PropertyValue<PermissionContextIdentifier> _contextIdentifier = new PropertyValue<PermissionContextIdentifier>(nameof(PermissionRolesCreatePostRequest), nameof(ContextIdentifier), "contextIdentifier");
    
    [Required]
    [JsonPropertyName("contextIdentifier")]
    public PermissionContextIdentifier ContextIdentifier
    {
        get => _contextIdentifier.GetValue(InlineErrors);
        set => _contextIdentifier.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(PermissionRolesCreatePostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _contextIdentifier.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

