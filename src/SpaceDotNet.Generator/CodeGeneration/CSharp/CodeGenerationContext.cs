using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    public class CodeGenerationContext
    {
        public ApiModel ApiModel { get; }
        public HashSet<string> PropertiesToSkip { get; }
        private readonly SortedDictionary<string, ApiEnum> _idToEnumMap;
        private readonly SortedDictionary<string, ApiDto> _idToDtoMap;
        private readonly SortedDictionary<string, ApiUrlParameter> _idToUrlParameterMap;

        private CodeGenerationContext(
            ApiModel apiModel,
            HashSet<string> propertiesToSkip,
            SortedDictionary<string, ApiEnum> idToEnumMap,
            SortedDictionary<string, ApiDto> idToDtoMap,
            SortedDictionary<string, ApiUrlParameter> idToUrlParameterMap)
        {
            ApiModel = apiModel;
            PropertiesToSkip = propertiesToSkip;
            _idToEnumMap = idToEnumMap;
            _idToDtoMap = idToDtoMap;
            _idToUrlParameterMap = idToUrlParameterMap;
        }

        public static CodeGenerationContext CreateFrom(ApiModel apiModel)
        {
#pragma warning disable 8619
            var context = new CodeGenerationContext(
                apiModel: apiModel, 
                propertiesToSkip: new HashSet<string>
                {
                    "TDMemberProfileDto.Logins"
                },
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
                idToUrlParameterMap: new SortedDictionary<string, ApiUrlParameter>(
                    apiModel.UrlParameters.ToImmutableSortedDictionary(
                        it => it.Id,
                        it => it)!,
                    StringComparer.OrdinalIgnoreCase));
#pragma warning restore 8619
            
            // Enrich Dtos with resource request body types
            CodeGenerationContextEnricher.EnrichDtosWithRequestBodyTypes(context);

            return context;
        }

        public IEnumerable<ApiResource> GetResources() => ApiModel.Resources;
        
        public IEnumerable<ApiEnum> GetEnums() => _idToEnumMap.Values;
        public bool TryGetEnum(string id, out ApiEnum? apiEnum) => _idToEnumMap.TryGetValue(id, out apiEnum);
        
        public IEnumerable<ApiDto> GetDtos() => _idToDtoMap.Values;
        public bool TryGetDto(string id, out ApiDto? apiDto) => _idToDtoMap.TryGetValue(id, out apiDto);
        public void AddDto(string id, ApiDto apiDto) => _idToDtoMap[id] = apiDto;
        
        public IEnumerable<ApiUrlParameter> GetUrlParameters() => _idToUrlParameterMap.Values;
        public bool TryGetUrlParameter(string id, out ApiUrlParameter? apiUrlParameter) => _idToUrlParameterMap.TryGetValue(id, out apiUrlParameter);
    }
}