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
    public sealed class DocumentFolderRecord
         : IPropagatePropertyAccessPath
    {
        public DocumentFolderRecord() { }
        
        public DocumentFolderRecord(string id, bool archived, string name, List<DocumentFolderRecord> subfolders, List<DRDraftHeader> documents, TDMemberProfile owner, string alias, DocumentFolderRecord? parent = null)
        {
            Id = id;
            IsArchived = archived;
            Name = name;
            Parent = parent;
            Subfolders = subfolders;
            Documents = documents;
            Owner = owner;
            Alias = alias;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(DocumentFolderRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(DocumentFolderRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(DocumentFolderRecord), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<DocumentFolderRecord?> _parent = new PropertyValue<DocumentFolderRecord?>(nameof(DocumentFolderRecord), nameof(Parent));
        
        [JsonPropertyName("parent")]
        public DocumentFolderRecord? Parent
        {
            get { return _parent.GetValue(); }
            set { _parent.SetValue(value); }
        }
    
        private PropertyValue<List<DocumentFolderRecord>> _subfolders = new PropertyValue<List<DocumentFolderRecord>>(nameof(DocumentFolderRecord), nameof(Subfolders));
        
        [Required]
        [JsonPropertyName("subfolders")]
        public List<DocumentFolderRecord> Subfolders
        {
            get { return _subfolders.GetValue(); }
            set { _subfolders.SetValue(value); }
        }
    
        private PropertyValue<List<DRDraftHeader>> _documents = new PropertyValue<List<DRDraftHeader>>(nameof(DocumentFolderRecord), nameof(Documents));
        
        [Required]
        [JsonPropertyName("documents")]
        public List<DRDraftHeader> Documents
        {
            get { return _documents.GetValue(); }
            set { _documents.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfile> _owner = new PropertyValue<TDMemberProfile>(nameof(DocumentFolderRecord), nameof(Owner));
        
        [Required]
        [JsonPropertyName("owner")]
        public TDMemberProfile Owner
        {
            get { return _owner.GetValue(); }
            set { _owner.SetValue(value); }
        }
    
        private PropertyValue<string> _alias = new PropertyValue<string>(nameof(DocumentFolderRecord), nameof(Alias));
        
        [Required]
        [JsonPropertyName("alias")]
        public string Alias
        {
            get { return _alias.GetValue(); }
            set { _alias.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _parent.SetAccessPath(path, validateHasBeenSet);
            _subfolders.SetAccessPath(path, validateHasBeenSet);
            _documents.SetAccessPath(path, validateHasBeenSet);
            _owner.SetAccessPath(path, validateHasBeenSet);
            _alias.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
