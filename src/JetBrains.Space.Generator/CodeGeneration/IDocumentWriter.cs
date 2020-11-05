namespace JetBrains.Space.Generator.CodeGeneration
{
    public interface IDocumentWriter
    {
        void WriteDocument(string relativePath, string content);
    }
}