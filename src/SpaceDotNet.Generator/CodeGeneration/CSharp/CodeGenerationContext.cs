using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    public class CodeGenerationContext
    {
        public SortedDictionary<string, ApiEnum> IdToEnumMap  { get; }
        public SortedDictionary<string, ApiDto> IdToDtoMap  { get; }
        public HashSet<string> PropertiesToSkip { get; }

        public CodeGenerationContext(
            SortedDictionary<string, ApiEnum> idToEnumMap,
            SortedDictionary<string, ApiDto> idToDtoMap,
            HashSet<string> propertiesToSkip)
        {
            IdToEnumMap = idToEnumMap;
            IdToDtoMap = idToDtoMap;
            PropertiesToSkip = propertiesToSkip;
        }

        public static CodeGenerationContext CreateFrom(ApiModel apiModel)
        {
#pragma warning disable 8619
            return new CodeGenerationContext(
                idToEnumMap: new SortedDictionary<string, ApiEnum>(
                    apiModel.Enums.ToImmutableSortedDictionary(
                        it => it.Id,
                        it => it)!,
                    StringComparer.OrdinalIgnoreCase), 
                idToDtoMap: new SortedDictionary<string, ApiDto>(
                    apiModel.Dto.ToImmutableSortedDictionary(
                        it => it.Id,
                        it => it)!,
                    StringComparer.OrdinalIgnoreCase), 
                propertiesToSkip: new HashSet<string>
                {
                    "TDMemberProfileDto.Logins"
                });
#pragma warning restore 8619
        }
    }
}