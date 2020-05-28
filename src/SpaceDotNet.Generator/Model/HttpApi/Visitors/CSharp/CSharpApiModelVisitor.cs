using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.Json;
using SpaceDotNet.Common;
using SpaceDotNet.Generator.Utilities;

namespace SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp
{
    public class CSharpApiModelVisitor : ApiModelVisitor
    {
        protected readonly Indent Indent = new Indent();
        protected readonly StringBuilder Builder = new StringBuilder();
        protected readonly Action<string, string> WriteFile;

        protected ImmutableSortedDictionary<string, ApiEnum> IdToEnumMap = ImmutableSortedDictionary<string, ApiEnum>.Empty;
        protected ImmutableSortedDictionary<string, ApiDto> IdToDtoMap = ImmutableSortedDictionary<string, ApiDto>.Empty;
        protected readonly SortedDictionary<string, ApiDto> IdToAnonymousClassMap = new SortedDictionary<string, ApiDto>();
        protected readonly HashSet<string> PropertiesToSkip = new HashSet<string>
        {
            "TDMemberProfileDto.Logins"
        };

        public CSharpApiModelVisitor(Action<string, string> writeFile)
        {
            WriteFile = writeFile;
        }
        
        public override void Visit(ApiModel apiModel)
        {
#pragma warning disable 8619
            // Metadata mappings
            IdToEnumMap =
                apiModel.Enums.ToImmutableSortedDictionary(
                    it => it.Id, 
                    it => it, 
                    StringComparer.OrdinalIgnoreCase);
            
            IdToDtoMap =
                apiModel.Dto.ToImmutableSortedDictionary(
                    it => it.Id, 
                    it => it, 
                    StringComparer.OrdinalIgnoreCase);
#pragma warning restore 8619
            
            // Enums
            foreach (var apiEnum in apiModel.Enums)
            {
                GenerateFile("Enums/" + apiEnum.Name.ToSafeIdentifier() + ".generated.cs", 
                    () => Visit(apiEnum));
            }
            
            // Dtos
            foreach (var apiDto in apiModel.Dto)
            {
                GenerateFile("Dtos/" + apiDto.Name.ToSafeIdentifier() + "Dto.generated.cs", 
                    () => Visit(apiDto));
            }
            
            // API clients/endpoints
            foreach (var apiResource in apiModel.Resources)
            {
                GenerateFile(apiResource.DisplaySingular.ToSafeIdentifier() + "Client.generated.cs", 
                    () => Visit(apiResource));
            }

            // Response bodies generated from API clients/endpoints
            var currentIdToAnonymousClassMap = IdToAnonymousClassMap.ToImmutableSortedDictionary();
            var writtenIdToAnonymousClassMap = new SortedDictionary<string, ApiDto>();
            do
            {
                // Write output
                foreach (var (anonymousDtoKey, anonymousDto) in currentIdToAnonymousClassMap)
                {
                    GenerateFile("Dtos/" + anonymousDto.Name.ToSafeIdentifier() + "Dto.generated.cs", 
                        () => Visit(anonymousDto));
                    writtenIdToAnonymousClassMap.Add(anonymousDtoKey, anonymousDto);
                }
                
                // See if new classes have been generated?
                var temp = IdToAnonymousClassMap
                    .Where(it => !writtenIdToAnonymousClassMap.ContainsKey(it.Key))
                    .ToImmutableSortedDictionary();

                currentIdToAnonymousClassMap = temp;

            } while (currentIdToAnonymousClassMap.Count > 0);
            
            // Partial extensions
            var partialExtensionsVisitor = new CSharpPartialExtensionsVisitor(Builder, Indent, PropertiesToSkip, IdToDtoMap, IdToAnonymousClassMap);
            foreach (var apiDto in apiModel.Dto)
            {
                GenerateFile("Partials/" + apiDto.Name.ToSafeIdentifier() + "Dto.generated.cs", 
                    () => partialExtensionsVisitor.Visit(apiDto),
                    apiDto.Name.ToSafeIdentifier() + "Extensions");
            }
            foreach (var (_, anonymousDto) in IdToAnonymousClassMap)
            {
                GenerateFile("Partials/" + anonymousDto.Name.ToSafeIdentifier() + "Dto.generated.cs", 
                    () => partialExtensionsVisitor.Visit(anonymousDto),
                    anonymousDto.Name.ToSafeIdentifier() + "Extensions");
            }
        }

