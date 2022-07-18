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
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.SessionParticipationRecordPartialBuilder;

public static class SessionParticipationRecordPartialExtensions
{
    public static Partial<SessionParticipationRecord> WithId(this Partial<SessionParticipationRecord> it)
        => it.AddFieldName("id");
    
    public static Partial<SessionParticipationRecord> WithConnectionId(this Partial<SessionParticipationRecord> it)
        => it.AddFieldName("connectionId");
    
    public static Partial<SessionParticipationRecord> WithSessionId(this Partial<SessionParticipationRecord> it)
        => it.AddFieldName("sessionId");
    
    public static Partial<SessionParticipationRecord> WithMember(this Partial<SessionParticipationRecord> it)
        => it.AddFieldName("member");
    
    public static Partial<SessionParticipationRecord> WithMember(this Partial<SessionParticipationRecord> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("member", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<SessionParticipationRecord> WithState(this Partial<SessionParticipationRecord> it)
        => it.AddFieldName("state");
    
    public static Partial<SessionParticipationRecord> WithState(this Partial<SessionParticipationRecord> it, Func<Partial<ParticipationState>, Partial<ParticipationState>> partialBuilder)
        => it.AddFieldName("state", partialBuilder(new Partial<ParticipationState>(it)));
    
    public static Partial<SessionParticipationRecord> WithParticipant(this Partial<SessionParticipationRecord> it)
        => it.AddFieldName("participant");
    
    public static Partial<SessionParticipationRecord> WithParticipant(this Partial<SessionParticipationRecord> it, Func<Partial<TDCallParticipant>, Partial<TDCallParticipant>> partialBuilder)
        => it.AddFieldName("participant", partialBuilder(new Partial<TDCallParticipant>(it)));
    
    public static Partial<SessionParticipationRecord> WithDescription(this Partial<SessionParticipationRecord> it)
        => it.AddFieldName("description");
    
    public static Partial<SessionParticipationRecord> WithDataProducers(this Partial<SessionParticipationRecord> it)
        => it.AddFieldName("dataProducers");
    
    public static Partial<SessionParticipationRecord> WithDataProducers(this Partial<SessionParticipationRecord> it, Func<Partial<DataProducerOptions>, Partial<DataProducerOptions>> partialBuilder)
        => it.AddFieldName("dataProducers", partialBuilder(new Partial<DataProducerOptions>(it)));
    
    public static Partial<SessionParticipationRecord> WithProducers(this Partial<SessionParticipationRecord> it)
        => it.AddFieldName("producers");
    
    public static Partial<SessionParticipationRecord> WithProducers(this Partial<SessionParticipationRecord> it, Func<Partial<ProducerOptions>, Partial<ProducerOptions>> partialBuilder)
        => it.AddFieldName("producers", partialBuilder(new Partial<ProducerOptions>(it)));
    
}

