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
    public partial class PublicHolidayClient
    {
        private readonly Connection _connection;
        
        public PublicHolidayClient(Connection connection)
        {
            _connection = connection;
        }
        
        public CalendarClient Calendars => new CalendarClient(_connection);
        
        public partial class CalendarClient
        {
            private readonly Connection _connection;
            
            public CalendarClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create a public holiday calendar for a location.
            /// </summary>
            public async Task<PublicHolidayCalendarRecord> CreateCalendarAsync(string name, string location, Func<Partial<PublicHolidayCalendarRecord>, Partial<PublicHolidayCalendarRecord>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<PublicHolidaysCalendarsPostRequest, PublicHolidayCalendarRecord>("POST", $"api/http/public-holidays/calendars?$fields={(partial != null ? partial(new Partial<PublicHolidayCalendarRecord>()) : Partial<PublicHolidayCalendarRecord>.Default())}", 
                    new PublicHolidaysCalendarsPostRequest { 
                        Name = name,
                        Location = location,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Import holidays in a public holiday calendar, using an attachment (.ics format) as the source.
            /// </summary>
            public async Task<string> ImportAsync(string calendar, string attachmentId, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<PublicHolidaysCalendarsImportPostRequest, string>("POST", $"api/http/public-holidays/calendars/import", 
                    new PublicHolidaysCalendarsImportPostRequest { 
                        Calendar = calendar,
                        AttachmentId = attachmentId,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Get all public holiday calendars.
            /// </summary>
            public async Task<Batch<PublicHolidayCalendarRecord>> GetAllCalendarsAsync(string? skip = null, int? top = 100, Func<Partial<Batch<PublicHolidayCalendarRecord>>, Partial<Batch<PublicHolidayCalendarRecord>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<PublicHolidayCalendarRecord>>("GET", $"api/http/public-holidays/calendars?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<PublicHolidayCalendarRecord>>()) : Partial<Batch<PublicHolidayCalendarRecord>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Get all public holiday calendars.
            /// </summary>
            public IAsyncEnumerable<PublicHolidayCalendarRecord> GetAllCalendarsAsyncEnumerable(string? skip = null, int? top = 100, Func<Partial<PublicHolidayCalendarRecord>, Partial<PublicHolidayCalendarRecord>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllCalendarsAsync(top: top, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<PublicHolidayCalendarRecord>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<PublicHolidayCalendarRecord>.Default())), skip, cancellationToken);
        
            /// <summary>
            /// Update an existing public holiday calendar.
            /// </summary>
            public async Task<PublicHolidayCalendarRecord> UpdateCalendarAsync(string id, string name, string location, Func<Partial<PublicHolidayCalendarRecord>, Partial<PublicHolidayCalendarRecord>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<PublicHolidaysCalendarsForIdPatchRequest, PublicHolidayCalendarRecord>("PATCH", $"api/http/public-holidays/calendars/{id}?$fields={(partial != null ? partial(new Partial<PublicHolidayCalendarRecord>()) : Partial<PublicHolidayCalendarRecord>.Default())}", 
                    new PublicHolidaysCalendarsForIdPatchRequest { 
                        Name = name,
                        Location = location,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Delete 
            /// </summary>
            public async Task DeleteCalendarAsync(string id, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/public-holidays/calendars/{id}", cancellationToken);
        
        }
    
        public HolidayClient Holidays => new HolidayClient(_connection);
        
        public partial class HolidayClient
        {
            private readonly Connection _connection;
            
            public HolidayClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Add a holiday to a public holiday calendar, and specify if it is a working day or not.
            /// </summary>
            public async Task<PublicHoliday> CreateHolidayAsync(string calendar, string name, SpaceDate date, bool workingDay, Func<Partial<PublicHoliday>, Partial<PublicHoliday>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<PublicHolidaysHolidaysPostRequest, PublicHoliday>("POST", $"api/http/public-holidays/holidays?$fields={(partial != null ? partial(new Partial<PublicHoliday>()) : Partial<PublicHoliday>.Default())}", 
                    new PublicHolidaysHolidaysPostRequest { 
                        Calendar = calendar,
                        Name = name,
                        Date = date,
                        IsWorkingDay = workingDay,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Get/search all holidays in a public holiday calendar. Parameters are applied as 'AND' filters.
            /// </summary>
            public async Task<Batch<PublicHoliday>> GetAllHolidaysAsync(string? skip = null, int? top = 100, string? calendar = null, string? location = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<Batch<PublicHoliday>>, Partial<Batch<PublicHoliday>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<PublicHoliday>>("GET", $"api/http/public-holidays/holidays?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&calendar={calendar?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&startDate={startDate?.ToString() ?? "null"}&endDate={endDate?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<PublicHoliday>>()) : Partial<Batch<PublicHoliday>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Get/search all holidays in a public holiday calendar. Parameters are applied as 'AND' filters.
            /// </summary>
            public IAsyncEnumerable<PublicHoliday> GetAllHolidaysAsyncEnumerable(string? skip = null, int? top = 100, string? calendar = null, string? location = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<PublicHoliday>, Partial<PublicHoliday>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllHolidaysAsync(top: top, calendar: calendar, location: location, startDate: startDate, endDate: endDate, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<PublicHoliday>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<PublicHoliday>.Default())), skip, cancellationToken);
        
            /// <summary>
            /// Update a holiday in a public holiday calendar. Optional parameters will be ignored when not specified, and updated otherwise.
            /// </summary>
            public async Task<PublicHoliday> UpdateHolidayAsync(string id, string? calendar = null, string? name = null, SpaceDate? date = null, bool? workingDay = null, Func<Partial<PublicHoliday>, Partial<PublicHoliday>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<PublicHolidaysHolidaysForIdPatchRequest, PublicHoliday>("PATCH", $"api/http/public-holidays/holidays/{id}?$fields={(partial != null ? partial(new Partial<PublicHoliday>()) : Partial<PublicHoliday>.Default())}", 
                    new PublicHolidaysHolidaysForIdPatchRequest { 
                        Calendar = calendar,
                        Name = name,
                        Date = date,
                        IsWorkingDay = workingDay,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Delete a holiday from a public holiday calendar.
            /// </summary>
            public async Task DeleteHolidayAsync(string id, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/public-holidays/holidays/{id}", cancellationToken);
        
            public ProfileHolidayClient ProfileHolidays => new ProfileHolidayClient(_connection);
            
            public partial class ProfileHolidayClient
            {
                private readonly Connection _connection;
                
                public ProfileHolidayClient(Connection connection)
                {
                    _connection = connection;
                }
                
                /// <summary>
                /// Get holidays observed in the location(s) of the current profile during the selected period.
                /// </summary>
                public async Task<List<PublicHoliday>> GetAllProfileHolidaysAsync(SpaceDate startDate, SpaceDate endDate, string profile, bool? workingDays = null, Func<Partial<PublicHoliday>, Partial<PublicHoliday>>? partial = null, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync<List<PublicHoliday>>("GET", $"api/http/public-holidays/holidays/profile-holidays?startDate={startDate.ToString()}&endDate={endDate.ToString()}&profile={profile.ToString()}&workingDays={workingDays?.ToString()?.ToLowerInvariant() ?? "null"}&$fields={(partial != null ? partial(new Partial<PublicHoliday>()) : Partial<PublicHoliday>.Default())}", cancellationToken);
            
            }
        
            public RelatedHolidayClient RelatedHolidays => new RelatedHolidayClient(_connection);
            
            public partial class RelatedHolidayClient
            {
                private readonly Connection _connection;
                
                public RelatedHolidayClient(Connection connection)
                {
                    _connection = connection;
                }
                
                /// <summary>
                /// Search related holidays in all public holiday calendars, during the selected period.
                /// </summary>
                public async Task<Batch<PublicHoliday>> GetAllRelatedHolidaysAsync(string? skip = null, int? top = 100, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<Batch<PublicHoliday>>, Partial<Batch<PublicHoliday>>>? partial = null, CancellationToken cancellationToken = default)
                    => await _connection.RequestResourceAsync<Batch<PublicHoliday>>("GET", $"api/http/public-holidays/holidays/related-holidays?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&startDate={startDate?.ToString() ?? "null"}&endDate={endDate?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<PublicHoliday>>()) : Partial<Batch<PublicHoliday>>.Default())}", cancellationToken);
                
                /// <summary>
                /// Search related holidays in all public holiday calendars, during the selected period.
                /// </summary>
                public IAsyncEnumerable<PublicHoliday> GetAllRelatedHolidaysAsyncEnumerable(string? skip = null, int? top = 100, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<PublicHoliday>, Partial<PublicHoliday>>? partial = null, CancellationToken cancellationToken = default)
                    => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllRelatedHolidaysAsync(top: top, startDate: startDate, endDate: endDate, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<PublicHoliday>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<PublicHoliday>.Default())), skip, cancellationToken);
            
            }
        
        }
    
    }
    
}