        public override void Visit(ApiEnum apiEnum)
        {
            if (apiEnum.Deprecation != null)
            {
                Visit(apiEnum.Deprecation);
            }
            
            Builder.AppendLine($"{Indent}[JsonConverter(typeof(EnumerationConverter))]");
            Builder.AppendLine($"{Indent}public sealed class " + apiEnum.Name.ToSafeIdentifier() + " : Enumeration");
            Builder.AppendLine($"{Indent}{{");
                
            Indent.Increment();
            Builder.AppendLine($"{Indent}private " + apiEnum.Name.ToSafeIdentifier() + "(string value) : base(value) { }");
            Builder.AppendLine($"{Indent}");
            
            foreach (var value in apiEnum.Values)
            {
                Builder.AppendLine($"{Indent}public static readonly " + apiEnum.Name.ToSafeIdentifier() + " " + value.ToSafeIdentifier() + " = new " + apiEnum.Name.ToSafeIdentifier() + "(\"" + value + "\");");
            }
            
            Indent.Decrement();
                
            Builder.AppendLine($"{Indent}}}");
            Builder.AppendLine($"{Indent}");
        }

        public override void Visit(ApiDto apiDto)
        {
            if (apiDto.Deprecation != null)
            {
                Visit(apiDto.Deprecation);
            }
                
            if (apiDto.HierarchyRole != HierarchyRole.INTERFACE && apiDto.Extends == null && apiDto.Inheritors.Count > 0)
            {
                // When extending another DTO, make sure to apply a converter
                Builder.AppendLine($"{Indent}[JsonConverter(typeof(ClassNameDtoTypeConverter))]");
            }

            var dtoHierarchyType = apiDto.HierarchyRole == HierarchyRole.INTERFACE
                ? "interface"
                : apiDto.HierarchyRole == HierarchyRole.ABSTRACT
                    ? "abstract class"
                    : apiDto.HierarchyRole == HierarchyRole.SEALED
                        ? "sealed class"
                        : "class";

            var dtoHierarchy = new List<string>();
            if (apiDto.Extends != null && IdToDtoMap.TryGetValue(apiDto.Extends.Id, out var apiDtoExtends))
            {
                dtoHierarchy.Add(apiDtoExtends.Name.ToSafeIdentifier() + "Dto");
            }
            if (apiDto.Implements != null)
            {
                foreach (var dtoImplements in apiDto.Implements)
                {
                    if (IdToDtoMap.TryGetValue(dtoImplements.Id, out var apiDtoImplements))
                    {
                        dtoHierarchy.Add(apiDtoImplements.Name.ToSafeIdentifier() + "Dto");
                    }
                }
            }
            if (dtoHierarchy.Count > 0 || apiDto.Inheritors.Count > 0)
            {
                dtoHierarchy.Add("IClassNameConvertible");
            }
            
            Builder.AppendLine($"{Indent}public {dtoHierarchyType} " + apiDto.Name.ToSafeIdentifier() + "Dto");
            if (dtoHierarchy.Count > 0)
            {
                Indent.Increment();
                Builder.AppendLine($"{Indent} : " + string.Join(", ", dtoHierarchy));
                Indent.Decrement();
            }
            Builder.AppendLine($"{Indent}{{");
            Indent.Increment();
            
            // When in a hierarchy, make sure we can capture the class name.
            if (dtoHierarchy.Count > 0)
            {
                Builder.AppendLine($"{Indent}[JsonPropertyName(\"className\")]");
                Builder.AppendLine($"{Indent}public string? ClassName {{ get; set; }}"); // TODO MAKE THIS READ-ONLY?
                Builder.AppendLine($"{Indent}");
            }
                
            // For implements, add all referenced types' fields
            if (apiDto.Implements != null)
            {
                foreach (var dtoReference in apiDto.Implements)
                {
                    if (IdToDtoMap.TryGetValue(dtoReference.Id, out var apiDtoImplements))
                    {
                        foreach (var apiDtoField in apiDtoImplements.Fields)
                        {
                            Visit(apiDtoField);
                        }
                    }
                }
            }

            // Add own fields
            foreach (var apiDtoField in apiDto.Fields)
            {
                if (!PropertiesToSkip.Contains(apiDto.Name.ToSafeIdentifier() + "Dto." + apiDtoField.Field.Name.ToSafeIdentifier().ToUppercaseFirst()))
                {
                    Visit(apiDtoField);
                }
            }

            Indent.Decrement();
            Builder.AppendLine($"{Indent}}}");
            Builder.AppendLine($"{Indent}");
        }
        
