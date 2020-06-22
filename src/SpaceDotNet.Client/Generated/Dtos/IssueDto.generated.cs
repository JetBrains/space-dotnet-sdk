// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class IssueDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(IssueDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(IssueDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string> _projectId = new PropertyValue<string>(nameof(IssueDto), nameof(ProjectId));
        
        [Required]
        [JsonPropertyName("projectId")]
        public string ProjectId
        {
            get { return _projectId.GetValue(); }
            set { _projectId.SetValue(value); }
        }
    
        private PropertyValue<PRProjectDto?> _projectRef = new PropertyValue<PRProjectDto?>(nameof(IssueDto), nameof(ProjectRef));
        
        [JsonPropertyName("projectRef")]
        public PRProjectDto? ProjectRef
        {
            get { return _projectRef.GetValue(); }
            set { _projectRef.SetValue(value); }
        }
    
        private PropertyValue<int> _number = new PropertyValue<int>(nameof(IssueDto), nameof(Number));
        
        [Required]
        [JsonPropertyName("number")]
        public int Number
        {
            get { return _number.GetValue(); }
            set { _number.SetValue(value); }
        }
    
        private PropertyValue<CPrincipalDto> _createdBy = new PropertyValue<CPrincipalDto>(nameof(IssueDto), nameof(CreatedBy));
        
        [Required]
        [JsonPropertyName("createdBy")]
        public CPrincipalDto CreatedBy
        {
            get { return _createdBy.GetValue(); }
            set { _createdBy.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _creationTime = new PropertyValue<SpaceTime>(nameof(IssueDto), nameof(CreationTime));
        
        [Required]
        [JsonPropertyName("creationTime")]
        public SpaceTime CreationTime
        {
            get { return _creationTime.GetValue(); }
            set { _creationTime.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto?> _assignee = new PropertyValue<TDMemberProfileDto?>(nameof(IssueDto), nameof(Assignee));
        
        [JsonPropertyName("assignee")]
        public TDMemberProfileDto? Assignee
        {
            get { return _assignee.GetValue(); }
            set { _assignee.SetValue(value); }
        }
    
        private PropertyValue<IssueStatusDto> _status = new PropertyValue<IssueStatusDto>(nameof(IssueDto), nameof(Status));
        
        [Required]
        [JsonPropertyName("status")]
        public IssueStatusDto Status
        {
            get { return _status.GetValue(); }
            set { _status.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _dueDate = new PropertyValue<SpaceDate?>(nameof(IssueDto), nameof(DueDate));
        
        [JsonPropertyName("dueDate")]
        public SpaceDate? DueDate
        {
            get { return _dueDate.GetValue(); }
            set { _dueDate.SetValue(value); }
        }
    
        private PropertyValue<ImportedEntityInfoDto?> _importInfo = new PropertyValue<ImportedEntityInfoDto?>(nameof(IssueDto), nameof(ImportInfo));
        
        [JsonPropertyName("importInfo")]
        public ImportedEntityInfoDto? ImportInfo
        {
            get { return _importInfo.GetValue(); }
            set { _importInfo.SetValue(value); }
        }
    
        private PropertyValue<List<PlanningTagDto>> _tags = new PropertyValue<List<PlanningTagDto>>(nameof(IssueDto), nameof(Tags));
        
        [Required]
        [JsonPropertyName("tags")]
        public List<PlanningTagDto> Tags
        {
            get { return _tags.GetValue(); }
            set { _tags.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(IssueDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<List<ChecklistDto>> _checklists = new PropertyValue<List<ChecklistDto>>(nameof(IssueDto), nameof(Checklists));
        
        [Required]
        [JsonPropertyName("checklists")]
        public List<ChecklistDto> Checklists
        {
            get { return _checklists.GetValue(); }
            set { _checklists.SetValue(value); }
        }
    
        private PropertyValue<List<AttachmentInfoDto>> _attachments = new PropertyValue<List<AttachmentInfoDto>>(nameof(IssueDto), nameof(Attachments));
        
        [Required]
        [JsonPropertyName("attachments")]
        public List<AttachmentInfoDto> Attachments
        {
            get { return _attachments.GetValue(); }
            set { _attachments.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelRecordDto> _channel = new PropertyValue<M2ChannelRecordDto>(nameof(IssueDto), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecordDto Channel
        {
            get { return _channel.GetValue(); }
            set { _channel.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(IssueDto), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path + "->WithId()", validateHasBeenSet);
            _archived.SetAccessPath(path + "->WithArchived()", validateHasBeenSet);
            _projectId.SetAccessPath(path + "->WithProjectId()", validateHasBeenSet);
            _projectRef.SetAccessPath(path + "->WithProjectRef()", validateHasBeenSet);
            _number.SetAccessPath(path + "->WithNumber()", validateHasBeenSet);
            _createdBy.SetAccessPath(path + "->WithCreatedBy()", validateHasBeenSet);
            _creationTime.SetAccessPath(path + "->WithCreationTime()", validateHasBeenSet);
            _assignee.SetAccessPath(path + "->WithAssignee()", validateHasBeenSet);
            _status.SetAccessPath(path + "->WithStatus()", validateHasBeenSet);
            _dueDate.SetAccessPath(path + "->WithDueDate()", validateHasBeenSet);
            _importInfo.SetAccessPath(path + "->WithImportInfo()", validateHasBeenSet);
            _tags.SetAccessPath(path + "->WithTags()", validateHasBeenSet);
            _title.SetAccessPath(path + "->WithTitle()", validateHasBeenSet);
            _checklists.SetAccessPath(path + "->WithChecklists()", validateHasBeenSet);
            _attachments.SetAccessPath(path + "->WithAttachments()", validateHasBeenSet);
            _channel.SetAccessPath(path + "->WithChannel()", validateHasBeenSet);
            _description.SetAccessPath(path + "->WithDescription()", validateHasBeenSet);
        }
    
    }
    
}
