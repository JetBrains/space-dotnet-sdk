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
    public sealed class DRDraftDto
         : IPropagatePropertyAccessPath
    {
        public DRDraftDto() { }
        
        public DRDraftDto(string id, string title, SpaceTime modified, bool shared, bool publishedFlag, int accessOrdinal, List<TDMemberProfileDto> editors, List<TDTeamDto> editorsTeams, TextDocumentDto document, SpaceTime? created = null, bool? deleted = null, DraftPublicationDetailsDto? publicationDetails = null, TDMemberProfileDto? author = null, DocumentFolderRecordDto? folder = null)
        {
            Id = id;
            Title = title;
            Modified = modified;
            Created = created;
            Shared = shared;
            Deleted = deleted;
            PublicationDetails = publicationDetails;
            Author = author;
            PublishedFlag = publishedFlag;
            Folder = folder;
            AccessOrdinal = accessOrdinal;
            Editors = editors;
            EditorsTeams = editorsTeams;
            Document = document;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(DRDraftDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(DRDraftDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _modified = new PropertyValue<SpaceTime>(nameof(DRDraftDto), nameof(Modified));
        
        [Required]
        [JsonPropertyName("modified")]
        public SpaceTime Modified
        {
            get { return _modified.GetValue(); }
            set { _modified.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _created = new PropertyValue<SpaceTime?>(nameof(DRDraftDto), nameof(Created));
        
        [JsonPropertyName("created")]
        public SpaceTime? Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<bool> _shared = new PropertyValue<bool>(nameof(DRDraftDto), nameof(Shared));
        
        [Required]
        [JsonPropertyName("shared")]
        public bool Shared
        {
            get { return _shared.GetValue(); }
            set { _shared.SetValue(value); }
        }
    
        private PropertyValue<bool?> _deleted = new PropertyValue<bool?>(nameof(DRDraftDto), nameof(Deleted));
        
        [JsonPropertyName("deleted")]
        public bool? Deleted
        {
            get { return _deleted.GetValue(); }
            set { _deleted.SetValue(value); }
        }
    
        private PropertyValue<DraftPublicationDetailsDto?> _publicationDetails = new PropertyValue<DraftPublicationDetailsDto?>(nameof(DRDraftDto), nameof(PublicationDetails));
        
        [JsonPropertyName("publicationDetails")]
        public DraftPublicationDetailsDto? PublicationDetails
        {
            get { return _publicationDetails.GetValue(); }
            set { _publicationDetails.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto?> _author = new PropertyValue<TDMemberProfileDto?>(nameof(DRDraftDto), nameof(Author));
        
        [JsonPropertyName("author")]
        public TDMemberProfileDto? Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        private PropertyValue<bool> _publishedFlag = new PropertyValue<bool>(nameof(DRDraftDto), nameof(PublishedFlag));
        
        [Required]
        [JsonPropertyName("publishedFlag")]
        public bool PublishedFlag
        {
            get { return _publishedFlag.GetValue(); }
            set { _publishedFlag.SetValue(value); }
        }
    
        private PropertyValue<DocumentFolderRecordDto?> _folder = new PropertyValue<DocumentFolderRecordDto?>(nameof(DRDraftDto), nameof(Folder));
        
        [JsonPropertyName("folder")]
        public DocumentFolderRecordDto? Folder
        {
            get { return _folder.GetValue(); }
            set { _folder.SetValue(value); }
        }
    
        private PropertyValue<int> _accessOrdinal = new PropertyValue<int>(nameof(DRDraftDto), nameof(AccessOrdinal));
        
        [Required]
        [JsonPropertyName("accessOrdinal")]
        public int AccessOrdinal
        {
            get { return _accessOrdinal.GetValue(); }
            set { _accessOrdinal.SetValue(value); }
        }
    
        private PropertyValue<List<TDMemberProfileDto>> _editors = new PropertyValue<List<TDMemberProfileDto>>(nameof(DRDraftDto), nameof(Editors));
        
        [Required]
        [JsonPropertyName("editors")]
        public List<TDMemberProfileDto> Editors
        {
            get { return _editors.GetValue(); }
            set { _editors.SetValue(value); }
        }
    
        private PropertyValue<List<TDTeamDto>> _editorsTeams = new PropertyValue<List<TDTeamDto>>(nameof(DRDraftDto), nameof(EditorsTeams));
        
        [Required]
        [JsonPropertyName("editorsTeams")]
        public List<TDTeamDto> EditorsTeams
        {
            get { return _editorsTeams.GetValue(); }
            set { _editorsTeams.SetValue(value); }
        }
    
        private PropertyValue<TextDocumentDto> _document = new PropertyValue<TextDocumentDto>(nameof(DRDraftDto), nameof(Document));
        
        [Required]
        [JsonPropertyName("document")]
        public TextDocumentDto Document
        {
            get { return _document.GetValue(); }
            set { _document.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _modified.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _shared.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
            _publicationDetails.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _publishedFlag.SetAccessPath(path, validateHasBeenSet);
            _folder.SetAccessPath(path, validateHasBeenSet);
            _accessOrdinal.SetAccessPath(path, validateHasBeenSet);
            _editors.SetAccessPath(path, validateHasBeenSet);
            _editorsTeams.SetAccessPath(path, validateHasBeenSet);
            _document.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
