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
    public partial class ImportSourceClient
    {
        private readonly Connection _connection;
        
        public ImportSourceClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<ImportSource> CreateImportSourceAsync(string name, string? importerPrincipal = null, Func<Partial<ImportSource>, Partial<ImportSource>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<ImportSourcesPostRequest, ImportSource>("POST", $"api/http/import-sources?$fields={(partial != null ? partial(new Partial<ImportSource>()) : Partial<ImportSource>.Default())}", 
                new ImportSourcesPostRequest { 
                    Name = name,
                    ImporterPrincipal = importerPrincipal,
                }
        , cancellationToken);
    
        public async Task<List<ImportSource>> GetAllImportSourcesAsync(Func<Partial<ImportSource>, Partial<ImportSource>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<List<ImportSource>>("GET", $"api/http/import-sources?$fields={(partial != null ? partial(new Partial<ImportSource>()) : Partial<ImportSource>.Default())}", cancellationToken);
    
        public async Task UpdateImportSourceAsync(string sourceId, string name, string importerPrincipal, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("PATCH", $"api/http/import-sources/{sourceId}", 
                new ImportSourcesForSourceIdPatchRequest { 
                    Name = name,
                    ImporterPrincipal = importerPrincipal,
                }
        , cancellationToken);
    
        public async Task DeleteImportSourceAsync(string sourceId, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/import-sources/{sourceId}", cancellationToken);
    
    }
    
}
