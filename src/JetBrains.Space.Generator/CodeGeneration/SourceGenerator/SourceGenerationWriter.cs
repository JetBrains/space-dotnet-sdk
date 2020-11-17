using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis;

namespace JetBrains.Space.Generator.CodeGeneration.SourceGenerator
{
    public class SourceGenerationWriter : IDocumentWriter
    {
        private readonly GeneratorExecutionContext _context;

        public SourceGenerationWriter(GeneratorExecutionContext context) 
            => _context = context;

        public void WriteDocument(string relativePath, string content)
        {
            try

            {
                _context.AddSource(relativePath.Replace("/", "_").Replace(".cs", Guid.NewGuid() + ".cs"), content);
            }
            catch (Exception ex)
            {
                throw new Exception(relativePath);
                Debugger.Break();
            }
        }
    }
}