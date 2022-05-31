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

public sealed class Issue
     : IPropagatePropertyAccessPath
{
    public Issue() { }
    
    public Issue(string id, bool archived, PRProject projectRef, int number, CPrincipal createdBy, DateTime creationTime, IssueStatus status, List<PlanningTag> tags, string title, List<AttachmentInfo> attachments, M2ChannelRecord channel, List<Checklist> checklists, Dictionary<string, CFValue> customFields, List<SprintRecord> sprints, List<Topic> topics, string? projectId = null, IssueTracker? trackerRef = null, TDMemberProfile? assignee = null, DateTime? dueDate = null, ExternalEntityInfoRecord? externalEntityInfo = null, int? attachmentsCount = null, int? subItemsCount = null, int? doneSubItemsCount = null, int? commentsCount = null, CPrincipal? deletedBy = null, DateTime? deletedTime = null, ChannelItemRecord? messageOrigin = null, string? description = null, List<AttachmentInfo>? unfurls = null)
    {
        Id = id;
        IsArchived = archived;
        ProjectId = projectId;
        ProjectRef = projectRef;
        TrackerRef = trackerRef;
        Number = number;
        CreatedBy = createdBy;
        CreationTime = creationTime;
        Assignee = assignee;
        Status = status;
        DueDate = dueDate;
        ExternalEntityInfo = externalEntityInfo;
        Tags = tags;
        Title = title;
        AttachmentsCount = attachmentsCount;
        SubItemsCount = subItemsCount;
        DoneSubItemsCount = doneSubItemsCount;
        CommentsCount = commentsCount;
        DeletedBy = deletedBy;
        DeletedTime = deletedTime;
        MessageOrigin = messageOrigin;
        Attachments = attachments;
        Channel = channel;
        Checklists = checklists;
        CustomFields = customFields;
        Description = description;
        Sprints = sprints;
        Topics = topics;
        Unfurls = unfurls;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(Issue), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(Issue), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<string?> _projectId = new PropertyValue<string?>(nameof(Issue), nameof(ProjectId), "projectId");
    
    [JsonPropertyName("projectId")]
    public string? ProjectId
    {
        get => _projectId.GetValue(InlineErrors);
        set => _projectId.SetValue(value);
    }

    private PropertyValue<PRProject> _projectRef = new PropertyValue<PRProject>(nameof(Issue), nameof(ProjectRef), "projectRef");
    
    [Required]
    [JsonPropertyName("projectRef")]
    public PRProject ProjectRef
    {
        get => _projectRef.GetValue(InlineErrors);
        set => _projectRef.SetValue(value);
    }

    private PropertyValue<IssueTracker?> _trackerRef = new PropertyValue<IssueTracker?>(nameof(Issue), nameof(TrackerRef), "trackerRef");
    
    [JsonPropertyName("trackerRef")]
    public IssueTracker? TrackerRef
    {
        get => _trackerRef.GetValue(InlineErrors);
        set => _trackerRef.SetValue(value);
    }

    private PropertyValue<int> _number = new PropertyValue<int>(nameof(Issue), nameof(Number), "number");
    
    [Required]
    [JsonPropertyName("number")]
    public int Number
    {
        get => _number.GetValue(InlineErrors);
        set => _number.SetValue(value);
    }

    private PropertyValue<CPrincipal> _createdBy = new PropertyValue<CPrincipal>(nameof(Issue), nameof(CreatedBy), "createdBy");
    
    [Required]
    [JsonPropertyName("createdBy")]
    public CPrincipal CreatedBy
    {
        get => _createdBy.GetValue(InlineErrors);
        set => _createdBy.SetValue(value);
    }

    private PropertyValue<DateTime> _creationTime = new PropertyValue<DateTime>(nameof(Issue), nameof(CreationTime), "creationTime");
    
    [Required]
    [JsonPropertyName("creationTime")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime CreationTime
    {
        get => _creationTime.GetValue(InlineErrors);
        set => _creationTime.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _assignee = new PropertyValue<TDMemberProfile?>(nameof(Issue), nameof(Assignee), "assignee");
    
    [JsonPropertyName("assignee")]
    public TDMemberProfile? Assignee
    {
        get => _assignee.GetValue(InlineErrors);
        set => _assignee.SetValue(value);
    }

    private PropertyValue<IssueStatus> _status = new PropertyValue<IssueStatus>(nameof(Issue), nameof(Status), "status");
    
    [Required]
    [JsonPropertyName("status")]
    public IssueStatus Status
    {
        get => _status.GetValue(InlineErrors);
        set => _status.SetValue(value);
    }

    private PropertyValue<DateTime?> _dueDate = new PropertyValue<DateTime?>(nameof(Issue), nameof(DueDate), "dueDate");
    
    [JsonPropertyName("dueDate")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? DueDate
    {
        get => _dueDate.GetValue(InlineErrors);
        set => _dueDate.SetValue(value);
    }

    private PropertyValue<ExternalEntityInfoRecord?> _externalEntityInfo = new PropertyValue<ExternalEntityInfoRecord?>(nameof(Issue), nameof(ExternalEntityInfo), "externalEntityInfo");
    
    [JsonPropertyName("externalEntityInfo")]
    public ExternalEntityInfoRecord? ExternalEntityInfo
    {
        get => _externalEntityInfo.GetValue(InlineErrors);
        set => _externalEntityInfo.SetValue(value);
    }

    private PropertyValue<List<PlanningTag>> _tags = new PropertyValue<List<PlanningTag>>(nameof(Issue), nameof(Tags), "tags", new List<PlanningTag>());
    
    [Required]
    [JsonPropertyName("tags")]
    public List<PlanningTag> Tags
    {
        get => _tags.GetValue(InlineErrors);
        set => _tags.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(Issue), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<int?> _attachmentsCount = new PropertyValue<int?>(nameof(Issue), nameof(AttachmentsCount), "attachmentsCount");
    
    [JsonPropertyName("attachmentsCount")]
    public int? AttachmentsCount
    {
        get => _attachmentsCount.GetValue(InlineErrors);
        set => _attachmentsCount.SetValue(value);
    }

    private PropertyValue<int?> _subItemsCount = new PropertyValue<int?>(nameof(Issue), nameof(SubItemsCount), "subItemsCount");
    
    [JsonPropertyName("subItemsCount")]
    public int? SubItemsCount
    {
        get => _subItemsCount.GetValue(InlineErrors);
        set => _subItemsCount.SetValue(value);
    }

    private PropertyValue<int?> _doneSubItemsCount = new PropertyValue<int?>(nameof(Issue), nameof(DoneSubItemsCount), "doneSubItemsCount");
    
    [JsonPropertyName("doneSubItemsCount")]
    public int? DoneSubItemsCount
    {
        get => _doneSubItemsCount.GetValue(InlineErrors);
        set => _doneSubItemsCount.SetValue(value);
    }

    private PropertyValue<int?> _commentsCount = new PropertyValue<int?>(nameof(Issue), nameof(CommentsCount), "commentsCount");
    
    [JsonPropertyName("commentsCount")]
    public int? CommentsCount
    {
        get => _commentsCount.GetValue(InlineErrors);
        set => _commentsCount.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _deletedBy = new PropertyValue<CPrincipal?>(nameof(Issue), nameof(DeletedBy), "deletedBy");
    
    [JsonPropertyName("deletedBy")]
    public CPrincipal? DeletedBy
    {
        get => _deletedBy.GetValue(InlineErrors);
        set => _deletedBy.SetValue(value);
    }

    private PropertyValue<DateTime?> _deletedTime = new PropertyValue<DateTime?>(nameof(Issue), nameof(DeletedTime), "deletedTime");
    
    [JsonPropertyName("deletedTime")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? DeletedTime
    {
        get => _deletedTime.GetValue(InlineErrors);
        set => _deletedTime.SetValue(value);
    }

    private PropertyValue<ChannelItemRecord?> _messageOrigin = new PropertyValue<ChannelItemRecord?>(nameof(Issue), nameof(MessageOrigin), "messageOrigin");
    
    [JsonPropertyName("messageOrigin")]
    public ChannelItemRecord? MessageOrigin
    {
        get => _messageOrigin.GetValue(InlineErrors);
        set => _messageOrigin.SetValue(value);
    }

    private PropertyValue<List<AttachmentInfo>> _attachments = new PropertyValue<List<AttachmentInfo>>(nameof(Issue), nameof(Attachments), "attachments", new List<AttachmentInfo>());
    
    [Required]
    [JsonPropertyName("attachments")]
    public List<AttachmentInfo> Attachments
    {
        get => _attachments.GetValue(InlineErrors);
        set => _attachments.SetValue(value);
    }

    private PropertyValue<M2ChannelRecord> _channel = new PropertyValue<M2ChannelRecord>(nameof(Issue), nameof(Channel), "channel");
    
    [Required]
    [JsonPropertyName("channel")]
    public M2ChannelRecord Channel
    {
        get => _channel.GetValue(InlineErrors);
        set => _channel.SetValue(value);
    }

    private PropertyValue<List<Checklist>> _checklists = new PropertyValue<List<Checklist>>(nameof(Issue), nameof(Checklists), "checklists", new List<Checklist>());
    
    [Required]
    [JsonPropertyName("checklists")]
    public List<Checklist> Checklists
    {
        get => _checklists.GetValue(InlineErrors);
        set => _checklists.SetValue(value);
    }

    private PropertyValue<Dictionary<string, CFValue>> _customFields = new PropertyValue<Dictionary<string, CFValue>>(nameof(Issue), nameof(CustomFields), "customFields", new Dictionary<string, CFValue>());
    
    [Required]
    [JsonPropertyName("customFields")]
    public Dictionary<string, CFValue> CustomFields
    {
        get => _customFields.GetValue(InlineErrors);
        set => _customFields.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(Issue), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<List<SprintRecord>> _sprints = new PropertyValue<List<SprintRecord>>(nameof(Issue), nameof(Sprints), "sprints", new List<SprintRecord>());
    
    [Required]
    [JsonPropertyName("sprints")]
    public List<SprintRecord> Sprints
    {
        get => _sprints.GetValue(InlineErrors);
        set => _sprints.SetValue(value);
    }

    private PropertyValue<List<Topic>> _topics = new PropertyValue<List<Topic>>(nameof(Issue), nameof(Topics), "topics", new List<Topic>());
    
    [Required]
    [JsonPropertyName("topics")]
    public List<Topic> Topics
    {
        get => _topics.GetValue(InlineErrors);
        set => _topics.SetValue(value);
    }

    private PropertyValue<List<AttachmentInfo>?> _unfurls = new PropertyValue<List<AttachmentInfo>?>(nameof(Issue), nameof(Unfurls), "unfurls");
    
    [JsonPropertyName("unfurls")]
    public List<AttachmentInfo>? Unfurls
    {
        get => _unfurls.GetValue(InlineErrors);
        set => _unfurls.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectRef.SetAccessPath(parentChainPath, validateHasBeenSet);
        _trackerRef.SetAccessPath(parentChainPath, validateHasBeenSet);
        _number.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _creationTime.SetAccessPath(parentChainPath, validateHasBeenSet);
        _assignee.SetAccessPath(parentChainPath, validateHasBeenSet);
        _status.SetAccessPath(parentChainPath, validateHasBeenSet);
        _dueDate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalEntityInfo.SetAccessPath(parentChainPath, validateHasBeenSet);
        _tags.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachmentsCount.SetAccessPath(parentChainPath, validateHasBeenSet);
        _subItemsCount.SetAccessPath(parentChainPath, validateHasBeenSet);
        _doneSubItemsCount.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commentsCount.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deletedBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deletedTime.SetAccessPath(parentChainPath, validateHasBeenSet);
        _messageOrigin.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _channel.SetAccessPath(parentChainPath, validateHasBeenSet);
        _checklists.SetAccessPath(parentChainPath, validateHasBeenSet);
        _customFields.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sprints.SetAccessPath(parentChainPath, validateHasBeenSet);
        _topics.SetAccessPath(parentChainPath, validateHasBeenSet);
        _unfurls.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