        public override void Visit(ApiField apiField)
        {
            if (!apiField.Type.Optional && !apiField.Type.Nullable)
            {
                Builder.AppendLine($"{Indent}[Required]");
            }
            Builder.AppendLine($"{Indent}[JsonPropertyName(\"{apiField.Name}\")]");
            
            Builder.Append($"{Indent}public ");
            Visit(apiField.Type);
            if (apiField.Type.Nullable)
            {
                Builder.Append("?");
            }
            Builder.Append(" ");
            Builder.Append(apiField.Name.ToSafeIdentifier().ToUppercaseFirst());
            Builder.Append(" { get; set; }");
            Builder.AppendLine($"{Indent}");
            Builder.AppendLine($"{Indent}");
        }

        public override void Visit(ApiFieldType apiFieldType)
        {
            switch (apiFieldType)
            {
                case ApiFieldType.Array apiFieldTypeArray:
                    Builder.Append("List<");
                    Visit(apiFieldTypeArray.ElementType);
                    Builder.Append(">");
                    break;
                
                case ApiFieldType.Dto apiFieldTypeDto:
                    if (apiFieldTypeDto.DtoRef?.Id != null && IdToDtoMap.TryGetValue(apiFieldTypeDto.DtoRef.Id, out var apiDto))
                    {
                        Builder.Append(apiDto.Name.ToSafeIdentifier() + "Dto");
                    }
                    else
                    {
                        Builder.Append("object");
                    }
                    break;
                
                case ApiFieldType.Enum apiFieldTypeEnum:
                    if (apiFieldTypeEnum.EnumRef?.Id != null && IdToEnumMap.TryGetValue(apiFieldTypeEnum.EnumRef.Id, out var apiEnum))
                    {
                        Builder.Append(apiEnum.Name.ToSafeIdentifier());
                    }
                    else
                    {
                        Builder.Append("string");
                    }
                    break;
                
                case ApiFieldType.Object apiFieldTypeObject:
                    if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.PAIR)
                    {
                        // Known anonymous type
                        Builder.Append("Pair<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        Builder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[1].Type);
                        Builder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.TRIPLE)
                    {
                        // Known anonymous type
                        Builder.Append("Triple<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        Builder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[1].Type);
                        Builder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[2].Type);
                        Builder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MAP_ENTRY)
                    {
                        // Known anonymous type
                        Builder.Append("MapEntry<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        Builder.Append(", ");
                        Visit(apiFieldTypeObject.Fields[1].Type);
                        Builder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.BATCH)
                    {
                        // Known anonymous type
                        Builder.Append("Batch<");
                        var dataFieldType = apiFieldTypeObject.Fields.First(it => string.Equals(it.Name, "data", StringComparison.OrdinalIgnoreCase));
                        var dataFieldArrayType = (ApiFieldType.Array)dataFieldType.Type;
                        Visit(dataFieldArrayType.ElementType);
                        Builder.Append(">");
                    }  
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.MOD)
                    {
                        // Known anonymous type
                        Builder.Append("Modification<");
                        Visit(apiFieldTypeObject.Fields[0].Type);
                        Builder.Append(">");
                    }
                    else if (apiFieldTypeObject.Kind == ApiFieldType.Object.ObjectKind.REQUEST_BODY)
                    {
                        // Request body/anonymous type - check whether we generated it before?
                        var anonymousClassFields = apiFieldTypeObject.Fields.Select(it => new ApiDtoField { Field = it }).ToList();

                        // TODO: make this check less expensive, serializing N times is probably not the best idea
                        var anonymousClassSignature = JsonSerializer.Serialize(anonymousClassFields);
                        var anonymousClass = IdToAnonymousClassMap.Values.FirstOrDefault(it => anonymousClassSignature == JsonSerializer.Serialize(it.Fields));
                        if (anonymousClass == null)
                        {
                            var anonymousClassId = !string.IsNullOrEmpty(_clientMethodName)
                                ? _clientMethodName + "Request"
                                : "Object" + IdToAnonymousClassMap.Count;
                            anonymousClass = new ApiDto
                            {
                                Id = anonymousClassId,
                                Name = anonymousClassId,
                                Fields = anonymousClassFields
                            };

                            IdToAnonymousClassMap[anonymousClassId] = anonymousClass;
                        }

                        Builder.Append(anonymousClass.Id + "Dto");
                    }
                    else
                    {
                        // Unknown object kind
                        throw new ResourceException("Could not generate class for object kind: " + apiFieldTypeObject.Kind);
                    }

                    break;
                
                case ApiFieldType.Primitive apiFieldTypePrimitive:
                    Builder.Append(apiFieldTypePrimitive.Type.ToCSharpPrimitiveType());
                    break;

                case ApiFieldType.Ref apiFieldTypeReference:
                    if (apiFieldTypeReference.DtoRef?.Id != null && IdToDtoMap.TryGetValue(apiFieldTypeReference.DtoRef.Id, out var apiReferenceDto))
                    {
                        Builder.Append(apiReferenceDto.Name.ToSafeIdentifier() + "Dto");
                    }
                    else
                    {
                        Builder.Append("object");
                    }
                    break;
                
                default:
                    Builder.Append("object");
                    break;
            }
        }

