using System;
using System.IO;
using System.Text;
using JetBrains.Annotations;

namespace JetBrains.Space.Generator.CodeGeneration;

[PublicAPI]
public class Indent
{
    public int Level { get; private set; }
        
    public Indent Increment()
    {
        Level++;
        return this;
    }
        
    public Indent Decrement()
    {
        Level--;
        if (Level < 0) Level = 0;
        return this;
    }

    public Indent Reset()
    {
        Level = 0;
        return this;
    }

    public string Wrap(string subject)
    {
        var builder = new StringBuilder();
        var reader = new StringReader(subject);
        var line = reader.ReadLine();
        while (line != null)
        {
            if (!line.StartsWith("#")) // no indent for lines that are a directive
            {
                builder.Append(ToString());
            }
            builder.AppendLine(line.TrimEnd(Environment.NewLine.ToCharArray()));
            line = reader.ReadLine();
        }
        return builder.ToString();
    }

    public override string ToString() => new(' ', Level * 4);
}