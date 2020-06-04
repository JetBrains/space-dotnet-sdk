using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using SpaceDotNet.Common;
using SpaceDotNet.Generator.CodeGeneration.CSharp;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static async Task Main(string[] args)
        {
            // Metadata
            var connection = new ClientCredentialsConnection(
                Environment.GetEnvironmentVariable("JB_SPACE_API_URL")!,
                Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_ID")!,
                Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_SECRET")!,
                new HttpClient());
            
            var apiModel = await connection.RequestResourceAsync<ApiModel>(
                "GET", "api/http/http-api-model?$fields=dto(id,deprecation,extends,fields,hierarchyRole,implements,inheritors,name,record),enums(id,deprecation,name,values),resources(id,displayPlural,displaySingular,endpoints,nestedResources!,parentResource,path)");
            
            // Remove old code
            var generatedCodePath = Path.GetFullPath("../../../../SpaceDotNet.Client/Generated");
            if (Directory.Exists(generatedCodePath))
            {
                Directory.Delete(generatedCodePath, recursive: true);
            }

            // Build code
            var csharpApiModelVisitor = new CSharpApiModelGenerator(apiModel);
            csharpApiModelVisitor.GenerateFiles(
                new CSharpDocumentWriter(
                    new DirectoryInfo(Path.GetFullPath("../../../../SpaceDotNet.Client/Generated/"))));
        }
    }
}