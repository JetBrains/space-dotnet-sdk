using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SpaceDotNet.Common;
using SpaceDotNet.Generator.CodeGeneration.CSharp;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Generators;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Constants.SpaceLogoAscii);
            Console.WriteLine();
            Console.WriteLine("JetBrains Space");
            Console.ResetColor();
            Console.WriteLine();
            
            using var httpClient = new HttpClient();
            
            // Deployment info
            var deploymentInfoClient = new DeploymentInfoClient(
                Environment.GetEnvironmentVariable("JB_SPACE_API_URL")!, 
                httpClient);

            var deploymentInfo = await deploymentInfoClient.GetDeploymentInfoAsync();

            Console.WriteLine("Server information:");
            Console.WriteLine(deploymentInfo);
            
            // Metadata
            var connection = new ClientCredentialsConnection(
                Environment.GetEnvironmentVariable("JB_SPACE_API_URL")!,
                Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_ID")!,
                Environment.GetEnvironmentVariable("JB_SPACE_CLIENT_SECRET")!,
                httpClient);
            
            var apiModel = await connection.RequestResourceAsync<ApiModel>(
                "GET", "api/http/http-api-model?$fields=dto,enums,urlParams,resources(*,nestedResources!)");
            
            // Remove old code
            var generatedCodePath = Path.GetFullPath("../../../../SpaceDotNet.Client/Generated");
            if (Directory.Exists(generatedCodePath))
            {
                Directory.Delete(generatedCodePath, recursive: true);
            }

            // Build code
            var codeGenerationContext = CodeGenerationContext.CreateFrom(apiModel);
            var csharpApiModelVisitor = new CSharpApiModelGenerator(codeGenerationContext);
            csharpApiModelVisitor.GenerateFiles(
                new CSharpDocumentWriter(
                    new DirectoryInfo(Path.GetFullPath("../../../../SpaceDotNet.Client/Generated/"))));
            
            // Report
            stopwatch.Stop();
            Console.WriteLine($"Code generation completed in: {stopwatch.Elapsed}");
            Console.WriteLine($"  Number of DTO: {codeGenerationContext.GetDtos().Count()}");
            Console.WriteLine($"  Number of Enums: {codeGenerationContext.GetEnums().Count()}");
            Console.WriteLine($"  Number of Resources (top level): {codeGenerationContext.GetResources().Count()}");
        }
    }
}