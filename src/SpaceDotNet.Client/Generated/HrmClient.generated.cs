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
    public partial class HrmClient
    {
        private readonly Connection _connection;
        
        public HrmClient(Connection connection)
        {
            _connection = connection;
        }
        
        public BusinessEntityClient BusinessEntities => new BusinessEntityClient(_connection);
        
        public partial class BusinessEntityClient
        {
            private readonly Connection _connection;
            
            public BusinessEntityClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<BusinessEntityDto> CreateANewBusinessEntityAsync(string name, string locationId, int? vacationAllowance = null, Func<Partial<BusinessEntityDto>, Partial<BusinessEntityDto>>? partial = null)
                => await _connection.RequestResourceAsync<HrmBusinessEntitiesPostRequest, BusinessEntityDto>("POST", $"api/http/hrm/business-entities?$fields={(partial != null ? partial(new Partial<BusinessEntityDto>()) : Partial<BusinessEntityDto>.Default())}", 
                    new HrmBusinessEntitiesPostRequest { 
                        Name = name,
                        LocationId = locationId,
                        VacationAllowance = vacationAllowance,
                    }
            );
        
            public async Task<List<BusinessEntityDto>> ListExistingBusinessEntitiesAsync(Func<Partial<BusinessEntityDto>, Partial<BusinessEntityDto>>? partial = null)
                => await _connection.RequestResourceAsync<List<BusinessEntityDto>>("GET", $"api/http/hrm/business-entities?$fields={(partial != null ? partial(new Partial<BusinessEntityDto>()) : Partial<BusinessEntityDto>.Default())}");
        
            public async Task<BusinessEntityDto> GetExistingBusinessEntityByItsIdAsync(string id, Func<Partial<BusinessEntityDto>, Partial<BusinessEntityDto>>? partial = null)
                => await _connection.RequestResourceAsync<BusinessEntityDto>("GET", $"api/http/hrm/business-entities/{id}?$fields={(partial != null ? partial(new Partial<BusinessEntityDto>()) : Partial<BusinessEntityDto>.Default())}");
        
            public async Task<BusinessEntityDto> UpdateExistingBusinessEntityAsync(string id, string name, string locationId, int? vacationAllowance = null, Func<Partial<BusinessEntityDto>, Partial<BusinessEntityDto>>? partial = null)
                => await _connection.RequestResourceAsync<HrmBusinessEntitiesForIdPatchRequest, BusinessEntityDto>("PATCH", $"api/http/hrm/business-entities/{id}?$fields={(partial != null ? partial(new Partial<BusinessEntityDto>()) : Partial<BusinessEntityDto>.Default())}", 
                    new HrmBusinessEntitiesForIdPatchRequest { 
                        Name = name,
                        LocationId = locationId,
                        VacationAllowance = vacationAllowance,
                    }
            );
        
            public async Task RemoveExistingBusinessEntityAsync(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/hrm/business-entities/{id}");
        
            public RelationClient Relations => new RelationClient(_connection);
            
            public partial class RelationClient
            {
                private readonly Connection _connection;
                
                public RelationClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<BusinessEntityRelationDto> CreateANewRelationBetweenMemberAndBusinessEntityAsync(ProfileIdentifier memberId, string entityId, SpaceDate? since = null, SpaceDate? till = null, Func<Partial<BusinessEntityRelationDto>, Partial<BusinessEntityRelationDto>>? partial = null)
                    => await _connection.RequestResourceAsync<HrmBusinessEntitiesRelationsForMemberIdPostRequest, BusinessEntityRelationDto>("POST", $"api/http/hrm/business-entities/relations/{memberId}?$fields={(partial != null ? partial(new Partial<BusinessEntityRelationDto>()) : Partial<BusinessEntityRelationDto>.Default())}", 
                        new HrmBusinessEntitiesRelationsForMemberIdPostRequest { 
                            EntityId = entityId,
                            Since = since,
                            Till = till,
                        }
                );
            
                public async Task<Batch<BusinessEntityRelationDto>> ListAllBusinessEntityRelationsAsync(List<ProfileIdentifier>? profile = null, List<string>? businessEntityId = null, string? skip = null, int? top = 100, SpaceDate? since = null, SpaceDate? till = null, Func<Partial<Batch<BusinessEntityRelationDto>>, Partial<Batch<BusinessEntityRelationDto>>>? partial = null)
                    => await _connection.RequestResourceAsync<Batch<BusinessEntityRelationDto>>("GET", $"api/http/hrm/business-entities/relations?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&profile={(profile ?? new List<ProfileIdentifier>()).JoinToString("profile", it => it.ToString())}&businessEntityId={(businessEntityId ?? new List<string>()).JoinToString("businessEntityId", it => it.ToString())}&since={since?.ToString() ?? "null"}&till={till?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<BusinessEntityRelationDto>>()) : Partial<Batch<BusinessEntityRelationDto>>.Default())}");
                
                public IAsyncEnumerable<BusinessEntityRelationDto> ListAllBusinessEntityRelationsAsyncEnumerable(List<ProfileIdentifier>? profile = null, List<string>? businessEntityId = null, string? skip = null, int? top = 100, SpaceDate? since = null, SpaceDate? till = null, Func<Partial<BusinessEntityRelationDto>, Partial<BusinessEntityRelationDto>>? partial = null)
                    => BatchEnumerator.AllItems(batchSkip => ListAllBusinessEntityRelationsAsync(profile: profile, businessEntityId: businessEntityId, top: top, since: since, till: till, skip: batchSkip, partial: builder => Partial<Batch<BusinessEntityRelationDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<BusinessEntityRelationDto>.Default())), skip);
            
                public async Task<List<BusinessEntityRelationDto>> ListMemberBusinessEntityRelationsAsync(ProfileIdentifier memberId, Func<Partial<BusinessEntityRelationDto>, Partial<BusinessEntityRelationDto>>? partial = null)
                    => await _connection.RequestResourceAsync<List<BusinessEntityRelationDto>>("GET", $"api/http/hrm/business-entities/relations/{memberId}?$fields={(partial != null ? partial(new Partial<BusinessEntityRelationDto>()) : Partial<BusinessEntityRelationDto>.Default())}");
            
                public async Task<BusinessEntityRelationDto> UpdateMemberBusinessEntityRelationAsync(string id, ProfileIdentifier memberId, SpaceDate? since = null, SpaceDate? till = null, Func<Partial<BusinessEntityRelationDto>, Partial<BusinessEntityRelationDto>>? partial = null)
                    => await _connection.RequestResourceAsync<HrmBusinessEntitiesRelationsForMemberIdForIdPatchRequest, BusinessEntityRelationDto>("PATCH", $"api/http/hrm/business-entities/relations/{memberId}/{id}?$fields={(partial != null ? partial(new Partial<BusinessEntityRelationDto>()) : Partial<BusinessEntityRelationDto>.Default())}", 
                        new HrmBusinessEntitiesRelationsForMemberIdForIdPatchRequest { 
                            Since = since,
                            Till = till,
                        }
                );
            
                public async Task DeleteMemberBusinessEntityRelationAsync(string id, ProfileIdentifier memberId)
                    => await _connection.RequestResourceAsync("DELETE", $"api/http/hrm/business-entities/relations/{memberId}/{id}");
            
            }
        
        }
    
    }
    
}
