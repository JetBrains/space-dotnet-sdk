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

internal class ApplicationsForApplicationAuthorizationsAuthorizedRightsRequestRightsPatchRequest
     : IPropagatePropertyAccessPath
{
    public ApplicationsForApplicationAuthorizationsAuthorizedRightsRequestRightsPatchRequest() { }
    
    public ApplicationsForApplicationAuthorizationsAuthorizedRightsRequestRightsPatchRequest(PermissionContextIdentifier contextIdentifier, List<PermissionIdentifier> rightCodes, PrincipalIn? actor = null, string? comment = null)
    {
        ContextIdentifier = contextIdentifier;
        RightCodes = rightCodes;
        Actor = actor;
        Comment = comment;
    }
    
    private PropertyValue<PermissionContextIdentifier> _contextIdentifier = new PropertyValue<PermissionContextIdentifier>(nameof(ApplicationsForApplicationAuthorizationsAuthorizedRightsRequestRightsPatchRequest), nameof(ContextIdentifier), "contextIdentifier");
    
    [Required]
    [JsonPropertyName("contextIdentifier")]
    public PermissionContextIdentifier ContextIdentifier
    {
        get => _contextIdentifier.GetValue(InlineErrors);
        set => _contextIdentifier.SetValue(value);
    }

    private PropertyValue<List<PermissionIdentifier>> _rightCodes = new PropertyValue<List<PermissionIdentifier>>(nameof(ApplicationsForApplicationAuthorizationsAuthorizedRightsRequestRightsPatchRequest), nameof(RightCodes), "rightCodes", new List<PermissionIdentifier>());
    
    [Required]
    [JsonPropertyName("rightCodes")]
    public List<PermissionIdentifier> RightCodes
    {
        get => _rightCodes.GetValue(InlineErrors);
        set => _rightCodes.SetValue(value);
    }

    private PropertyValue<PrincipalIn?> _actor = new PropertyValue<PrincipalIn?>(nameof(ApplicationsForApplicationAuthorizationsAuthorizedRightsRequestRightsPatchRequest), nameof(Actor), "actor");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("actor")]
    public PrincipalIn? Actor
    {
        get => _actor.GetValue(InlineErrors);
        set => _actor.SetValue(value);
    }

    private PropertyValue<string?> _comment = new PropertyValue<string?>(nameof(ApplicationsForApplicationAuthorizationsAuthorizedRightsRequestRightsPatchRequest), nameof(Comment), "comment");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("comment")]
    public string? Comment
    {
        get => _comment.GetValue(InlineErrors);
        set => _comment.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _contextIdentifier.SetAccessPath(parentChainPath, validateHasBeenSet);
        _rightCodes.SetAccessPath(parentChainPath, validateHasBeenSet);
        _actor.SetAccessPath(parentChainPath, validateHasBeenSet);
        _comment.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

