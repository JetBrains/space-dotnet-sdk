using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

[Obsolete("Field \"hierarchyRole\" is deprecated since 20-07-2021: Use hierarchyRole2")]
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