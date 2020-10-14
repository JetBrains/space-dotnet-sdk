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
    public partial class DocClient
    {
        private readonly Connection _connection;
        
        public DocClient(Connection connection)
        {
            _connection = connection;
        }
        
        public DraftClient Drafts => new DraftClient(_connection);
        
        public partial class DraftClient
        {
            private readonly Connection _connection;
            
            public DraftClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<DRDraft> CreateDraftAsync(DraftDocumentType? type = null, string? title = null, string? text = null, long? textVersion = null, string? folder = null, DraftPublicationDetails? publicationDetails = null, PublicationDetails? publicationDetails2 = null, Func<Partial<DRDraft>, Partial<DRDraft>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<DocsDraftsPostRequest, DRDraft>("POST", $"api/http/docs/drafts?$fields={(partial != null ? partial(new Partial<DRDraft>()) : Partial<DRDraft>.Default())}", 
                    new DocsDraftsPostRequest { 
                        Title = title,
                        Text = text,
                        TextVersion = textVersion,
                        Type = (type ?? DraftDocumentType.WYSIWYG),
                        Folder = folder,
                        PublicationDetails = publicationDetails,
                        PublicationDetails2 = publicationDetails2,
                    }
            , cancellationToken);
        
            public async Task<DRDraft> GetDraftAsync(string id, Func<Partial<DRDraft>, Partial<DRDraft>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<DRDraft>("GET", $"api/http/docs/drafts/{id}?$fields={(partial != null ? partial(new Partial<DRDraft>()) : Partial<DRDraft>.Default())}", cancellationToken);
        
            public async Task<DRDraft> UpdateDraftAsync(string id, string? title = null, string? text = null, long? textVersion = null, DraftDocumentType? type = null, string? folder = null, DraftPublicationDetails? publicationDetails = null, PublicationDetails? publicationDetails2 = null, Func<Partial<DRDraft>, Partial<DRDraft>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<DocsDraftsForIdPatchRequest, DRDraft>("PATCH", $"api/http/docs/drafts/{id}?$fields={(partial != null ? partial(new Partial<DRDraft>()) : Partial<DRDraft>.Default())}", 
                    new DocsDraftsForIdPatchRequest { 
                        Title = title,
                        Text = text,
                        TextVersion = textVersion,
                        Type = type,
                        Folder = folder,
                        PublicationDetails = publicationDetails,
                        PublicationDetails2 = publicationDetails2,
                    }
            , cancellationToken);
        
            public async Task DeleteDraftAsync(string id, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/docs/drafts/{id}", cancellationToken);
        
            public FolderClient Folder => new FolderClient(_connection);
            
            public partial class FolderClient
            {
                private readonly Connection _connection;
                
                public FolderClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<DocumentFolderRecord> CreateFolderAsync(string name, string? parentId = null, Func<Partial<DocumentFolderRecord>, Partial<DocumentFolderRecord>>? partial = null, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync<DocsDraftsFolderPostRequest, DocumentFolderRecord>("POST", $"api/http/docs/drafts/folder?$fields={(partial != null ? partial(new Partial<DocumentFolderRecord>()) : Partial<DocumentFolderRecord>.Default())}", 
                        new DocsDraftsFolderPostRequest { 
                            Name = name,
                            ParentId = parentId,
                        }
                , cancellationToken);
            
                public async Task<DocumentFolderRecord> GetFolderByAliasAsync(string alias, Func<Partial<DocumentFolderRecord>, Partial<DocumentFolderRecord>>? partial = null, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync<DocumentFolderRecord>("GET", $"api/http/docs/drafts/folder/alias:{alias}?$fields={(partial != null ? partial(new Partial<DocumentFolderRecord>()) : Partial<DocumentFolderRecord>.Default())}", cancellationToken);
            
                public async Task DeleteFolderAsync(string id, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync("DELETE", $"api/http/docs/drafts/folder/{id}", cancellationToken);
            
                public NameClient Name => new NameClient(_connection);
                
                public partial class NameClient
                {
                    private readonly Connection _connection;
                    
                    public NameClient(Connection connection)
                    {
                        _connection = connection;
                    }
                    
                    public async Task UpdateNameAsync(string id, string name, CancellationToken cancellationToken = default)
                        => await _connection.RequestResourceAsync("PATCH", $"api/http/docs/drafts/folder/{id}/name", 
                            new DocsDraftsFolderForIdNamePatchRequest { 
                                Name = name,
                            }
                    , cancellationToken);
                
                }
            
                public ParentClient Parent => new ParentClient(_connection);
                
                public partial class ParentClient
                {
                    private readonly Connection _connection;
                    
                    public ParentClient(Connection connection)
                    {
                        _connection = connection;
                    }
                    
                    public async Task<DocumentFolderRecord> UpdateParentAsync(string id, string parentFolderId, Func<Partial<DocumentFolderRecord>, Partial<DocumentFolderRecord>>? partial = null, CancellationToken cancellationToken = default)
                        => await _connection.RequestResourceAsync<DocsDraftsFolderForIdParentPatchRequest, DocumentFolderRecord>("PATCH", $"api/http/docs/drafts/folder/{id}/parent?$fields={(partial != null ? partial(new Partial<DocumentFolderRecord>()) : Partial<DocumentFolderRecord>.Default())}", 
                            new DocsDraftsFolderForIdParentPatchRequest { 
                                ParentFolderId = parentFolderId,
                            }
                    , cancellationToken);
                
                }
            
            }
        
            public EditorClient Editors => new EditorClient(_connection);
            
            public partial class EditorClient
            {
                private readonly Connection _connection;
                
                public EditorClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public ProfileClient Profiles => new ProfileClient(_connection);
                
                public partial class ProfileClient
                {
                    private readonly Connection _connection;
                    
                    public ProfileClient(Connection connection)
                    {
                        _connection = connection;
                    }
                    
                    public async Task CreateProfileAsync(string id, string editorId, CancellationToken cancellationToken = default)
                        => await _connection.RequestResourceAsync("POST", $"api/http/docs/drafts/{id}/editors/profiles", 
                            new DocsDraftsForIdEditorsProfilesPostRequest { 
                                EditorId = editorId,
                            }
                    , cancellationToken);
                
                    public async Task<List<TDMemberProfile>> GetAllProfilesAsync(string id, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>>? partial = null, CancellationToken cancellationToken = default)
                        => await _connection.RequestResourceAsync<List<TDMemberProfile>>("GET", $"api/http/docs/drafts/{id}/editors/profiles?$fields={(partial != null ? partial(new Partial<TDMemberProfile>()) : Partial<TDMemberProfile>.Default())}", cancellationToken);
                
                    public async Task DeleteProfileAsync(string id, string editorId, CancellationToken cancellationToken = default)
                        => await _connection.RequestResourceAsync("DELETE", $"api/http/docs/drafts/{id}/editors/profiles/{editorId}", cancellationToken);
                
                }
            
                public TeamClient Teams => new TeamClient(_connection);
                
                public partial class TeamClient
                {
                    private readonly Connection _connection;
                    
                    public TeamClient(Connection connection)
                    {
                        _connection = connection;
                    }
                    
                    public async Task CreateTeamAsync(string id, string teamId, CancellationToken cancellationToken = default)
                        => await _connection.RequestResourceAsync("POST", $"api/http/docs/drafts/{id}/editors/teams", 
                            new DocsDraftsForIdEditorsTeamsPostRequest { 
                                TeamId = teamId,
                            }
                    , cancellationToken);
                
                    public async Task<List<TDTeam>> GetAllTeamsAsync(string id, Func<Partial<TDTeam>, Partial<TDTeam>>? partial = null, CancellationToken cancellationToken = default)
                        => await _connection.RequestResourceAsync<List<TDTeam>>("GET", $"api/http/docs/drafts/{id}/editors/teams?$fields={(partial != null ? partial(new Partial<TDTeam>()) : Partial<TDTeam>.Default())}", cancellationToken);
                
                    public async Task DeleteTeamAsync(string id, string teamId, CancellationToken cancellationToken = default)
                        => await _connection.RequestResourceAsync("DELETE", $"api/http/docs/drafts/{id}/editors/teams/{teamId}", cancellationToken);
                
                }
            
            }
        
        }
    
    }
    
}
