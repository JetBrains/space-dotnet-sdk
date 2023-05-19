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

public sealed class NewExternalIssueEventPayload
     : ApplicationPayload, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "NewExternalIssueEventPayload";
    
    public NewExternalIssueEventPayload() { }
    
    public NewExternalIssueEventPayload(string clientId, string? verificationToken = null)
    {
        ClientId = clientId;
        VerificationToken = verificationToken;
    }
    
    private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(NewExternalIssueEventPayload), nameof(ClientId), "clientId");
    
    [Required]
    [JsonPropertyName("clientId")]
    public string ClientId
    {
        get => _clientId.GetValue(InlineErrors);
        set => _clientId.SetValue(value);
    }

    private PropertyValue<string?> _verificationToken = new PropertyValue<string?>(nameof(NewExternalIssueEventPayload), nameof(VerificationToken), "verificationToken");
    
    [Obsolete("Verification token is only sent for old applications that have the Verification Token authentication set up. New applications cannot use this authentication. (since 2022-11-16) (will be removed in a future version)")]
    [JsonPropertyName("verificationToken")]
    public string? VerificationToken
    {
        get => _verificationToken.GetValue(InlineErrors);
        set => _verificationToken.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _clientId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _verificationToken.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

