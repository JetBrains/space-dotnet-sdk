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

public class ApplicationsUiExtensionsPatchRequest
     : IPropagatePropertyAccessPath
{
    public ApplicationsUiExtensionsPatchRequest() { }
    
    public ApplicationsUiExtensionsPatchRequest(PermissionContextIdentifier contextIdentifier, List<AppUiExtensionIn> extensions)
    {
        ContextIdentifier = contextIdentifier;
        Extensions = extensions;
    }
    
    private PropertyValue<PermissionContextIdentifier> _contextIdentifier = new PropertyValue<PermissionContextIdentifier>(nameof(ApplicationsUiExtensionsPatchRequest), nameof(ContextIdentifier), "contextIdentifier");
    
    [Required]
    [JsonPropertyName("contextIdentifier")]
    public PermissionContextIdentifier ContextIdentifier
    {
        get => _contextIdentifier.GetValue(InlineErrors);
        set => _contextIdentifier.SetValue(value);
    }

    private PropertyValue<List<AppUiExtensionIn>> _extensions = new PropertyValue<List<AppUiExtensionIn>>(nameof(ApplicationsUiExtensionsPatchRequest), nameof(Extensions), "extensions", new List<AppUiExtensionIn>());
    
    [Required]
    [JsonPropertyName("extensions")]
    public List<AppUiExtensionIn> Extensions
    {
        get => _extensions.GetValue(InlineErrors);
        set => _extensions.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _contextIdentifier.SetAccessPath(parentChainPath, validateHasBeenSet);
        _extensions.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

