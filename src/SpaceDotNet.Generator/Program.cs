using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using SpaceDotNet.Common;
using SpaceDotNet.Generator.Model.HttpApi;
using SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp;

namespace SpaceDotNet.Generator
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static async Task Main(string[] args)
        {
            // Metadata
            var connection = new ClientCredentialsConnection(
                Environment.GetEnvironmentVariable("SPACE_SERVERURL")!,
                Environment.GetEnvironmentVariable("SPACE_CLIENTID")!,
                Environment.GetEnvironmentVariable("SPACE_CLIENTSECRET")!,
                new HttpClient());
            
            var apiModel = await connection.RequestResourceAsync<ApiModel>(
                "GET", "api/http/http-api-model?$fields=dto(id,deprecation,extends,fields,hierarchyRole,implements,inheritors,name,record),enums(id,deprecation,name,values),resources(id,displayPlural,displaySingular,endpoints,nestedResources!,parentResource,path)");
            
            // Remove old code
            var generatedCodePath = Path.GetFullPath("../../../../SpaceDotNet.Client/Generated");
            Directory.Delete(generatedCodePath, recursive: true);
            
            // Build code
            var csharpApiModelVisitor = new CSharpApiModelVisitor((fileName, fileContents) =>
            {
                var filePath = Path.GetFullPath("../../../../SpaceDotNet.Client/Generated/" + fileName);
                Directory.GetParent(filePath).Create();
                File.WriteAllText(filePath, fileContents);
            });
            csharpApiModelVisitor.Visit(apiModel);
        }
    }
}