        private string _baseEndpointPath = string.Empty;
        private string _resourceBreadcrumbPath = string.Empty;
        private HashSet<string> _resourceBreadcrumbPaths = new HashSet<string>();

        public override void Visit(ApiResource apiResource)
        {
            var originalBaseEndpointPath = _baseEndpointPath;
            _baseEndpointPath = (_baseEndpointPath.Length > 0 ? _baseEndpointPath + "/" : _baseEndpointPath) +  apiResource.Path.Segments.ToPath();
        
            var originalResourceBreadcrumbPath = _resourceBreadcrumbPath;
            _resourceBreadcrumbPath = (_resourceBreadcrumbPath.Length > 0 ? _resourceBreadcrumbPath + "." : _resourceBreadcrumbPath) +  apiResource.DisplaySingular.ToSafeIdentifier();

            Visit(apiResource, true);
        
            _resourceBreadcrumbPath = originalResourceBreadcrumbPath;
            _baseEndpointPath = originalBaseEndpointPath;
        }

        public void Visit(ApiResource apiResource, bool withConstructor)
        {
            // Client class
            Builder.AppendLine($"{Indent}public partial class " + apiResource.DisplaySingular.ToSafeIdentifier() + "Client");
            Builder.AppendLine($"{Indent}{{");
            Indent.Increment();

            // Constructor needed?
            if (withConstructor)
            {
                Builder.AppendLine($"{Indent}private readonly Connection _connection;");
                Builder.AppendLine($"{Indent}");
                Builder.AppendLine($"{Indent}public " + apiResource.DisplaySingular.ToSafeIdentifier() + "Client(Connection connection)");
                Builder.AppendLine($"{Indent}{{");
                Indent.Increment();

                Builder.AppendLine($"{Indent}_connection = connection;");
            
                Indent.Decrement();
                Builder.AppendLine($"{Indent}}}");
                Builder.AppendLine($"{Indent}");
            }
        
            // Endpoint methods
            foreach (var apiEndpoint in apiResource.Endpoints)
            {
                Visit(apiResource, apiEndpoint);
            }

            // Group nested resources by path
            var resourcePathBuildingVisitor = new ResourcePathBuildingVisitor(1, 2);
            resourcePathBuildingVisitor.Visit(apiResource);
            foreach (var (_, apiNestedResources) in resourcePathBuildingVisitor.Paths)
            {
                var isFirstResource = true;
                foreach (var apiNestedResource in apiNestedResources)
                {
                    var originalBaseEndpointPath = _baseEndpointPath;
                    _baseEndpointPath = (_baseEndpointPath.Length > 0 ? _baseEndpointPath + "/" : _baseEndpointPath) +  apiNestedResource.Path.Segments.ToPath();
        
                    var originalResourceBreadcrumbPath = _resourceBreadcrumbPath;
                    _resourceBreadcrumbPath = (_resourceBreadcrumbPath.Length > 0 ? _resourceBreadcrumbPath + "." : _resourceBreadcrumbPath) +  apiNestedResource.DisplaySingular.ToSafeIdentifier();

                    var isFirstWrite = _resourceBreadcrumbPaths.Add(_resourceBreadcrumbPath);
                    if (isFirstResource && isFirstWrite)
                    {
                        Builder.AppendLine($"{Indent}public " + apiNestedResource.DisplaySingular.ToSafeIdentifier() + "Client " + apiNestedResource.DisplayPlural.ToSafeIdentifier() + " => new " + apiNestedResource.DisplaySingular.ToSafeIdentifier() + "Client(_connection);");
                        Builder.AppendLine($"{Indent}");
                    }
                    Visit(apiNestedResource, isFirstResource && isFirstWrite);
        
                    _resourceBreadcrumbPath = originalResourceBreadcrumbPath;
                    _baseEndpointPath = originalBaseEndpointPath;

                    isFirstResource = false;
                }
            }

            Indent.Decrement();
            Builder.AppendLine($"{Indent}}}");
            Builder.AppendLine($"{Indent}");
        }
        
