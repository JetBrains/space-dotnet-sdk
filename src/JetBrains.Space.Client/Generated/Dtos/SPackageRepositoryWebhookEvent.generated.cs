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
    public sealed class SPackageRepositoryWebhookEvent
         : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "SPackageRepositoryWebhookEvent";
        
        public SPackageRepositoryWebhookEvent() { }
        
        public SPackageRepositoryWebhookEvent(ProjectKey projectKey, string repository, PackageType repositoryType, PackageRepositoryEventAction action, PackageVersionRef packageInfo)
        {
            ProjectKey = projectKey;
            Repository = repository;
            RepositoryType = repositoryType;
            Action = action;
            PackageInfo = packageInfo;
        }
        
        private PropertyValue<ProjectKey> _projectKey = new PropertyValue<ProjectKey>(nameof(SPackageRepositoryWebhookEvent), nameof(ProjectKey));
        
        [Required]
        [JsonPropertyName("projectKey")]
        public ProjectKey ProjectKey
        {
            get => _projectKey.GetValue();
            set => _projectKey.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(SPackageRepositoryWebhookEvent), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<PackageType> _repositoryType = new PropertyValue<PackageType>(nameof(SPackageRepositoryWebhookEvent), nameof(RepositoryType));
        
        [Required]
        [JsonPropertyName("repositoryType")]
        public PackageType RepositoryType
        {
            get => _repositoryType.GetValue();
            set => _repositoryType.SetValue(value);
        }
    
        private PropertyValue<PackageRepositoryEventAction> _action = new PropertyValue<PackageRepositoryEventAction>(nameof(SPackageRepositoryWebhookEvent), nameof(Action));
        
        [Required]
        [JsonPropertyName("action")]
        public PackageRepositoryEventAction Action
        {
            get => _action.GetValue();
            set => _action.SetValue(value);
        }
    
        private PropertyValue<PackageVersionRef> _packageInfo = new PropertyValue<PackageVersionRef>(nameof(SPackageRepositoryWebhookEvent), nameof(PackageInfo));
        
        [Required]
        [JsonPropertyName("packageInfo")]
        public PackageVersionRef PackageInfo
        {
            get => _packageInfo.GetValue();
            set => _packageInfo.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _projectKey.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _repositoryType.SetAccessPath(path, validateHasBeenSet);
            _action.SetAccessPath(path, validateHasBeenSet);
            _packageInfo.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
