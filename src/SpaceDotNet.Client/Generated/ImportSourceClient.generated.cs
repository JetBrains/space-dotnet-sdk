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
    public partial class ImportSourceClient
    {
        private readonly Connection _connection;
        
        public ImportSourceClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<ImportSourceDto> CreateImportSource(CreateImportSourceRequestDto data, Func<Partial<ImportSourceDto>, Partial<ImportSourceDto>> partialBuilder = null)
            => await _connection.RequestResourceAsync<CreateImportSourceRequestDto, ImportSourceDto>("POST", $"api/http/import-sources?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<ImportSourceDto>()) : Partial<ImportSourceDto>.Default()), data);        
        
        public async Task<List<ImportSourceDto>> GetAllImportSources(Func<Partial<List<ImportSourceDto>>, Partial<List<ImportSourceDto>>> partialBuilder = null)
            => await _connection.RequestResourceAsync<List<ImportSourceDto>>("GET", $"api/http/import-sources?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<List<ImportSourceDto>>()) : Partial<List<ImportSourceDto>>.Default()));        
        
        public async Task UpdateImportSource(string sourceId, UpdateImportSourceRequestDto data)
            => await _connection.RequestResourceAsync<UpdateImportSourceRequestDto>("PATCH", $"api/http/import-sources/{sourceId}", data);        
        
        public async Task DeleteImportSource(string sourceId)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/import-sources/{sourceId}");        
        
    }
    
}
