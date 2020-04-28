using System;
using System.IO;
using System.Net.Http;
using System.Text;
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
                Environment.GetEnvironmentVariable("SPACE_SERVERURL"),
                Environment.GetEnvironmentVariable("SPACE_CLIENTID"),
                Environment.GetEnvironmentVariable("SPACE_CLIENTSECRET"),
                new HttpClient());
            
            var apiModel = await connection.RequestResourceAsync<ApiModel>(
                "GET", "api/http/http-api-model?$fields=dto(id,deprecation,extends,fields,hierarchyRole,implements,inheritors,name,record),enums(id,deprecation,name,values),resources(id,displayPlural,displaySingular,endpoints,nestedResources!,parentResource,path)");
            
            // Build code
            var apiModelCodeBuilder = new StringBuilder();
            var apiModelVisitor = new CSharpApiModelVisitor(apiModelCodeBuilder);
            apiModelVisitor.Visit(apiModel);
            File.WriteAllText("../../../../SpaceDotNet.Client/Space.generated.cs", apiModelCodeBuilder.ToString());
        }
    }
}