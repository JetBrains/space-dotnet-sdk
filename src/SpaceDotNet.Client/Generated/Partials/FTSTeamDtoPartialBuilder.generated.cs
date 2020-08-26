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

namespace SpaceDotNet.Client.FTSTeamDtoPartialBuilder
{
    public static class FTSTeamDtoPartialExtensions
    {
        public static Partial<FTSTeamDto> WithId(this Partial<FTSTeamDto> it)
            => it.AddFieldName("id");
        
        public static Partial<FTSTeamDto> WithName(this Partial<FTSTeamDto> it)
            => it.AddFieldName("name");
        
        public static Partial<FTSTeamDto> WithDescription(this Partial<FTSTeamDto> it)
            => it.AddFieldName("description");
        
        public static Partial<FTSTeamDto> WithSnippets(this Partial<FTSTeamDto> it)
            => it.AddFieldName("snippets");
        
        public static Partial<FTSTeamDto> WithSnippets(this Partial<FTSTeamDto> it, Func<Partial<FTSSnippetDto>, Partial<FTSSnippetDto>> partialBuilder)
            => it.AddFieldName("snippets", partialBuilder(new Partial<FTSSnippetDto>(it)));
        
    }
    
}
