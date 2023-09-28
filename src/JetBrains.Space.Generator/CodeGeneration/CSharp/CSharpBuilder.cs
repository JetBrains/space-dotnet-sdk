using System.Text;
using JetBrains.Annotations;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp;

[PublicAPI]
public class CSharpBuilder
{
    private readonly StringBuilder _stringBuilder = new();

    public CSharpBuilder AppendLine()
    {
        _stringBuilder.AppendLine();
        return this;
    }

    public CSharpBuilder AppendLine(string line)
    {
        _stringBuilder.AppendLine(line);
        return this;
    }

    public CSharpBuilder Append(char value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CSharpBuilder Append(string value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public CSharpBuilder Append(object value)
    {
        _stringBuilder.Append(value);
        return this;
    }

    public void Clear() => _stringBuilder.Clear();

    public override string ToString() => _stringBuilder.ToString();
}