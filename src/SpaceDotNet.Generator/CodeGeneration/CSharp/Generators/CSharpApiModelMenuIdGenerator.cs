using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceDotNet.Common.Utilities;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Generators
{
    public class CSharpApiModelMenuIdGenerator
    {
        private readonly CodeGenerationContext _context;

        public CSharpApiModelMenuIdGenerator(CodeGenerationContext context)
        {
            _context = context;
        }
        
        public string GenerateMenuIds(IEnumerable<ApiMenuId> menuIds)
        {
            var indent = new Indent();
            var builder = new StringBuilder();
            
            builder.AppendLine($"{indent}[JsonConverter(typeof(EnumerationConverter))]");
            builder.AppendLine($"{indent}public sealed class MenuId : Enumeration");
            builder.AppendLine($"{indent}{{");
                
            indent.Increment();
            builder.AppendLine($"{indent}private MenuId(string value) : base(value) {{ }}");
            builder.AppendLine($"{indent}");
            
            var tree = BuildTree("", menuIds.OrderBy(it => it.MenuId));
            builder.Append(
                indent.Wrap(
                    GenerateMenuIds(tree)));

            indent.Decrement();
                
            builder.AppendLine($"{indent}}}");

            return builder.ToString();
        }
        
        private string GenerateMenuIds(Node node)
        {
            var indent = new Indent();
            var builder = new StringBuilder();

            var lastDotIndexInPrefix = node.Prefix.LastIndexOf(".", StringComparison.Ordinal);
            var commonPrefix = lastDotIndexInPrefix >= 0
                ? CSharpIdentifier.ForClassOrNamespace(node.Prefix.Substring(lastDotIndexInPrefix + 1))
                : CSharpIdentifier.ForClassOrNamespace(node.Prefix);
            
            if (node.Children.Count <= 1)
            {
                var prefix = node.Children.Count > 0
                    ? commonPrefix
                    : "Root";
                
                var expectedPayload = node.Context?.ToCSharpType(_context) ?? string.Empty;
                
                builder.AppendLine($"{indent}/// <summary>");
                builder.AppendLine($"{indent}/// The \"{node.Prefix}\" menu.");
                if (!string.IsNullOrEmpty(expectedPayload) && expectedPayload != CSharpType.Object.Value)
                {
                    builder.AppendLine($"{indent}///");
                    builder.AppendLine($"{indent}/// Expected webhook payload: <see cref=\"{expectedPayload}\">.");
                }
                builder.AppendLine($"{indent}/// </summary>");
                builder.AppendLine($"{indent}public static readonly MenuId {prefix} = new MenuId(\"{node.Prefix}\");");
                builder.AppendLine($"{indent}");
            }
            else
            {
                if (!string.IsNullOrEmpty(node.Prefix))
                {
                    builder.AppendLine($"{indent}public static class {commonPrefix}");
                    builder.AppendLine($"{indent}{{");

                    indent.Increment();
                }

                foreach (var nodeChild in node.Children)
                {
                    builder.Append(
                        indent.Wrap(
                            GenerateMenuIds(nodeChild)));
                }

                if (!string.IsNullOrEmpty(node.Prefix))
                {
                    indent.Decrement();

                    builder.AppendLine($"{indent}}}");
                    builder.AppendLine($"{indent}");
                }
            }

            return builder.ToString();
        }

        private Node BuildTree(string prefix, IEnumerable<ApiMenuId> children) =>
            new Node
            {
                Prefix = prefix.TrimEnd('.'),
                Children = children
                    .Where(it => string.IsNullOrEmpty(prefix) || it.MenuId.StartsWith($"{prefix}.") || it.MenuId == prefix)
                    .GroupBy(it => it.MenuId.RemovePrefix($"{prefix}.").SubstringBefore("."))
                    .Select(it => BuildTree(string.IsNullOrEmpty(prefix) ? it.Key : $"{prefix}.{it.Key}", it))
                    .ToList(),
                Context = children.FirstOrDefault(it => it.MenuId == prefix)?.Context
            };

        private class Node
        {
            public string Prefix { get; set; }
            public List<Node> Children { get; set; } = new List<Node>();
            public ApiFieldType.Ref? Context { get; set; }
        }
    }
}