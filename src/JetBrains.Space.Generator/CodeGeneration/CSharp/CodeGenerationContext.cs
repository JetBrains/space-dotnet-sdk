using System.Collections.Immutable;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp;

public class CodeGenerationContext
{
    public ApiModel ApiModel { get; }
    public DeploymentInfo DeploymentInfo { get; }
    private readonly SortedDictionary<string, ApiEnum> _idToEnumMap;
    private readonly SortedDictionary<string, ApiDto> _idToDtoMap;
    private readonly SortedDictionary<string, bool> _idToIsRequestBodyDtoMap;
    private readonly SortedDictionary<string, ApiUrlParameter> _idToUrlParameterMap;

    private CodeGenerationContext(
        ApiModel apiModel,
        DeploymentInfo deploymentInfo,
        SortedDictionary<string, ApiEnum> idToEnumMap,
        SortedDictionary<string, ApiDto> idToDtoMap,
        SortedDictionary<string, ApiUrlParameter> idToUrlParameterMap)
    {
        ApiModel = apiModel;
        DeploymentInfo = deploymentInfo;
        _idToEnumMap = idToEnumMap;
        _idToDtoMap = idToDtoMap;
        _idToIsRequestBodyDtoMap = new SortedDictionary<string, bool>(StringComparer.OrdinalIgnoreCase);
        _idToUrlParameterMap = idToUrlParameterMap;
    }

    public static CodeGenerationContext CreateFrom(ApiModel apiModel, DeploymentInfo deploymentInfo)
    {
        // Build context
#pragma warning disable 8619
        var context = new CodeGenerationContext(
            apiModel: apiModel,
            deploymentInfo: deploymentInfo,
            idToEnumMap: new SortedDictionary<string, ApiEnum>(
                apiModel.Enums.ToImmutableSortedDictionary(
                    it => it.Id,
                    it => it),
                StringComparer.OrdinalIgnoreCase), 
            idToDtoMap: new SortedDictionary<string, ApiDto>(
                apiModel.Dto.ToImmutableSortedDictionary(
                    it => it.Id,
                    it => it),
                StringComparer.OrdinalIgnoreCase), 
            idToUrlParameterMap: new SortedDictionary<string, ApiUrlParameter>(
                apiModel.UrlParameters.ToImmutableSortedDictionary(
                    it => it.Id,
                    it => it),
                StringComparer.OrdinalIgnoreCase));
#pragma warning restore 8619
            
        // Update API model
        CodeGenerationContextEnricher.AddRequestBodyTypesToDtos(context);
        CodeGenerationContextEnricher.RemoveDtoFieldsToIgnore(context);
        CodeGenerationContextEnricher.RemoveDtoPrefixFromDtoNames(context);

        return context;
    }

    public IEnumerable<ApiResource> GetResources() => ApiModel.Resources;
        
    public IEnumerable<ApiEnum> GetEnums() => _idToEnumMap.Values;
    public bool TryGetEnum(string id, out ApiEnum? apiEnum) => _idToEnumMap.TryGetValue(id, out apiEnum);
        
    public IEnumerable<ApiDto> GetDtos() => _idToDtoMap.Values;
    public bool TryGetDto(string id, out ApiDto? apiDto) => _idToDtoMap.TryGetValue(id, out apiDto);

    public void AddDto(string id, ApiDto apiDto, bool isRequestBodyDto)
    {
        _idToDtoMap[id] = apiDto;
        
        if (isRequestBodyDto) _idToIsRequestBodyDtoMap[id] = true;
    }
    
    public bool IsRequestBodyDto(string id) => _idToIsRequestBodyDtoMap.TryGetValue(id, out var isRequestBodyDto) && isRequestBodyDto;
        
    public IEnumerable<ApiUrlParameter> GetUrlParameters() => _idToUrlParameterMap.Values;
    public bool TryGetUrlParameter(string id, out ApiUrlParameter? apiUrlParameter) => _idToUrlParameterMap.TryGetValue(id, out apiUrlParameter);
        
    public IEnumerable<ApiMenuId> GetMenuIds() => ApiModel.MenuIds;
}