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

public class ApplicationsForApplicationPermanentTokensForTokenIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public ApplicationsForApplicationPermanentTokensForTokenIdPatchRequest() { }
    
    public ApplicationsForApplicationPermanentTokensForTokenIdPatchRequest(string? name = null, PermissionScope? scope = null, DateTime? expires = null)
    {
        Name = name;
        Scope = scope;
        Expires = expires;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ApplicationsForApplicationPermanentTokensForTokenIdPatchRequest), nameof(Name), "name");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<PermissionScope?> _scope = new PropertyValue<PermissionScope?>(nameof(ApplicationsForApplicationPermanentTokensForTokenIdPatchRequest), nameof(Scope), "scope");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("scope")]
    public PermissionScope? Scope
    {
        get => _scope.GetValue(InlineErrors);
        set => _scope.SetValue(value);
    }

    private PropertyValue<DateTime?> _expires = new PropertyValue<DateTime?>(nameof(ApplicationsForApplicationPermanentTokensForTokenIdPatchRequest), nameof(Expires), "expires");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("expires")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? Expires
    {
        get => _expires.GetValue(InlineErrors);
        set => _expires.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _scope.SetAccessPath(parentChainPath, validateHasBeenSet);
        _expires.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

