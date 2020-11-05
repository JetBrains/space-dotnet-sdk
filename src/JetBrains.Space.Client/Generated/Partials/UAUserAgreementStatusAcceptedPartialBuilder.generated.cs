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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.UAUserAgreementStatusAcceptedPartialBuilder
{
    public static class UAUserAgreementStatusAcceptedPartialExtensions
    {
        public static Partial<UAUserAgreementStatusAccepted> WithProfile(this Partial<UAUserAgreementStatusAccepted> it)
            => it.AddFieldName("profile");
        
        public static Partial<UAUserAgreementStatusAccepted> WithProfile(this Partial<UAUserAgreementStatusAccepted> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<UAUserAgreementStatusAccepted> WithUserAgreement(this Partial<UAUserAgreementStatusAccepted> it)
            => it.AddFieldName("userAgreement");
        
        public static Partial<UAUserAgreementStatusAccepted> WithUserAgreement(this Partial<UAUserAgreementStatusAccepted> it, Func<Partial<UAUserAgreement>, Partial<UAUserAgreement>> partialBuilder)
            => it.AddFieldName("userAgreement", partialBuilder(new Partial<UAUserAgreement>(it)));
        
        public static Partial<UAUserAgreementStatusAccepted> WithAccepted(this Partial<UAUserAgreementStatusAccepted> it)
            => it.AddFieldName("accepted");
        
    }
    
}