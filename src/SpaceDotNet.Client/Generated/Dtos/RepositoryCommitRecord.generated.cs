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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class RepositoryCommitRecord
         : IPropagatePropertyAccessPath
    {
        public RepositoryCommitRecord() { }
        
        public RepositoryCommitRecord(string id, string repositoryId, string repositoryName, string revision, SpaceTime date, string? message = null, string? authorName = null, string? authorEmail = null, string? committerName = null, string? committerEmail = null, TDMemberProfile? authorProfile = null)
        {
            Id = id;
            RepositoryId = repositoryId;
            RepositoryName = repositoryName;
            Revision = revision;
            Message = message;
            Date = date;
            AuthorName = authorName;
            AuthorEmail = authorEmail;
            CommitterName = committerName;
            CommitterEmail = committerEmail;
            AuthorProfile = authorProfile;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(RepositoryCommitRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _repositoryId = new PropertyValue<string>(nameof(RepositoryCommitRecord), nameof(RepositoryId));
        
        [Required]
        [JsonPropertyName("repositoryId")]
        public string RepositoryId
        {
            get { return _repositoryId.GetValue(); }
            set { _repositoryId.SetValue(value); }
        }
    
        private PropertyValue<string> _repositoryName = new PropertyValue<string>(nameof(RepositoryCommitRecord), nameof(RepositoryName));
        
        [Required]
        [JsonPropertyName("repositoryName")]
        public string RepositoryName
        {
            get { return _repositoryName.GetValue(); }
            set { _repositoryName.SetValue(value); }
        }
    
        private PropertyValue<string> _revision = new PropertyValue<string>(nameof(RepositoryCommitRecord), nameof(Revision));
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision
        {
            get { return _revision.GetValue(); }
            set { _revision.SetValue(value); }
        }
    
        private PropertyValue<string?> _message = new PropertyValue<string?>(nameof(RepositoryCommitRecord), nameof(Message));
        
        [JsonPropertyName("message")]
        public string? Message
        {
            get { return _message.GetValue(); }
            set { _message.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _date = new PropertyValue<SpaceTime>(nameof(RepositoryCommitRecord), nameof(Date));
        
        [Required]
        [JsonPropertyName("date")]
        public SpaceTime Date
        {
            get { return _date.GetValue(); }
            set { _date.SetValue(value); }
        }
    
        private PropertyValue<string?> _authorName = new PropertyValue<string?>(nameof(RepositoryCommitRecord), nameof(AuthorName));
        
        [JsonPropertyName("authorName")]
        public string? AuthorName
        {
            get { return _authorName.GetValue(); }
            set { _authorName.SetValue(value); }
        }
    
        private PropertyValue<string?> _authorEmail = new PropertyValue<string?>(nameof(RepositoryCommitRecord), nameof(AuthorEmail));
        
        [JsonPropertyName("authorEmail")]
        public string? AuthorEmail
        {
            get { return _authorEmail.GetValue(); }
            set { _authorEmail.SetValue(value); }
        }
    
        private PropertyValue<string?> _committerName = new PropertyValue<string?>(nameof(RepositoryCommitRecord), nameof(CommitterName));
        
        [JsonPropertyName("committerName")]
        public string? CommitterName
        {
            get { return _committerName.GetValue(); }
            set { _committerName.SetValue(value); }
        }
    
        private PropertyValue<string?> _committerEmail = new PropertyValue<string?>(nameof(RepositoryCommitRecord), nameof(CommitterEmail));
        
        [JsonPropertyName("committerEmail")]
        public string? CommitterEmail
        {
            get { return _committerEmail.GetValue(); }
            set { _committerEmail.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile?> _authorProfile = new PropertyValue<TDMemberProfile?>(nameof(RepositoryCommitRecord), nameof(AuthorProfile));
        
        [JsonPropertyName("authorProfile")]
        public TDMemberProfile? AuthorProfile
        {
            get { return _authorProfile.GetValue(); }
            set { _authorProfile.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _repositoryId.SetAccessPath(path, validateHasBeenSet);
            _repositoryName.SetAccessPath(path, validateHasBeenSet);
            _revision.SetAccessPath(path, validateHasBeenSet);
            _message.SetAccessPath(path, validateHasBeenSet);
            _date.SetAccessPath(path, validateHasBeenSet);
            _authorName.SetAccessPath(path, validateHasBeenSet);
            _authorEmail.SetAccessPath(path, validateHasBeenSet);
            _committerName.SetAccessPath(path, validateHasBeenSet);
            _committerEmail.SetAccessPath(path, validateHasBeenSet);
            _authorProfile.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
