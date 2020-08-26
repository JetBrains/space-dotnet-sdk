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

namespace SpaceDotNet.Client.MembersAddedItemDetailsDtoPartialBuilder
{
    public static class MembersAddedItemDetailsDtoPartialExtensions
    {
        public static Partial<MembersAddedItemDetailsDto> WithPrincipals(this Partial<MembersAddedItemDetailsDto> it)
            => it.AddFieldName("principals");
        
        public static Partial<MembersAddedItemDetailsDto> WithPrincipals(this Partial<MembersAddedItemDetailsDto> it, Func<Partial<CPrincipalDto>, Partial<CPrincipalDto>> partialBuilder)
            => it.AddFieldName("principals", partialBuilder(new Partial<CPrincipalDto>(it)));
        
        public static Partial<MembersAddedItemDetailsDto> WithOthersDisplayNames(this Partial<MembersAddedItemDetailsDto> it)
            => it.AddFieldName("othersDisplayNames");
        
    }
    
}
