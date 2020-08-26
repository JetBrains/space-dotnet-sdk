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
    public class TeamDirectoryTeamsForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryTeamsForIdPatchRequest() { }
        
        public TeamDirectoryTeamsForIdPatchRequest(string? teamNameRaw = null, string? teamDescription = null, List<string>? teamEmails = null, string? parentId = null, List<CustomFieldValueDto>? customFieldValues = null)
        {
            TeamNameRaw = teamNameRaw;
            TeamDescription = teamDescription;
            TeamEmails = teamEmails;
            ParentId = parentId;
            CustomFieldValues = customFieldValues;
        }
        
        private PropertyValue<string?> _teamNameRaw = new PropertyValue<string?>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(TeamNameRaw));
        
        [JsonPropertyName("teamNameRaw")]
        public string? TeamNameRaw
        {
            get { return _teamNameRaw.GetValue(); }
            set { _teamNameRaw.SetValue(value); }
        }
    
        private PropertyValue<string?> _teamDescription = new PropertyValue<string?>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(TeamDescription));
        
        [JsonPropertyName("teamDescription")]
        public string? TeamDescription
        {
            get { return _teamDescription.GetValue(); }
            set { _teamDescription.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _teamEmails = new PropertyValue<List<string>?>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(TeamEmails));
        
        [JsonPropertyName("teamEmails")]
        public List<string>? TeamEmails
        {
            get { return _teamEmails.GetValue(); }
            set { _teamEmails.SetValue(value); }
        }
    
        private PropertyValue<string?> _parentId = new PropertyValue<string?>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(ParentId));
        
        [JsonPropertyName("parentId")]
        public string? ParentId
        {
            get { return _parentId.GetValue(); }
            set { _parentId.SetValue(value); }
        }
    
        private PropertyValue<List<CustomFieldValueDto>?> _customFieldValues = new PropertyValue<List<CustomFieldValueDto>?>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(CustomFieldValues));
        
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldValueDto>? CustomFieldValues
        {
            get { return _customFieldValues.GetValue(); }
            set { _customFieldValues.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _teamNameRaw.SetAccessPath(path, validateHasBeenSet);
            _teamDescription.SetAccessPath(path, validateHasBeenSet);
            _teamEmails.SetAccessPath(path, validateHasBeenSet);
            _parentId.SetAccessPath(path, validateHasBeenSet);
            _customFieldValues.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
