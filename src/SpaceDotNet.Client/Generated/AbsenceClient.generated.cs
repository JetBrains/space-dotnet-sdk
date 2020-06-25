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
    public partial class AbsenceClient
    {
        private readonly Connection _connection;
        
        public AbsenceClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Create an absence for a given profile (member).
        /// </summary>
        public async Task<AbsenceRecordDto> CreateAbsenceAsync(string member, string reason, string description, SpaceDate since, SpaceDate till, bool available, string icon, string? location = null, List<CustomFieldValueDto>? customFieldValues = null, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>>? partial = null)
            => await _connection.RequestResourceAsync<AbsencesRequest, AbsenceRecordDto>("POST", $"api/http/absences?$fields={(partial != null ? partial(new Partial<AbsenceRecordDto>()) : Partial<AbsenceRecordDto>.Default())}", new AbsencesRequest{ Member = member, Reason = reason, Description = description, Location = location, Since = since, Till = till, Available = available, Icon = icon, CustomFieldValues = customFieldValues });
    
        /// <summary>
        /// Approve/unapprove an existing absence. Setting approve to true will approve the absence, false will remove the approval.
        /// </summary>
        public async Task ApproveAbsenceAsync(string id, bool approve)
            => await _connection.RequestResourceAsync("POST", $"api/http/absences/{id}/approve", new AbsencesForIdApproveRequest{ Approve = approve });
    
        /// <summary>
        /// Search absences. Parameters are applied as 'AND' filters.
        /// </summary>
        public async Task<Batch<AbsenceRecordDto>> GetAllAbsencesAsync(AbsenceListMode viewMode, string? skip = null, int? top = null, string? member = null, string? location = null, string? team = null, SpaceDate? since = null, SpaceDate? till = null, string? reason = null, Func<Partial<Batch<AbsenceRecordDto>>, Partial<Batch<AbsenceRecordDto>>>? partial = null)
            => await _connection.RequestResourceAsync<Batch<AbsenceRecordDto>>("GET", $"api/http/absences?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&member={member?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&team={team?.ToString() ?? "null"}&since={since?.ToString() ?? "null"}&till={till?.ToString() ?? "null"}&viewMode={viewMode.ToString()}&reason={reason?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<AbsenceRecordDto>>()) : Partial<Batch<AbsenceRecordDto>>.Default())}");
        
        /// <summary>
        /// Search absences. Parameters are applied as 'AND' filters.
        /// </summary>
        public IAsyncEnumerable<AbsenceRecordDto> GetAllAbsencesAsyncEnumerable(AbsenceListMode viewMode, string? skip = null, int? top = null, string? member = null, string? location = null, string? team = null, SpaceDate? since = null, SpaceDate? till = null, string? reason = null, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>>? partial = null)
            => BatchEnumerator.AllItems(batchSkip => GetAllAbsencesAsync(viewMode: viewMode, top: top, member: member, location: location, team: team, since: since, till: till, reason: reason, skip: batchSkip, partial: builder => Partial<Batch<AbsenceRecordDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<AbsenceRecordDto>.Default())), skip);
    
        /// <summary>
        /// Get absences for a given profile id.
        /// </summary>
        public async Task<List<AbsenceRecordDto>> GetAllAbsencesByMemberAsync(string member, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>>? partial = null)
            => await _connection.RequestResourceAsync<List<AbsenceRecordDto>>("GET", $"api/http/absences/member:{member}?$fields={(partial != null ? partial(new Partial<AbsenceRecordDto>()) : Partial<AbsenceRecordDto>.Default())}");
    
        /// <summary>
        /// Get an absence.
        /// </summary>
        public async Task<AbsenceRecordDto> GetAbsenceAsync(string id, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>>? partial = null)
            => await _connection.RequestResourceAsync<AbsenceRecordDto>("GET", $"api/http/absences/{id}?$fields={(partial != null ? partial(new Partial<AbsenceRecordDto>()) : Partial<AbsenceRecordDto>.Default())}");
    
        /// <summary>
        /// Create an existing absence. Optional parameters will be ignored when null, and updated otherwise.
        /// </summary>
        public async Task<AbsenceRecordDto> UpdateAbsenceAsync(string id, bool available, string? member = null, string? reason = null, string? description = null, string? location = null, SpaceDate? since = null, SpaceDate? till = null, string? icon = null, List<CustomFieldValueDto>? customFieldValues = null, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>>? partial = null)
            => await _connection.RequestResourceAsync<AbsencesForIdRequest, AbsenceRecordDto>("PATCH", $"api/http/absences/{id}?$fields={(partial != null ? partial(new Partial<AbsenceRecordDto>()) : Partial<AbsenceRecordDto>.Default())}", new AbsencesForIdRequest{ Member = member, Reason = reason, Description = description, Location = location, Since = since, Till = till, Available = available, Icon = icon, CustomFieldValues = customFieldValues });
    
        /// <summary>
        /// Archive/restore an existing absence. Setting delete to true will archive the absence, false will restore it.
        /// </summary>
        public async Task DeleteAbsenceAsync(string id, bool delete)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/{id}?delete={delete.ToString().ToLowerInvariant()}");
    
        /// <summary>
        /// Delete approval for a given absence.
        /// </summary>
        public async Task DeleteAbsenceApprovalAsync(string id)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/{id}/delete-approval");
    
        public AbsenceReasonClient AbsenceReasons => new AbsenceReasonClient(_connection);
        
        public partial class AbsenceReasonClient
        {
            private readonly Connection _connection;
            
            public AbsenceReasonClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create a new absence reason.
            /// </summary>
            public async Task<AbsenceReasonRecordDto> CreateAbsenceReasonAsync(string name, string description, bool defaultAvailability, bool approvalRequired, string? icon = null, Func<Partial<AbsenceReasonRecordDto>, Partial<AbsenceReasonRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<AbsencesAbsenceReasonsRequest, AbsenceReasonRecordDto>("POST", $"api/http/absences/absence-reasons?$fields={(partial != null ? partial(new Partial<AbsenceReasonRecordDto>()) : Partial<AbsenceReasonRecordDto>.Default())}", new AbsencesAbsenceReasonsRequest{ Name = name, Description = description, DefaultAvailability = defaultAvailability, ApprovalRequired = approvalRequired, Icon = icon });
        
            /// <summary>
            /// Update an existing absence reason.
            /// </summary>
            public async Task<AbsenceReasonRecordDto> CreateAbsenceReasonAsync(string id, string name, string description, bool defaultAvailability, bool approvalRequired, string? icon = null, Func<Partial<AbsenceReasonRecordDto>, Partial<AbsenceReasonRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<AbsencesAbsenceReasonsForIdRequest, AbsenceReasonRecordDto>("POST", $"api/http/absences/absence-reasons/{id}?$fields={(partial != null ? partial(new Partial<AbsenceReasonRecordDto>()) : Partial<AbsenceReasonRecordDto>.Default())}", new AbsencesAbsenceReasonsForIdRequest{ Name = name, Description = description, DefaultAvailability = defaultAvailability, ApprovalRequired = approvalRequired, Icon = icon });
        
            /// <summary>
            /// Get available absence reasons.
            /// </summary>
            public async Task<List<AbsenceReasonRecordDto>> GetAllAbsenceReasonsAsync(bool withArchived, Func<Partial<AbsenceReasonRecordDto>, Partial<AbsenceReasonRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<List<AbsenceReasonRecordDto>>("GET", $"api/http/absences/absence-reasons?withArchived={withArchived.ToString().ToLowerInvariant()}&$fields={(partial != null ? partial(new Partial<AbsenceReasonRecordDto>()) : Partial<AbsenceReasonRecordDto>.Default())}");
        
            /// <summary>
            /// Get an absence reason.
            /// </summary>
            public async Task<AbsenceReasonRecordDto> GetAbsenceReasonAsync(string id, Func<Partial<AbsenceReasonRecordDto>, Partial<AbsenceReasonRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<AbsenceReasonRecordDto>("GET", $"api/http/absences/absence-reasons/{id}?$fields={(partial != null ? partial(new Partial<AbsenceReasonRecordDto>()) : Partial<AbsenceReasonRecordDto>.Default())}");
        
            /// <summary>
            /// Archive/restore an existing absence reason. Setting delete to true will archive the absence reason, false will restore it.
            /// </summary>
            public async Task DeleteAbsenceReasonAsync(string id, bool delete)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/absence-reasons/{id}?delete={delete.ToString().ToLowerInvariant()}");
        
        }
    
        public SubscriptionClient Subscriptions => new SubscriptionClient(_connection);
        
        public partial class SubscriptionClient
        {
            private readonly Connection _connection;
            
            public SubscriptionClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<DTOAbsenceSubscriptionDto> CreateSubscriptionAsync(string? locationId = null, string? teamId = null, string? reasonId = null, Func<Partial<DTOAbsenceSubscriptionDto>, Partial<DTOAbsenceSubscriptionDto>>? partial = null)
                => await _connection.RequestResourceAsync<AbsencesSubscriptionsRequest, DTOAbsenceSubscriptionDto>("POST", $"api/http/absences/subscriptions?$fields={(partial != null ? partial(new Partial<DTOAbsenceSubscriptionDto>()) : Partial<DTOAbsenceSubscriptionDto>.Default())}", new AbsencesSubscriptionsRequest{ LocationId = locationId, TeamId = teamId, ReasonId = reasonId });
        
            public async Task<List<DTOAbsenceSubscriptionDto>> GetAllSubscriptionsAsync(Func<Partial<DTOAbsenceSubscriptionDto>, Partial<DTOAbsenceSubscriptionDto>>? partial = null)
                => await _connection.RequestResourceAsync<List<DTOAbsenceSubscriptionDto>>("GET", $"api/http/absences/subscriptions?$fields={(partial != null ? partial(new Partial<DTOAbsenceSubscriptionDto>()) : Partial<DTOAbsenceSubscriptionDto>.Default())}");
        
            public async Task<DTOAbsenceSubscriptionDto> UpdateSubscriptionAsync(string id, string? locationId = null, string? teamId = null, string? reasonId = null, Func<Partial<DTOAbsenceSubscriptionDto>, Partial<DTOAbsenceSubscriptionDto>>? partial = null)
                => await _connection.RequestResourceAsync<AbsencesSubscriptionsForIdRequest, DTOAbsenceSubscriptionDto>("PATCH", $"api/http/absences/subscriptions/{id}?$fields={(partial != null ? partial(new Partial<DTOAbsenceSubscriptionDto>()) : Partial<DTOAbsenceSubscriptionDto>.Default())}", new AbsencesSubscriptionsForIdRequest{ LocationId = locationId, TeamId = teamId, ReasonId = reasonId });
        
            public async Task DeleteSubscriptionAsync(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/subscriptions/{id}");
        
        }
    
    }
    
}
