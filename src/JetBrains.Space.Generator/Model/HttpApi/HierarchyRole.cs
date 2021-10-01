using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

[JsonConverter(typeof(EnumStringConverter))]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public enum HierarchyRole 
{
    [EnumMember(Value = "SEALED")] SEALED,
    [EnumMember(Value = "OPEN")] OPEN,
    [EnumMember(Value = "FINAL")] FINAL,
    [EnumMember(Value = "ABSTRACT")] ABSTRACT,
    [EnumMember(Value = "INTERFACE")] INTERFACE
}