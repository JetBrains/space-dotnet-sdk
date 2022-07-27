using System;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp;

public sealed class CSharpType : Enumeration
{
    private CSharpType(string value, Type? jsonConverter = null, string? formatString = null) : base(value)
    {
        JsonConverter = jsonConverter;
        FormatString = formatString;
    }

    public Type? JsonConverter { get; }
    public string? FormatString { get; }

    public static readonly CSharpType Byte = new("byte");
    public static readonly CSharpType Short = new("short");
    public static readonly CSharpType Int = new("int");
    public static readonly CSharpType Long = new("long");
    public static readonly CSharpType Float = new("float");
    public static readonly CSharpType Double = new("double");
    public static readonly CSharpType Bool = new("bool", null, "l");
    public static readonly CSharpType String = new("string");
    public static readonly CSharpType SpaceDate = new("DateTime", typeof(SpaceDateConverter), SpaceDateConverter.FormatString);
    public static readonly CSharpType SpaceTime = new("DateTime", typeof(SpaceDateTimeConverter), SpaceDateTimeConverter.FormatString);
    public static readonly CSharpType SpaceDuration = new("TimeSpan", typeof(SpaceDurationConverter));
    public static readonly CSharpType Object = new("object");
    
    public static readonly CSharpType CancellationToken = new("CancellationToken");
}