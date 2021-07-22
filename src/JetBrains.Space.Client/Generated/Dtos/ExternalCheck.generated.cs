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

namespace JetBrains.Space.Client
{
    public sealed class ExternalCheck
         : IPropagatePropertyAccessPath
    {
        public ExternalCheck() { }
        
        public ExternalCheck(string repository, string revision, CommitExecutionStatus executionStatus, string url, string externalServiceName, string taskName, string taskId, long timestamp, string? description = null)
        {
            Repository = repository;
            Revision = revision;
            ExecutionStatus = executionStatus;
            Url = url;
            ExternalServiceName = externalServiceName;
            TaskName = taskName;
            TaskId = taskId;
            Timestamp = timestamp;
            Description = description;
        }
        
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ExternalCheck), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _revision = new PropertyValue<string>(nameof(ExternalCheck), nameof(Revision));
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision
        {
            get => _revision.GetValue();
            set => _revision.SetValue(value);
        }
    
        private PropertyValue<CommitExecutionStatus> _executionStatus = new PropertyValue<CommitExecutionStatus>(nameof(ExternalCheck), nameof(ExecutionStatus));
        
        [Required]
        [JsonPropertyName("executionStatus")]
        public CommitExecutionStatus ExecutionStatus
        {
            get => _executionStatus.GetValue();
            set => _executionStatus.SetValue(value);
        }
    
        private PropertyValue<string> _url = new PropertyValue<string>(nameof(ExternalCheck), nameof(Url));
        
        [Required]
        [JsonPropertyName("url")]
        public string Url
        {
            get => _url.GetValue();
            set => _url.SetValue(value);
        }
    
        private PropertyValue<string> _externalServiceName = new PropertyValue<string>(nameof(ExternalCheck), nameof(ExternalServiceName));
        
        [Required]
        [JsonPropertyName("externalServiceName")]
        public string ExternalServiceName
        {
            get => _externalServiceName.GetValue();
            set => _externalServiceName.SetValue(value);
        }
    
        private PropertyValue<string> _taskName = new PropertyValue<string>(nameof(ExternalCheck), nameof(TaskName));
        
        [Required]
        [JsonPropertyName("taskName")]
        public string TaskName
        {
            get => _taskName.GetValue();
            set => _taskName.SetValue(value);
        }
    
        private PropertyValue<string> _taskId = new PropertyValue<string>(nameof(ExternalCheck), nameof(TaskId));
        
        [Required]
        [JsonPropertyName("taskId")]
        public string TaskId
        {
            get => _taskId.GetValue();
            set => _taskId.SetValue(value);
        }
    
        private PropertyValue<long> _timestamp = new PropertyValue<long>(nameof(ExternalCheck), nameof(Timestamp));
        
        [Required]
        [JsonPropertyName("timestamp")]
        public long Timestamp
        {
            get => _timestamp.GetValue();
            set => _timestamp.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ExternalCheck), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _repository.SetAccessPath(path, validateHasBeenSet);
            _revision.SetAccessPath(path, validateHasBeenSet);
            _executionStatus.SetAccessPath(path, validateHasBeenSet);
            _url.SetAccessPath(path, validateHasBeenSet);
            _externalServiceName.SetAccessPath(path, validateHasBeenSet);
            _taskName.SetAccessPath(path, validateHasBeenSet);
            _taskId.SetAccessPath(path, validateHasBeenSet);
            _timestamp.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
