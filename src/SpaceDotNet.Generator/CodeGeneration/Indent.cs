using System;
using System.Collections.Immutable;
using System.IO;
using System.Text;

namespace SpaceDotNet.Generator.CodeGeneration
{
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
                builder.AppendLine(ToString() + line.TrimEnd(Environment.NewLine.ToCharArray()));
                line = reader.ReadLine();
            }
            return builder.ToString();
        }

        public override string ToString() => new string(' ', Level * 4);
    }
}