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

public sealed class ESProfileLogin
     : IPropagatePropertyAccessPath
{
    public ESProfileLogin() { }
    
    public ESProfileLogin(string identifier, ESAuthModule authModule, ESProfileLoginDetails details, AccessRecord? access = null)
    {
        Identifier = identifier;
        AuthModule = authModule;
        Details = details;
        Access = access;
    }
    
    private PropertyValue<string> _identifier = new PropertyValue<string>(nameof(ESProfileLogin), nameof(Identifier), "identifier");
    
    [Required]
    [JsonPropertyName("identifier")]
    public string Identifier
    {
        get => _identifier.GetValue(InlineErrors);
        set => _identifier.SetValue(value);
    }

    private PropertyValue<ESAuthModule> _authModule = new PropertyValue<ESAuthModule>(nameof(ESProfileLogin), nameof(AuthModule), "authModule");
    
    [Required]
    [JsonPropertyName("authModule")]
    public ESAuthModule AuthModule
    {
        get => _authModule.GetValue(InlineErrors);
        set => _authModule.SetValue(value);
    }

    private PropertyValue<ESProfileLoginDetails> _details = new PropertyValue<ESProfileLoginDetails>(nameof(ESProfileLogin), nameof(Details), "details");
    
    [Required]
    [JsonPropertyName("details")]
    public ESProfileLoginDetails Details
    {
        get => _details.GetValue(InlineErrors);
        set => _details.SetValue(value);
    }

    private PropertyValue<AccessRecord?> _access = new PropertyValue<AccessRecord?>(nameof(ESProfileLogin), nameof(Access), "access");
    
    [JsonPropertyName("access")]
    public AccessRecord? Access
    {
        get => _access.GetValue(InlineErrors);
        set => _access.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _identifier.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authModule.SetAccessPath(parentChainPath, validateHasBeenSet);
        _details.SetAccessPath(parentChainPath, validateHasBeenSet);
        _access.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