        private string _clientMethodName = string.Empty;
        
        public override void Visit(ApiResource apiResource, ApiEndpoint apiEndpoint)
        {
            var endpointPath = (_baseEndpointPath + "/" + apiEndpoint.Path.Segments.ToPath()).TrimEnd('/');

            var apiCallMethod = apiEndpoint.Method.ToHttpMethod();
            _clientMethodName = apiEndpoint.DisplayName.ToSafeIdentifier()!;

            bool AppendParameterList(ApiEndpoint apiEndpoint1)
            {
                var methodParameters = apiEndpoint1.Parameters.OrderBy(it => !it.Field.Type.Nullable ? 0 : 1).ToList();
                foreach (var apiEndpointParameter in methodParameters)
                {
                    Visit(apiEndpointParameter.Field.Type);
                    if (apiEndpointParameter.Field.Type.Nullable)
                    {
                        Builder.Append("?");
                    }
                    Builder.Append(" ");
                    Builder.Append(apiEndpointParameter.Field.Name.ToSafeVariableIdentifier());
                    if (apiEndpointParameter.Field.Type.Nullable)
                    {
                        Builder.Append(" = null");
                    }

                    if (apiEndpointParameter != methodParameters.Last())
                    {
                        Builder.Append(", ");
                    }
                }

                return methodParameters.Count > 0;
            }

            bool AppendRequestParameterList(ApiEndpoint apiEndpoint1)
            {
                var methodParameters = apiEndpoint1.Parameters.Where(it => !it.Path).ToList();
                if (methodParameters.Count > 0)
                {
                    Builder.Append("?");
                }
                
                foreach (var apiEndpointParameter in methodParameters)
                {
                    Builder.Append(apiEndpointParameter.Field.Name);
                    Builder.Append("=");
                    Builder.Append("{");
                    Builder.Append(apiEndpointParameter.Field.Name.ToSafeVariableIdentifier());
                    
                    if (apiEndpointParameter.Field.Type is ApiFieldType.Array arrayType)
                    {
                        // For lists, we will need to repeat the parameter for each element
                        Builder.Append(!apiEndpointParameter.Field.Type.Nullable
                            ? ".JoinToString("
                            : "?.JoinToString(");
                        
                        Builder.Append("\"");
                        Builder.Append(apiEndpointParameter.Field.Name);
                        Builder.Append("\", it => it");
                        
                        Builder.Append(!arrayType.ElementType.Nullable
                            ? ".ToString()"
                            : "?.ToString()");
                    
                        if (arrayType.ElementType is ApiFieldType.Primitive primitive && primitive.Type.Equals("Boolean", StringComparison.OrdinalIgnoreCase))
                        {
                            // Boolean needs lowercase value
                            Builder.Append(!arrayType.ElementType.Nullable
                                ? ".ToLowerInvariant()"
                                : "?.ToLowerInvariant()"); }

                        Builder.Append(")");
                    }
                    else
                    {
                        // Anything else can be "ToString()"
                        Builder.Append(!apiEndpointParameter.Field.Type.Nullable
                            ? ".ToString()"
                            : "?.ToString()");
                    
                        if (apiEndpointParameter.Field.Type is ApiFieldType.Primitive primitive && primitive.Type.Equals("Boolean", StringComparison.OrdinalIgnoreCase))
                        {
                            // Boolean needs lowercase value
                            Builder.Append(!apiEndpointParameter.Field.Type.Nullable
                                ? ".ToLowerInvariant()"
                                : "?.ToLowerInvariant()");
                        }
                    }

                    if (apiEndpointParameter.Field.Type.Nullable)
                    {
                        // Used to be able to filter out nullable query string parameters in Connection.CleanNullableNullQueryStringParameters
                        Builder.Append(" ?? \"null\"");
                    }
                    Builder.Append("}");
                    
                    if (apiEndpointParameter != methodParameters.Last())
                    {
                        Builder.Append("&");
                    }
                }

                return methodParameters.Count > 0;
            }
            
            if (!string.IsNullOrEmpty(apiEndpoint.Documentation))
            {
                Builder.AppendLine($"{Indent}/// <summary>");
                Builder.AppendLine($"{Indent}/// {apiEndpoint.Documentation}");
                Builder.AppendLine($"{Indent}/// </summary>");
            }
            
            if (apiEndpoint.Deprecation != null)
            {
                Visit(apiEndpoint.Deprecation);
            }
            
            var isResponsePrimitiveOrArrayOfPrimitive = apiEndpoint.ResponseBody is ApiFieldType.Primitive 
              || (apiEndpoint.ResponseBody is ApiFieldType.Array arrayField && arrayField.ElementType is ApiFieldType.Primitive);
            
            if (apiEndpoint.RequestBody == null && apiEndpoint.ResponseBody == null)
            {
                Builder.Append($"{Indent}public async Task " + _clientMethodName + "(");

                AppendParameterList(apiEndpoint);

                Builder.AppendLine(")");
                Indent.Increment();
                Builder.Append($"{Indent}=> await _connection.RequestResourceAsync");
                Builder.Append("(\"" + apiCallMethod + "\", ");
                Builder.Append("$\"api/http/" + endpointPath);
                AppendRequestParameterList(apiEndpoint);
                Builder.Append("\");");
                Indent.Decrement();
                Builder.AppendLine($"{Indent}");
            }
            else if (apiEndpoint.RequestBody == null && apiEndpoint.ResponseBody != null)
            {
                Builder.Append($"{Indent}public async Task<");
                Visit(apiEndpoint.ResponseBody);
                Builder.Append(">");
                Builder.Append(" " + _clientMethodName + "(");
            
                if (AppendParameterList(apiEndpoint) && !isResponsePrimitiveOrArrayOfPrimitive)
                {
                    Builder.Append(", ");
                }

                if (!isResponsePrimitiveOrArrayOfPrimitive)
                {
                    Builder.Append("Func<Partial<");
                    Visit(apiEndpoint.ResponseBody is ApiFieldType.Array a
                        ? a.ElementType
                        : apiEndpoint.ResponseBody);
                    Builder.Append(">, Partial<");
                    Visit(apiEndpoint.ResponseBody is ApiFieldType.Array b
                        ? b.ElementType
                        : apiEndpoint.ResponseBody);
                    Builder.Append(">> partialBuilder = null");
                }

                Builder.AppendLine(")");
                Indent.Increment();
                Builder.Append($"{Indent}=> await _connection.RequestResourceAsync<");
                Visit(apiEndpoint.ResponseBody);
                Builder.Append(">");
                Builder.Append("(\"" + apiCallMethod + "\", ");
                Builder.Append("$\"api/http/" + endpointPath);
                Builder.Append(AppendRequestParameterList(apiEndpoint) ? "&" : "?");
                if (!isResponsePrimitiveOrArrayOfPrimitive)
                {
                    Builder.Append("$fields=\" + (partialBuilder != null ? partialBuilder(new Partial<");
                    Visit(apiEndpoint.ResponseBody is ApiFieldType.Array a
                        ? a.ElementType
                        : apiEndpoint.ResponseBody);
                    Builder.Append(">()) : Partial<");
                    Visit(apiEndpoint.ResponseBody is ApiFieldType.Array b
                        ? b.ElementType
                        : apiEndpoint.ResponseBody);
                    Builder.Append(">.Default())");
                }
                else
                {
                    Builder.Append("\"");
                }
                Builder.Append(");");

                Indent.Decrement();
                Builder.AppendLine($"{Indent}");
            }
            else if (apiEndpoint.RequestBody != null && apiEndpoint.ResponseBody == null)
            {
                Builder.Append($"{Indent}public async Task");
                Builder.Append(" " + _clientMethodName + "(");
            
                if (AppendParameterList(apiEndpoint))
                {
                    Builder.Append(", ");
                }
                
                Visit(apiEndpoint.RequestBody);
                Builder.Append(" data");
                
                Builder.AppendLine(")");
                Indent.Increment();
                Builder.Append($"{Indent}=> await _connection.RequestResourceAsync<");
                Visit(apiEndpoint.RequestBody);
                Builder.Append(">");
                Builder.Append("(\"" + apiCallMethod + "\", ");
                Builder.Append("$\"api/http/" + endpointPath);
                AppendRequestParameterList(apiEndpoint);
                Builder.Append("\", data);");
                Indent.Decrement();
                Builder.AppendLine($"{Indent}");
            }
            else if (apiEndpoint.RequestBody != null && apiEndpoint.ResponseBody != null)
            {
                Builder.Append($"{Indent}public async Task<");
                Visit(apiEndpoint.ResponseBody);
                Builder.Append(">");
                Builder.Append(" " + _clientMethodName + "(");

                if (AppendParameterList(apiEndpoint))
                {
                    Builder.Append(", ");
                }

                Visit(apiEndpoint.RequestBody);
                Builder.Append(" data");

                if (!isResponsePrimitiveOrArrayOfPrimitive)
                {
                    Builder.Append(", ");
                    Builder.Append("Func<Partial<");
                    Visit(apiEndpoint.ResponseBody is ApiFieldType.Array a
                        ? a.ElementType
                        : apiEndpoint.ResponseBody);
                    Builder.Append(">, Partial<");
                    Visit(apiEndpoint.ResponseBody is ApiFieldType.Array b
                        ? b.ElementType
                        : apiEndpoint.ResponseBody);
                    Builder.Append(">> partialBuilder = null");
                }

                Builder.AppendLine(")");
                Indent.Increment();
                Builder.Append($"{Indent}=> await _connection.RequestResourceAsync<");
                Visit(apiEndpoint.RequestBody);
                Builder.Append(", ");
                Visit(apiEndpoint.ResponseBody);
                Builder.Append(">");
                Builder.Append("(\"" + apiCallMethod + "\", ");
                Builder.Append("$\"api/http/" + endpointPath);
                Builder.Append(AppendRequestParameterList(apiEndpoint) ? "&" : "?");
                if (!isResponsePrimitiveOrArrayOfPrimitive)
                {
                    Builder.Append("$fields=\" + (partialBuilder != null ? partialBuilder(new Partial<");
                    Visit(apiEndpoint.ResponseBody is ApiFieldType.Array a
                        ? a.ElementType
                        : apiEndpoint.ResponseBody);
                    Builder.Append(">()) : Partial<");
                    Visit(apiEndpoint.ResponseBody is ApiFieldType.Array b
                        ? b.ElementType
                        : apiEndpoint.ResponseBody);
                    Builder.Append(">.Default()), ");
                }
                else
                {
                    Builder.Append("\", ");
                }
                Builder.Append("data);");
                Indent.Decrement();
                Builder.AppendLine($"{Indent}");
            }
            else
            {
                Builder.AppendLine($"{Indent}#warning UNSUPPORTED CASE - " + apiEndpoint.DisplayName.ToSafeIdentifier() + " - " + apiEndpoint.Method.ToHttpMethod() + " " + endpointPath);
            }
            
            Builder.AppendLine($"{Indent}");

            _clientMethodName = string.Empty;
        }

