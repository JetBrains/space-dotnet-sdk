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

public sealed class ExternalCheckDTO
     : IPropagatePropertyAccessPath
{
    public ExternalCheckDTO() { }
    
    public ExternalCheckDTO(string repository, string revision, CommitExecutionStatus executionStatus, string url, string externalServiceName, string taskName, string taskId, long timestamp, string? taskBuildId = null, string? description = null)
    {
        Repository = repository;
        Revision = revision;
        ExecutionStatus = executionStatus;
        Url = url;
        ExternalServiceName = externalServiceName;
        TaskName = taskName;
        TaskId = taskId;
        TaskBuildId = taskBuildId;
        Timestamp = timestamp;
        Description = description;
    }
    
    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ExternalCheckDTO), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _revision = new PropertyValue<string>(nameof(ExternalCheckDTO), nameof(Revision), "revision");
    
    [Required]
    [JsonPropertyName("revision")]
    public string Revision
    {
        get => _revision.GetValue(InlineErrors);
        set => _revision.SetValue(value);
    }

    private PropertyValue<CommitExecutionStatus> _executionStatus = new PropertyValue<CommitExecutionStatus>(nameof(ExternalCheckDTO), nameof(ExecutionStatus), "executionStatus");
    
    [Required]
    [JsonPropertyName("executionStatus")]
    public CommitExecutionStatus ExecutionStatus
    {
        get => _executionStatus.GetValue(InlineErrors);
        set => _executionStatus.SetValue(value);
    }

    private PropertyValue<string> _url = new PropertyValue<string>(nameof(ExternalCheckDTO), nameof(Url), "url");
    
    [Required]
    [JsonPropertyName("url")]
    public string Url
    {
        get => _url.GetValue(InlineErrors);
        set => _url.SetValue(value);
    }

    private PropertyValue<string> _externalServiceName = new PropertyValue<string>(nameof(ExternalCheckDTO), nameof(ExternalServiceName), "externalServiceName");
    
    [Required]
    [JsonPropertyName("externalServiceName")]
    public string ExternalServiceName
    {
        get => _externalServiceName.GetValue(InlineErrors);
        set => _externalServiceName.SetValue(value);
    }

    private PropertyValue<string> _taskName = new PropertyValue<string>(nameof(ExternalCheckDTO), nameof(TaskName), "taskName");
    
    [Required]
    [JsonPropertyName("taskName")]
    public string TaskName
    {
        get => _taskName.GetValue(InlineErrors);
        set => _taskName.SetValue(value);
    }

    private PropertyValue<string> _taskId = new PropertyValue<string>(nameof(ExternalCheckDTO), nameof(TaskId), "taskId");
    
    [Required]
    [JsonPropertyName("taskId")]
    public string TaskId
    {
        get => _taskId.GetValue(InlineErrors);
        set => _taskId.SetValue(value);
    }

    private PropertyValue<string?> _taskBuildId = new PropertyValue<string?>(nameof(ExternalCheckDTO), nameof(TaskBuildId), "taskBuildId");
    
    [JsonPropertyName("taskBuildId")]
    public string? TaskBuildId
    {
        get => _taskBuildId.GetValue(InlineErrors);
        set => _taskBuildId.SetValue(value);
    }

    private PropertyValue<long> _timestamp = new PropertyValue<long>(nameof(ExternalCheckDTO), nameof(Timestamp), "timestamp");
    
    [Required]
    [JsonPropertyName("timestamp")]
    public long Timestamp
    {
        get => _timestamp.GetValue(InlineErrors);
        set => _timestamp.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ExternalCheckDTO), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _revision.SetAccessPath(parentChainPath, validateHasBeenSet);
        _executionStatus.SetAccessPath(parentChainPath, validateHasBeenSet);
        _url.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalServiceName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _taskName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _taskId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _taskBuildId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _timestamp.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

