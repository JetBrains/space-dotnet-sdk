using System.IO;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp
{
    public class CSharpDocumentWriter : IDocumentWriter
    {
        private readonly DirectoryInfo _rootDirectory;

        public CSharpDocumentWriter(DirectoryInfo rootDirectory)
        {
            _rootDirectory = rootDirectory;
        }

        public void WriteDocument(string relativePath, string content)
        {
            _rootDirectory.Create();
            var filePath = Path.Combine(_rootDirectory.FullName, relativePath);
            Directory.GetParent(filePath).Create();
            File.WriteAllText(filePath, content);
        }
    }
}