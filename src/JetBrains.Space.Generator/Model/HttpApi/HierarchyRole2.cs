using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

[JsonConverter(typeof(EnumStringConverter))]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public enum HierarchyRole2
{
    [EnumMember(Value = "SEALED_CLASS")] SEALED_CLASS,
    [EnumMember(Value = "OPEN_CLASS")] OPEN_CLASS,
    [EnumMember(Value = "FINAL_CLASS")] FINAL_CLASS,
    [EnumMember(Value = "ABSTRACT_CLASS")] ABSTRACT_CLASS,
    [EnumMember(Value = "INTERFACE")] INTERFACE,
    [EnumMember(Value = "SEALED_INTERFACE")] SEALED_INTERFACE,
}