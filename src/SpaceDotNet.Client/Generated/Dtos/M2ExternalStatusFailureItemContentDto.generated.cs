// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class M2ExternalStatusFailureItemContentDto
         : M2ItemContentDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ExternalStatusFailureItemContent";
        
        public M2ExternalStatusFailureItemContentDto() { }
        
        public M2ExternalStatusFailureItemContentDto(string repository, string branch, string url, string externalServiceName, string taskName, string? projectId = null, RevisionAuthorInfoDto? revisionInfo = null, LastChangesDto? changesInfo = null, long? timestamp = null, string? description = null)
        {
            ProjectId = projectId;
            Repository = repository;
            Branch = branch;
            RevisionInfo = revisionInfo;
            ChangesInfo = changesInfo;
            Url = url;
            ExternalServiceName = externalServiceName;
            TaskName = taskName;
            Timestamp = timestamp;
            Description = description;
        }
        
        private PropertyValue<string?> _projectId = new PropertyValue<string?>(nameof(M2ExternalStatusFailureItemContentDto), nameof(ProjectId));
        
        [JsonPropertyName("projectId")]
        public string? ProjectId
        {
            get { return _projectId.GetValue(); }
            set { _projectId.SetValue(value); }
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(M2ExternalStatusFailureItemContentDto), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<string> _branch = new PropertyValue<string>(nameof(M2ExternalStatusFailureItemContentDto), nameof(Branch));
        
        [Required]
        [JsonPropertyName("branch")]
        public string Branch
        {
            get { return _branch.GetValue(); }
            set { _branch.SetValue(value); }
        }
    
        private PropertyValue<RevisionAuthorInfoDto?> _revisionInfo = new PropertyValue<RevisionAuthorInfoDto?>(nameof(M2ExternalStatusFailureItemContentDto), nameof(RevisionInfo));
        
        [JsonPropertyName("revisionInfo")]
        public RevisionAuthorInfoDto? RevisionInfo
        {
            get { return _revisionInfo.GetValue(); }
            set { _revisionInfo.SetValue(value); }
        }
    
        private PropertyValue<LastChangesDto?> _changesInfo = new PropertyValue<LastChangesDto?>(nameof(M2ExternalStatusFailureItemContentDto), nameof(ChangesInfo));
        
        [JsonPropertyName("changesInfo")]
        public LastChangesDto? ChangesInfo
        {
            get { return _changesInfo.GetValue(); }
            set { _changesInfo.SetValue(value); }
        }
    
        private PropertyValue<string> _url = new PropertyValue<string>(nameof(M2ExternalStatusFailureItemContentDto), nameof(Url));
        
        [Required]
        [JsonPropertyName("url")]
        public string Url
        {
            get { return _url.GetValue(); }
            set { _url.SetValue(value); }
        }
    
        private PropertyValue<string> _externalServiceName = new PropertyValue<string>(nameof(M2ExternalStatusFailureItemContentDto), nameof(ExternalServiceName));
        
        [Required]
        [JsonPropertyName("externalServiceName")]
        public string ExternalServiceName
        {
            get { return _externalServiceName.GetValue(); }
            set { _externalServiceName.SetValue(value); }
        }
    
        private PropertyValue<string> _taskName = new PropertyValue<string>(nameof(M2ExternalStatusFailureItemContentDto), nameof(TaskName));
        
        [Required]
        [JsonPropertyName("taskName")]
        public string TaskName
        {
            get { return _taskName.GetValue(); }
            set { _taskName.SetValue(value); }
        }
    
        private PropertyValue<long?> _timestamp = new PropertyValue<long?>(nameof(M2ExternalStatusFailureItemContentDto), nameof(Timestamp));
        
        [JsonPropertyName("timestamp")]
        public long? Timestamp
        {
            get { return _timestamp.GetValue(); }
            set { _timestamp.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(M2ExternalStatusFailureItemContentDto), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _projectId.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _branch.SetAccessPath(path, validateHasBeenSet);
            _revisionInfo.SetAccessPath(path, validateHasBeenSet);
            _changesInfo.SetAccessPath(path, validateHasBeenSet);
            _url.SetAccessPath(path, validateHasBeenSet);
            _externalServiceName.SetAccessPath(path, validateHasBeenSet);
            _taskName.SetAccessPath(path, validateHasBeenSet);
            _timestamp.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
