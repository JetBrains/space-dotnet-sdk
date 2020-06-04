using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    public class CodeGenerationContext
    {
        public ImmutableSortedDictionary<string, ApiEnum> IdToEnumMap  { get; }
        public ImmutableSortedDictionary<string, ApiDto> IdToDtoMap  { get; }
        public SortedDictionary<string, ApiDto> IdToAnonymousClassMap  { get; }
        public HashSet<string> PropertiesToSkip { get; }

        public CodeGenerationContext(
            ImmutableSortedDictionary<string, ApiEnum> idToEnumMap,
            ImmutableSortedDictionary<string, ApiDto> idToDtoMap,
            SortedDictionary<string, ApiDto> idToAnonymousClassMap,
            HashSet<string> propertiesToSkip)
        {
            IdToEnumMap = idToEnumMap;
            IdToDtoMap = idToDtoMap;
            IdToAnonymousClassMap = idToAnonymousClassMap;
            PropertiesToSkip = propertiesToSkip;
        }

        public static CodeGenerationContext CreateFrom(ApiModel apiModel)
        {
#pragma warning disable 8619
            return new CodeGenerationContext(
                idToEnumMap: apiModel.Enums.ToImmutableSortedDictionary(
                    it => it.Id,
                    it => it,
                    StringComparer.OrdinalIgnoreCase)!,
                idToDtoMap: apiModel.Dto.ToImmutableSortedDictionary(
                    it => it.Id,
                    it => it,
                    StringComparer.OrdinalIgnoreCase)!,
                idToAnonymousClassMap: new SortedDictionary<string, ApiDto>(StringComparer.OrdinalIgnoreCase),
                propertiesToSkip: new HashSet<string>
                {
                    "TDMemberProfileDto.Logins"
                });
#pragma warning restore 8619
        }
    }
}