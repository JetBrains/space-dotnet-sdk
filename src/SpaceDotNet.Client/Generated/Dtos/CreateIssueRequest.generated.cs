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
    public class CreateIssueRequest
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(CreateIssueRequest), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CreateIssueRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<string?> _assignee = new PropertyValue<string?>(nameof(CreateIssueRequest), nameof(Assignee));
        
        [JsonPropertyName("assignee")]
        public string? Assignee
        {
            get { return _assignee.GetValue(); }
            set { _assignee.SetValue(value); }
        }
    
        private PropertyValue<string> _status = new PropertyValue<string>(nameof(CreateIssueRequest), nameof(Status));
        
        [Required]
        [JsonPropertyName("status")]
        public string Status
        {
            get { return _status.GetValue(); }
            set { _status.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _dueDate = new PropertyValue<SpaceDate?>(nameof(CreateIssueRequest), nameof(DueDate));
        
        [JsonPropertyName("dueDate")]
        public SpaceDate? DueDate
        {
            get { return _dueDate.GetValue(); }
            set { _dueDate.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _tags = new PropertyValue<List<string>>(nameof(CreateIssueRequest), nameof(Tags));
        
        [Required]
        [JsonPropertyName("tags")]
        public List<string> Tags
        {
            get { return _tags.GetValue(); }
            set { _tags.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _checklists = new PropertyValue<List<string>>(nameof(CreateIssueRequest), nameof(Checklists));
        
        [Required]
        [JsonPropertyName("checklists")]
        public List<string> Checklists
        {
            get { return _checklists.GetValue(); }
            set { _checklists.SetValue(value); }
        }
    
        private PropertyValue<List<AttachmentDto>?> _attachments = new PropertyValue<List<AttachmentDto>?>(nameof(CreateIssueRequest), nameof(Attachments));
        
        [JsonPropertyName("attachments")]
        public List<AttachmentDto>? Attachments
        {
            get { return _attachments.GetValue(); }
            set { _attachments.SetValue(value); }
        }
    
        private PropertyValue<ImportedEntityInfoDto?> _importInfo = new PropertyValue<ImportedEntityInfoDto?>(nameof(CreateIssueRequest), nameof(ImportInfo));
        
        [JsonPropertyName("importInfo")]
        public ImportedEntityInfoDto? ImportInfo
        {
            get { return _importInfo.GetValue(); }
            set { _importInfo.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _title.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _assignee.SetAccessPath(path, validateHasBeenSet);
            _status.SetAccessPath(path, validateHasBeenSet);
            _dueDate.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
            _checklists.SetAccessPath(path, validateHasBeenSet);
            _attachments.SetAccessPath(path, validateHasBeenSet);
            _importInfo.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
