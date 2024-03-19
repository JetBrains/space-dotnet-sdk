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

public sealed class ReviewerChanged
     : CompactFeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ReviewerChanged";
    
    public ReviewerChanged() { }
    
    public ReviewerChanged(TDMemberProfile profile, ReviewerChangedType changeType, bool personally)
    {
        Profile = profile;
        ChangeType = changeType;
        IsPersonally = personally;
    }
    
    private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(ReviewerChanged), nameof(Profile), "profile");
    
    [Required]
    [JsonPropertyName("profile")]
    public TDMemberProfile Profile
    {
        get => _profile.GetValue(InlineErrors);
        set => _profile.SetValue(value);
    }

    private PropertyValue<ReviewerChangedType> _changeType = new PropertyValue<ReviewerChangedType>(nameof(ReviewerChanged), nameof(ChangeType), "changeType");
    
    [Required]
    [JsonPropertyName("changeType")]
    public ReviewerChangedType ChangeType
    {
        get => _changeType.GetValue(InlineErrors);
        set => _changeType.SetValue(value);
    }

    private PropertyValue<bool> _personally = new PropertyValue<bool>(nameof(ReviewerChanged), nameof(IsPersonally), "personally");
    
    [Required]
    [JsonPropertyName("personally")]
    public bool IsPersonally
    {
        get => _personally.GetValue(InlineErrors);
        set => _personally.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _profile.SetAccessPath(parentChainPath, validateHasBeenSet);
        _changeType.SetAccessPath(parentChainPath, validateHasBeenSet);
        _personally.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

