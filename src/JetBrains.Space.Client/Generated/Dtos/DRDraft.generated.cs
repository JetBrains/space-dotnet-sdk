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
    public sealed class DRDraft
         : IPropagatePropertyAccessPath
    {
        public DRDraft() { }
        
        public DRDraft(string id, string title, DateTime modified, bool shared, bool published, DocumentContainerInfo containerInfo, int accessOrdinal, List<TDMemberProfile> editors, List<TDTeam> editorsTeams, DocumentBody documentBody, DocumentBodyType bodyType, DateTime? created = null, CPrincipal? modifiedBy = null, bool? deleted = null, PublicationDetails? publicationDetails2 = null, TDMemberProfile? author = null, DocumentFolderRecord? folder = null)
        {
            Id = id;
            Title = title;
            Modified = modified;
            Created = created;
            ModifiedBy = modifiedBy;
            IsShared = shared;
            IsDeleted = deleted;
            PublicationDetails2 = publicationDetails2;
            Author = author;
            IsPublished = published;
            Folder = folder;
            ContainerInfo = containerInfo;
            AccessOrdinal = accessOrdinal;
            Editors = editors;
            EditorsTeams = editorsTeams;
            DocumentBody = documentBody;
            BodyType = bodyType;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(DRDraft), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(DRDraft), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        private PropertyValue<DateTime> _modified = new PropertyValue<DateTime>(nameof(DRDraft), nameof(Modified));
        
        [Required]
        [JsonPropertyName("modified")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Modified
        {
            get => _modified.GetValue();
            set => _modified.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _created = new PropertyValue<DateTime?>(nameof(DRDraft), nameof(Created));
        
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _modifiedBy = new PropertyValue<CPrincipal?>(nameof(DRDraft), nameof(ModifiedBy));
        
        [JsonPropertyName("modifiedBy")]
        public CPrincipal? ModifiedBy
        {
            get => _modifiedBy.GetValue();
            set => _modifiedBy.SetValue(value);
        }
    
        private PropertyValue<bool> _shared = new PropertyValue<bool>(nameof(DRDraft), nameof(IsShared));
        
        [Required]
        [JsonPropertyName("shared")]
        public bool IsShared
        {
            get => _shared.GetValue();
            set => _shared.SetValue(value);
        }
    
        private PropertyValue<bool?> _deleted = new PropertyValue<bool?>(nameof(DRDraft), nameof(IsDeleted));
        
        [JsonPropertyName("deleted")]
        public bool? IsDeleted
        {
            get => _deleted.GetValue();
            set => _deleted.SetValue(value);
        }
    
        private PropertyValue<PublicationDetails?> _publicationDetails2 = new PropertyValue<PublicationDetails?>(nameof(DRDraft), nameof(PublicationDetails2));
        
        [JsonPropertyName("publicationDetails2")]
        public PublicationDetails? PublicationDetails2
        {
            get => _publicationDetails2.GetValue();
            set => _publicationDetails2.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile?> _author = new PropertyValue<TDMemberProfile?>(nameof(DRDraft), nameof(Author));
        
        [JsonPropertyName("author")]
        public TDMemberProfile? Author
        {
            get => _author.GetValue();
            set => _author.SetValue(value);
        }
    
        private PropertyValue<bool> _published = new PropertyValue<bool>(nameof(DRDraft), nameof(IsPublished));
        
        [Required]
        [JsonPropertyName("published")]
        public bool IsPublished
        {
            get => _published.GetValue();
            set => _published.SetValue(value);
        }
    
        private PropertyValue<DocumentFolderRecord?> _folder = new PropertyValue<DocumentFolderRecord?>(nameof(DRDraft), nameof(Folder));
        
        [JsonPropertyName("folder")]
        public DocumentFolderRecord? Folder
        {
            get => _folder.GetValue();
            set => _folder.SetValue(value);
        }
    
        private PropertyValue<DocumentContainerInfo> _containerInfo = new PropertyValue<DocumentContainerInfo>(nameof(DRDraft), nameof(ContainerInfo));
        
        [Required]
        [JsonPropertyName("containerInfo")]
        public DocumentContainerInfo ContainerInfo
        {
            get => _containerInfo.GetValue();
            set => _containerInfo.SetValue(value);
        }
    
        private PropertyValue<int> _accessOrdinal = new PropertyValue<int>(nameof(DRDraft), nameof(AccessOrdinal));
        
        [Required]
        [JsonPropertyName("accessOrdinal")]
        public int AccessOrdinal
        {
            get => _accessOrdinal.GetValue();
            set => _accessOrdinal.SetValue(value);
        }
    
        private PropertyValue<List<TDMemberProfile>> _editors = new PropertyValue<List<TDMemberProfile>>(nameof(DRDraft), nameof(Editors), new List<TDMemberProfile>());
        
        [Required]
        [JsonPropertyName("editors")]
        public List<TDMemberProfile> Editors
        {
            get => _editors.GetValue();
            set => _editors.SetValue(value);
        }
    
        private PropertyValue<List<TDTeam>> _editorsTeams = new PropertyValue<List<TDTeam>>(nameof(DRDraft), nameof(EditorsTeams), new List<TDTeam>());
        
        [Required]
        [JsonPropertyName("editorsTeams")]
        public List<TDTeam> EditorsTeams
        {
            get => _editorsTeams.GetValue();
            set => _editorsTeams.SetValue(value);
        }
    
        private PropertyValue<DocumentBody> _documentBody = new PropertyValue<DocumentBody>(nameof(DRDraft), nameof(DocumentBody));
        
        [Required]
        [JsonPropertyName("documentBody")]
        public DocumentBody DocumentBody
        {
            get => _documentBody.GetValue();
            set => _documentBody.SetValue(value);
        }
    
        private PropertyValue<DocumentBodyType> _bodyType = new PropertyValue<DocumentBodyType>(nameof(DRDraft), nameof(BodyType));
        
        [Required]
        [JsonPropertyName("bodyType")]
        public DocumentBodyType BodyType
        {
            get => _bodyType.GetValue();
            set => _bodyType.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _modified.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _modifiedBy.SetAccessPath(path, validateHasBeenSet);
            _shared.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
            _publicationDetails2.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _published.SetAccessPath(path, validateHasBeenSet);
            _folder.SetAccessPath(path, validateHasBeenSet);
            _containerInfo.SetAccessPath(path, validateHasBeenSet);
            _accessOrdinal.SetAccessPath(path, validateHasBeenSet);
            _editors.SetAccessPath(path, validateHasBeenSet);
            _editorsTeams.SetAccessPath(path, validateHasBeenSet);
            _documentBody.SetAccessPath(path, validateHasBeenSet);
            _bodyType.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
