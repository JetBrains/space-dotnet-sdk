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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class M2ChannelAutomationJobFeedInfo
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelAutomationJobFeedInfo";
        
        public M2ChannelAutomationJobFeedInfo() { }
        
        public M2ChannelAutomationJobFeedInfo(JobSubscription jobSubscription, string jobName, ChannelSpecificDefaults notificationDefaults, string? repoName = null)
        {
            JobSubscription = jobSubscription;
            JobName = jobName;
            RepoName = repoName;
            NotificationDefaults = notificationDefaults;
        }
        
        private PropertyValue<JobSubscription> _jobSubscription = new PropertyValue<JobSubscription>(nameof(M2ChannelAutomationJobFeedInfo), nameof(JobSubscription));
        
        [Required]
        [JsonPropertyName("jobSubscription")]
        public JobSubscription JobSubscription
        {
            get => _jobSubscription.GetValue();
            set => _jobSubscription.SetValue(value);
        }
    
        private PropertyValue<string> _jobName = new PropertyValue<string>(nameof(M2ChannelAutomationJobFeedInfo), nameof(JobName));
        
        [Required]
        [JsonPropertyName("jobName")]
        public string JobName
        {
            get => _jobName.GetValue();
            set => _jobName.SetValue(value);
        }
    
        private PropertyValue<string?> _repoName = new PropertyValue<string?>(nameof(M2ChannelAutomationJobFeedInfo), nameof(RepoName));
        
        [JsonPropertyName("repoName")]
        public string? RepoName
        {
            get => _repoName.GetValue();
            set => _repoName.SetValue(value);
        }
    
        private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2ChannelAutomationJobFeedInfo), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaults NotificationDefaults
        {
            get => _notificationDefaults.GetValue();
            set => _notificationDefaults.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _jobSubscription.SetAccessPath(path, validateHasBeenSet);
            _jobName.SetAccessPath(path, validateHasBeenSet);
            _repoName.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}