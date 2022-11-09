using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;

public class CSharpApiModelGenerator
{
    private readonly CodeGenerationContext _codeGenerationContext;
        
    public CSharpApiModelGenerator(CodeGenerationContext codeGenerationContext)
    {
        _codeGenerationContext = codeGenerationContext;
    }
        
    public void GenerateFiles(
        IDocumentWriter clientDocumentWriter,
        IDocumentWriter commonDocumentWriter)
    {
        // API clients/endpoints
        var resourcesGenerator = new CSharpApiModelResourceGenerator(_codeGenerationContext);
        foreach (var apiResource in _codeGenerationContext.GetResources())
        {
            WriteToDocument(clientDocumentWriter, 
                apiResource.ToCSharpIdentifierSingular() + "Client.generated.cs",
                resourcesGenerator.GenerateResourceDefinition(apiResource));
        }
            
        // URL parameters
        var urlParametersGenerator = new CSharpApiModelUrlParameterGenerator(_codeGenerationContext);
        foreach (var apiUrlParameter in _codeGenerationContext.GetUrlParameters())
        {
            WriteToDocument(clientDocumentWriter, 
                "UrlParams/" + apiUrlParameter.ToCSharpClassName() + ".generated.cs",
                urlParametersGenerator.GenerateUrlParameterDefinition(apiUrlParameter));
        }
            
        // Enums
        var enumGenerator = new CSharpApiModelEnumGenerator();
        foreach (var apiEnum in _codeGenerationContext.GetEnums())
        {
            WriteToDocument(clientDocumentWriter, 
                "Enums/" + apiEnum.ToCSharpClassName() + ".generated.cs",
                enumGenerator.GenerateEnumDefinition(apiEnum));
        }
            
        // Dtos
        var dtoGenerator = new CSharpApiModelDtoGenerator(_codeGenerationContext);
        foreach (var apiDto in _codeGenerationContext.GetDtos())
        {
            WriteToDocument(clientDocumentWriter, 
                "Dtos/" + apiDto.ToCSharpClassName() + ".generated.cs",
                dtoGenerator.GenerateDtoDefinition(apiDto));
        }
            
        // Partial extensions
        var partialExtensionsGenerator = new CSharpPartialExtensionsGenerator(_codeGenerationContext);
        foreach (var apiDto in _codeGenerationContext.GetDtos()
                     .Where(dto => !_codeGenerationContext.IsRequestBodyDto(dto.Id)))
        {
            WriteToDocument(clientDocumentWriter, 
                "Partials/" + apiDto.ToCSharpClassName() + "PartialBuilder.generated.cs",
                partialExtensionsGenerator.GeneratePartialClassFor(apiDto),
                apiDto.ToCSharpClassName() + "PartialBuilder");
        }
            
        // Menu ids
        var menuIdsGenerator = new CSharpApiModelMenuIdGenerator(_codeGenerationContext);
        WriteToDocument(clientDocumentWriter, 
            "MenuIds.generated.cs",
            menuIdsGenerator.GenerateMenuIds(_codeGenerationContext.GetMenuIds()));

        // JSON serialization context
        if (FeatureFlags.GenerateOptimizedJsonSerializationContext)
        {
            var jsonContextGenerator = new CSharpApiModelJsonSerializationContextGenerator(_codeGenerationContext);
            WriteToDocument(clientDocumentWriter,
                "JsonSerializationContext.generated.cs",
                jsonContextGenerator.GenerateJsonSerializationContextClass());
        }

        // Version info
        var deploymentInfoGenerator = new CSharpDeploymentInfoGenerator();
        WriteToDocument(commonDocumentWriter, 
            "SdkInfo.generated.cs",
            deploymentInfoGenerator.GenerateSdkInfo(_codeGenerationContext.DeploymentInfo));
    }

    private static void WriteToDocument(
        IDocumentWriter documentWriter, 
        string relativePath, 
        string contents, 
        string? namespaceSuffix = null)
    {
        var document = new CSharpDocument(namespaceSuffix);
        document.AppendLine(contents);
        documentWriter.WriteDocument(
            relativePath,
            document.ToString());
    }
}