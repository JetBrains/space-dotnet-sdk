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

public sealed class CodeReviewParticipant
     : IPropagatePropertyAccessPath
{
    public CodeReviewParticipant() { }
    
    public CodeReviewParticipant(TDMemberProfile user, CodeReviewParticipantRole role, ReviewerState? state = null, bool? isApproveSticky = null, bool? theirTurn = null, List<CodeReviewParticipantQualityGateSlot>? qualityGateSlots = null, List<CodeReviewParticipantCodeOwnerSlot>? codeOwnerSlots = null, DateTime? addedAt = null)
    {
        User = user;
        Role = role;
        State = state;
        IsApproveSticky = isApproveSticky;
        IsTheirTurn = theirTurn;
        QualityGateSlots = qualityGateSlots;
        CodeOwnerSlots = codeOwnerSlots;
        AddedAt = addedAt;
    }
    
    private PropertyValue<TDMemberProfile> _user = new PropertyValue<TDMemberProfile>(nameof(CodeReviewParticipant), nameof(User), "user");
    
    [Required]
    [JsonPropertyName("user")]
    public TDMemberProfile User
    {
        get => _user.GetValue(InlineErrors);
        set => _user.SetValue(value);
    }

    private PropertyValue<CodeReviewParticipantRole> _role = new PropertyValue<CodeReviewParticipantRole>(nameof(CodeReviewParticipant), nameof(Role), "role");
    
    [Required]
    [JsonPropertyName("role")]
    public CodeReviewParticipantRole Role
    {
        get => _role.GetValue(InlineErrors);
        set => _role.SetValue(value);
    }

    private PropertyValue<ReviewerState?> _state = new PropertyValue<ReviewerState?>(nameof(CodeReviewParticipant), nameof(State), "state");
    
    [JsonPropertyName("state")]
    public ReviewerState? State
    {
        get => _state.GetValue(InlineErrors);
        set => _state.SetValue(value);
    }

    private PropertyValue<bool?> _isApproveSticky = new PropertyValue<bool?>(nameof(CodeReviewParticipant), nameof(IsApproveSticky), "isApproveSticky");
    
    [JsonPropertyName("isApproveSticky")]
    public bool? IsApproveSticky
    {
        get => _isApproveSticky.GetValue(InlineErrors);
        set => _isApproveSticky.SetValue(value);
    }

    private PropertyValue<bool?> _theirTurn = new PropertyValue<bool?>(nameof(CodeReviewParticipant), nameof(IsTheirTurn), "theirTurn");
    
    [JsonPropertyName("theirTurn")]
    public bool? IsTheirTurn
    {
        get => _theirTurn.GetValue(InlineErrors);
        set => _theirTurn.SetValue(value);
    }

    private PropertyValue<List<CodeReviewParticipantQualityGateSlot>?> _qualityGateSlots = new PropertyValue<List<CodeReviewParticipantQualityGateSlot>?>(nameof(CodeReviewParticipant), nameof(QualityGateSlots), "qualityGateSlots");
    
    [JsonPropertyName("qualityGateSlots")]
    public List<CodeReviewParticipantQualityGateSlot>? QualityGateSlots
    {
        get => _qualityGateSlots.GetValue(InlineErrors);
        set => _qualityGateSlots.SetValue(value);
    }

    private PropertyValue<List<CodeReviewParticipantCodeOwnerSlot>?> _codeOwnerSlots = new PropertyValue<List<CodeReviewParticipantCodeOwnerSlot>?>(nameof(CodeReviewParticipant), nameof(CodeOwnerSlots), "codeOwnerSlots");
    
    [JsonPropertyName("codeOwnerSlots")]
    public List<CodeReviewParticipantCodeOwnerSlot>? CodeOwnerSlots
    {
        get => _codeOwnerSlots.GetValue(InlineErrors);
        set => _codeOwnerSlots.SetValue(value);
    }

    private PropertyValue<DateTime?> _addedAt = new PropertyValue<DateTime?>(nameof(CodeReviewParticipant), nameof(AddedAt), "addedAt");
    
    [JsonPropertyName("addedAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? AddedAt
    {
        get => _addedAt.GetValue(InlineErrors);
        set => _addedAt.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _user.SetAccessPath(parentChainPath, validateHasBeenSet);
        _role.SetAccessPath(parentChainPath, validateHasBeenSet);
        _state.SetAccessPath(parentChainPath, validateHasBeenSet);
        _isApproveSticky.SetAccessPath(parentChainPath, validateHasBeenSet);
        _theirTurn.SetAccessPath(parentChainPath, validateHasBeenSet);
        _qualityGateSlots.SetAccessPath(parentChainPath, validateHasBeenSet);
        _codeOwnerSlots.SetAccessPath(parentChainPath, validateHasBeenSet);
        _addedAt.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

