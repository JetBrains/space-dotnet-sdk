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

public sealed class IssueWebhookEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "IssueWebhookEvent";
    
    public IssueWebhookEvent() { }
    
    public IssueWebhookEvent(KMetaMod meta, Issue issue, Modification<string>? title = null, Modification<string>? description = null, Modification<TDMemberProfile>? assignee = null, Modification<IssueStatus>? status = null, Modification<DateTime>? dueDate = null, Modification<List<PlanningTag>>? tagDelta = null, Modification<List<Checklist>>? checklistDelta = null, Modification<List<SprintRecord>>? sprintDelta = null, IssueWebhookCustomFieldUpdate? customFieldUpdate = null, Modification<bool>? deleted = null)
    {
        Meta = meta;
        Issue = issue;
        Title = title;
        Description = description;
        Assignee = assignee;
        Status = status;
        DueDate = dueDate;
        TagDelta = tagDelta;
        ChecklistDelta = checklistDelta;
        SprintDelta = sprintDelta;
        CustomFieldUpdate = customFieldUpdate;
        Deleted = deleted;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(IssueWebhookEvent), nameof(Meta), "meta");
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue(InlineErrors);
        set => _meta.SetValue(value);
    }

    private PropertyValue<Issue> _issue = new PropertyValue<Issue>(nameof(IssueWebhookEvent), nameof(Issue), "issue");
    
    [Required]
    [JsonPropertyName("issue")]
    public Issue Issue
    {
        get => _issue.GetValue(InlineErrors);
        set => _issue.SetValue(value);
    }

    private PropertyValue<Modification<string>?> _title = new PropertyValue<Modification<string>?>(nameof(IssueWebhookEvent), nameof(Title), "title");
    
    [JsonPropertyName("title")]
    public Modification<string>? Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<Modification<string>?> _description = new PropertyValue<Modification<string>?>(nameof(IssueWebhookEvent), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public Modification<string>? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<Modification<TDMemberProfile>?> _assignee = new PropertyValue<Modification<TDMemberProfile>?>(nameof(IssueWebhookEvent), nameof(Assignee), "assignee");
    
    [JsonPropertyName("assignee")]
    public Modification<TDMemberProfile>? Assignee
    {
        get => _assignee.GetValue(InlineErrors);
        set => _assignee.SetValue(value);
    }

    private PropertyValue<Modification<IssueStatus>?> _status = new PropertyValue<Modification<IssueStatus>?>(nameof(IssueWebhookEvent), nameof(Status), "status");
    
    [JsonPropertyName("status")]
    public Modification<IssueStatus>? Status
    {
        get => _status.GetValue(InlineErrors);
        set => _status.SetValue(value);
    }

    private PropertyValue<Modification<DateTime>?> _dueDate = new PropertyValue<Modification<DateTime>?>(nameof(IssueWebhookEvent), nameof(DueDate), "dueDate");
    
    [JsonPropertyName("dueDate")]
    public Modification<DateTime>? DueDate
    {
        get => _dueDate.GetValue(InlineErrors);
        set => _dueDate.SetValue(value);
    }

    private PropertyValue<Modification<List<PlanningTag>>?> _tagDelta = new PropertyValue<Modification<List<PlanningTag>>?>(nameof(IssueWebhookEvent), nameof(TagDelta), "tagDelta");
    
    [JsonPropertyName("tagDelta")]
    public Modification<List<PlanningTag>>? TagDelta
    {
        get => _tagDelta.GetValue(InlineErrors);
        set => _tagDelta.SetValue(value);
    }

    private PropertyValue<Modification<List<Checklist>>?> _checklistDelta = new PropertyValue<Modification<List<Checklist>>?>(nameof(IssueWebhookEvent), nameof(ChecklistDelta), "checklistDelta");
    
    [JsonPropertyName("checklistDelta")]
    public Modification<List<Checklist>>? ChecklistDelta
    {
        get => _checklistDelta.GetValue(InlineErrors);
        set => _checklistDelta.SetValue(value);
    }

    private PropertyValue<Modification<List<SprintRecord>>?> _sprintDelta = new PropertyValue<Modification<List<SprintRecord>>?>(nameof(IssueWebhookEvent), nameof(SprintDelta), "sprintDelta");
    
    [JsonPropertyName("sprintDelta")]
    public Modification<List<SprintRecord>>? SprintDelta
    {
        get => _sprintDelta.GetValue(InlineErrors);
        set => _sprintDelta.SetValue(value);
    }

    private PropertyValue<IssueWebhookCustomFieldUpdate?> _customFieldUpdate = new PropertyValue<IssueWebhookCustomFieldUpdate?>(nameof(IssueWebhookEvent), nameof(CustomFieldUpdate), "customFieldUpdate");
    
    [JsonPropertyName("customFieldUpdate")]
    public IssueWebhookCustomFieldUpdate? CustomFieldUpdate
    {
        get => _customFieldUpdate.GetValue(InlineErrors);
        set => _customFieldUpdate.SetValue(value);
    }

    private PropertyValue<Modification<bool>?> _deleted = new PropertyValue<Modification<bool>?>(nameof(IssueWebhookEvent), nameof(Deleted), "deleted");
    
    [JsonPropertyName("deleted")]
    public Modification<bool>? Deleted
    {
        get => _deleted.GetValue(InlineErrors);
        set => _deleted.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issue.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _assignee.SetAccessPath(parentChainPath, validateHasBeenSet);
        _status.SetAccessPath(parentChainPath, validateHasBeenSet);
        _dueDate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _tagDelta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _checklistDelta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sprintDelta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _customFieldUpdate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deleted.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

