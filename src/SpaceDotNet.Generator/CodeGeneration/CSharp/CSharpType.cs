using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    public sealed class CSharpType : Enumeration
    {
        private CSharpType(string value) : base(value) { }
        
        public static readonly CSharpType Byte = new CSharpType("byte");
        public static readonly CSharpType Short = new CSharpType("short");
        public static readonly CSharpType Int = new CSharpType("int");
        public static readonly CSharpType Long = new CSharpType("long");
        public static readonly CSharpType Float = new CSharpType("float");
        public static readonly CSharpType Double = new CSharpType("double");
        public static readonly CSharpType Bool = new CSharpType("bool");
        public static readonly CSharpType String = new CSharpType("string");
        public static readonly CSharpType SpaceDate = new CSharpType("SpaceDate");
        public static readonly CSharpType SpaceTime = new CSharpType("SpaceTime");
        public static readonly CSharpType Object = new CSharpType("object");
        
        public static readonly CSharpType CancellationToken = new CSharpType("CancellationToken");
    }
}