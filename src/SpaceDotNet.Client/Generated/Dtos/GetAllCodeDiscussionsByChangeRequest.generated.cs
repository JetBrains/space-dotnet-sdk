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
    public class GetAllCodeDiscussionsByChangeRequest
    {
        private PropertyValue<ProjectKeyDto> _projectKey = new PropertyValue<ProjectKeyDto>(nameof(GetAllCodeDiscussionsByChangeRequest), nameof(ProjectKey));
        
        [Required]
        [JsonPropertyName("projectKey")]
        public ProjectKeyDto ProjectKey { get { return _projectKey.GetValue(); } set { _projectKey.SetValue(value); } }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(GetAllCodeDiscussionsByChangeRequest), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository { get { return _repository.GetValue(); } set { _repository.SetValue(value); } }
    
        private PropertyValue<List<string>> _revisions = new PropertyValue<List<string>>(nameof(GetAllCodeDiscussionsByChangeRequest), nameof(Revisions));
        
        [Required]
        [JsonPropertyName("revisions")]
        public List<string> Revisions { get { return _revisions.GetValue(); } set { _revisions.SetValue(value); } }
    
        private PropertyValue<GitCommitChangeDto> _change = new PropertyValue<GitCommitChangeDto>(nameof(GetAllCodeDiscussionsByChangeRequest), nameof(Change));
        
        [Required]
        [JsonPropertyName("change")]
        public GitCommitChangeDto Change { get { return _change.GetValue(); } set { _change.SetValue(value); } }
    
    }
    
}
