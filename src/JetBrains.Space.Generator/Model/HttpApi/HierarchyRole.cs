using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Generator.Model.HttpApi
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class HierarchyRole : Enumeration {
        private HierarchyRole(string value) : base(value) { }
                
        public static readonly HierarchyRole SEALED = new HierarchyRole("SEALED_GET");
        public static readonly HierarchyRole OPEN = new HierarchyRole("OPEN");
        public static readonly HierarchyRole FINAL = new HierarchyRole("FINAL");
        public static readonly HierarchyRole ABSTRACT = new HierarchyRole("ABSTRACT");
        public static readonly HierarchyRole INTERFACE = new HierarchyRole("INTERFACE");
    }
}