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

public sealed class IssueImportResult
     : IPropagatePropertyAccessPath
{
    public IssueImportResult() { }
    
    public IssueImportResult(string message, List<IssueImportResultItem>? created = null, List<IssueImportResultItem>? updated = null, List<IssueImportResultItem>? skipped = null, List<string>? missingAttributes = null)
    {
        Message = message;
        Created = created;
        Updated = updated;
        Skipped = skipped;
        MissingAttributes = missingAttributes;
    }
    
    private PropertyValue<string> _message = new PropertyValue<string>(nameof(IssueImportResult), nameof(Message), "message");
    
    [Required]
    [JsonPropertyName("message")]
    public string Message
    {
        get => _message.GetValue(InlineErrors);
        set => _message.SetValue(value);
    }

    private PropertyValue<List<IssueImportResultItem>?> _created = new PropertyValue<List<IssueImportResultItem>?>(nameof(IssueImportResult), nameof(Created), "created");
    
    [JsonPropertyName("created")]
    public List<IssueImportResultItem>? Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<List<IssueImportResultItem>?> _updated = new PropertyValue<List<IssueImportResultItem>?>(nameof(IssueImportResult), nameof(Updated), "updated");
    
    [JsonPropertyName("updated")]
    public List<IssueImportResultItem>? Updated
    {
        get => _updated.GetValue(InlineErrors);
        set => _updated.SetValue(value);
    }

    private PropertyValue<List<IssueImportResultItem>?> _skipped = new PropertyValue<List<IssueImportResultItem>?>(nameof(IssueImportResult), nameof(Skipped), "skipped");
    
    [JsonPropertyName("skipped")]
    public List<IssueImportResultItem>? Skipped
    {
        get => _skipped.GetValue(InlineErrors);
        set => _skipped.SetValue(value);
    }

    private PropertyValue<List<string>?> _missingAttributes = new PropertyValue<List<string>?>(nameof(IssueImportResult), nameof(MissingAttributes), "missingAttributes");
    
    [JsonPropertyName("missingAttributes")]
    public List<string>? MissingAttributes
    {
        get => _missingAttributes.GetValue(InlineErrors);
        set => _missingAttributes.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _message.SetAccessPath(parentChainPath, validateHasBeenSet);
        _created.SetAccessPath(parentChainPath, validateHasBeenSet);
        _updated.SetAccessPath(parentChainPath, validateHasBeenSet);
        _skipped.SetAccessPath(parentChainPath, validateHasBeenSet);
        _missingAttributes.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