        private void Visit(ApiDeprecation apiDeprecation)
        {
            Builder.Append($"{Indent}[Obsolete(\"");
            if (!string.IsNullOrEmpty(apiDeprecation.Message))
            {
                Builder.Append(apiDeprecation.Message);
            }
            else
            {
                Builder.Append("This is obsolete");
            }
            if (!string.IsNullOrEmpty(apiDeprecation.Since))
            {
                Builder.Append(" (since " + apiDeprecation.Since + ")");
            }
            if (apiDeprecation.ForRemoval)
            {
                Builder.Append(" (marked for removal)");
            }
            Builder.Append("\")]");
            Builder.AppendLine($"{Indent}");
        }
        
        private void GenerateFile(string fileName, Action generate, string namespaceSuffix = null)
        {
            // Start building
            Indent.Reset();
            Builder.Clear();
            Builder.AppendLine($"{Indent}// ------------------------------------------------------------------------------");
            Builder.AppendLine($"{Indent}// <auto-generated>");
            Builder.AppendLine($"{Indent}//     This code was generated by a tool.");
            Builder.AppendLine($"{Indent}// ");
            Builder.AppendLine($"{Indent}//     Changes to this file may cause incorrect behavior and will be lost if");
            Builder.AppendLine($"{Indent}//     the code is regenerated.");
            Builder.AppendLine($"{Indent}// </auto-generated>");
            Builder.AppendLine($"{Indent}// ------------------------------------------------------------------------------");
            Builder.AppendLine($"{Indent}");
            Builder.AppendLine($"{Indent}#nullable enable");
            Builder.AppendLine($"{Indent}");
            Builder.AppendLine($"{Indent}using System;");
            Builder.AppendLine($"{Indent}using System.Collections.Generic;");
            Builder.AppendLine($"{Indent}using System.ComponentModel.DataAnnotations;");
            Builder.AppendLine($"{Indent}using System.Text.Json.Serialization;");
            Builder.AppendLine($"{Indent}using System.Threading.Tasks;");
            Builder.AppendLine($"{Indent}using SpaceDotNet.Client.Internal;");
            Builder.AppendLine($"{Indent}using SpaceDotNet.Common;");
            Builder.AppendLine($"{Indent}using SpaceDotNet.Common.Json.Serialization;");
            Builder.AppendLine($"{Indent}using SpaceDotNet.Common.Types;");
            Builder.AppendLine($"{Indent}");
            Builder.AppendLine($"{Indent}namespace SpaceDotNet.Client{(!string.IsNullOrEmpty(namespaceSuffix) ? "." + namespaceSuffix : "")}");
            Builder.AppendLine($"{Indent}{{");
            Indent.Increment();

            generate();
            
            Indent.Decrement();
            Builder.AppendLine($"{Indent}}}");

            WriteFile(fileName, Builder.ToString());
        }
    }
}