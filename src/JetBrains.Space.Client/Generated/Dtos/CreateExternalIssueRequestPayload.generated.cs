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

public sealed class CreateExternalIssueRequestPayload
     : ApplicationPayload, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "CreateExternalIssueRequestPayload";
    
    public CreateExternalIssueRequestPayload() { }
    
    public CreateExternalIssueRequestPayload(string spaceUserId, string clientId, string? requestId = null, string? summary = null, string? description = null, string? issuePrefix = null, string? verificationToken = null)
    {
        RequestId = requestId;
        SpaceUserId = spaceUserId;
        Summary = summary;
        Description = description;
        IssuePrefix = issuePrefix;
        ClientId = clientId;
        VerificationToken = verificationToken;
    }
    
    private PropertyValue<string?> _requestId = new PropertyValue<string?>(nameof(CreateExternalIssueRequestPayload), nameof(RequestId), "requestId");
    
    [JsonPropertyName("requestId")]
    public string? RequestId
    {
        get => _requestId.GetValue(InlineErrors);
        set => _requestId.SetValue(value);
    }

    private PropertyValue<string> _spaceUserId = new PropertyValue<string>(nameof(CreateExternalIssueRequestPayload), nameof(SpaceUserId), "spaceUserId");
    
    [Required]
    [JsonPropertyName("spaceUserId")]
    public string SpaceUserId
    {
        get => _spaceUserId.GetValue(InlineErrors);
        set => _spaceUserId.SetValue(value);
    }

    private PropertyValue<string?> _summary = new PropertyValue<string?>(nameof(CreateExternalIssueRequestPayload), nameof(Summary), "summary");
    
    [JsonPropertyName("summary")]
    public string? Summary
    {
        get => _summary.GetValue(InlineErrors);
        set => _summary.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CreateExternalIssueRequestPayload), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<string?> _issuePrefix = new PropertyValue<string?>(nameof(CreateExternalIssueRequestPayload), nameof(IssuePrefix), "issuePrefix");
    
    [JsonPropertyName("issuePrefix")]
    public string? IssuePrefix
    {
        get => _issuePrefix.GetValue(InlineErrors);
        set => _issuePrefix.SetValue(value);
    }

    private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(CreateExternalIssueRequestPayload), nameof(ClientId), "clientId");
    
    [Required]
    [JsonPropertyName("clientId")]
    public string ClientId
    {
        get => _clientId.GetValue(InlineErrors);
        set => _clientId.SetValue(value);
    }

    private PropertyValue<string?> _verificationToken = new PropertyValue<string?>(nameof(CreateExternalIssueRequestPayload), nameof(VerificationToken), "verificationToken");
    
    [Obsolete("Verification token is only sent for old applications that have the Verification Token authentication set up. New applications cannot use this authentication. (since 2022-11-16) (will be removed in a future version)")]
    [JsonPropertyName("verificationToken")]
    public string? VerificationToken
    {
        get => _verificationToken.GetValue(InlineErrors);
        set => _verificationToken.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _requestId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _spaceUserId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _summary.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issuePrefix.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _verificationToken.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
