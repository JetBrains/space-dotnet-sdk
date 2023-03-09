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

public class ProjectsForProjectCodeReviewsForReviewIdUnboundDiscussionsForDiscussionIdTogglePatchRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectCodeReviewsForReviewIdUnboundDiscussionsForDiscussionIdTogglePatchRequest() { }
    
    public ProjectsForProjectCodeReviewsForReviewIdUnboundDiscussionsForDiscussionIdTogglePatchRequest(bool? resolved = null)
    {
        IsResolved = resolved;
    }
    
    private PropertyValue<bool?> _resolved = new PropertyValue<bool?>(nameof(ProjectsForProjectCodeReviewsForReviewIdUnboundDiscussionsForDiscussionIdTogglePatchRequest), nameof(IsResolved), "resolved");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("resolved")]
    public bool? IsResolved
    {
        get => _resolved.GetValue(InlineErrors);
        set => _resolved.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _resolved.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

