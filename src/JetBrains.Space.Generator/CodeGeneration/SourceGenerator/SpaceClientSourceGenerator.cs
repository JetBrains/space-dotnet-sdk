using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Generator.CodeGeneration.CSharp;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;
using JetBrains.Space.Generator.Model.HttpApi;
using Microsoft.CodeAnalysis;

namespace JetBrains.Space.Generator.CodeGeneration.SourceGenerator
{
    [Generator, UsedImplicitly]
    public class SpaceClientSourceGenerator : ISourceGenerator
    {
        private static readonly DiagnosticDescriptor ExceptionDiagnostic = new DiagnosticDescriptor(
            "SPC000", "An exception occurred while generating code", "An exception occurred while generating code: {0} {1} {2}", nameof(SpaceClientSourceGenerator), DiagnosticSeverity.Error, true);

        public void Initialize(GeneratorInitializationContext context)
        {
            // noop
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var cancellationToken = context.CancellationToken;
            
            try
            {
                ExecuteAsync(context, cancellationToken).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                context.ReportDiagnostic(Diagnostic.Create(
                    ExceptionDiagnostic, null, ex.Message, ex.StackTrace, ex));
            }
        }

        private async Task ExecuteAsync(GeneratorExecutionContext context, CancellationToken cancellationToken)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            
            // Load model
            var jsonSerializerOptions = new JsonSerializerOptions()
                .AddSpaceJsonTypeConverters();

            var apiModel = JsonSerializer.Deserialize<ApiModel>(
                await File.ReadAllTextAsync("C:\\users\\maart\\desktop\\ha_model.json"), jsonSerializerOptions);

            // Build code
            var codeGenerationContext = CodeGenerationContext.CreateFrom(apiModel);
            var csharpApiModelVisitor = new CSharpApiModelGenerator(codeGenerationContext);
            csharpApiModelVisitor.GenerateFiles(new SourceGenerationWriter(context));
            
            // Report
            stopwatch.Stop();
            // Console.WriteLine($"Code generation completed in: {stopwatch.Elapsed}");
            // Console.WriteLine($"  Number of DTO: {codeGenerationContext.GetDtos().Count()}");
            // Console.WriteLine($"  Number of Enums: {codeGenerationContext.GetEnums().Count()}");
            // Console.WriteLine($"  Number of Resources (top level): {codeGenerationContext.GetResources().Count()}");
            //
            // // Write version marker
            // if (deploymentInfo.Version == null)
            // {
            //     Console.ForegroundColor = ConsoleColor.Red;
            //     Console.WriteLine($"ERROR: Version is not available in deployment information.");
            // }
            // await File.WriteAllTextAsync("../../../../../version-info.txt", deploymentInfo.Version);
            //
            // return 0;
        }
    }
}