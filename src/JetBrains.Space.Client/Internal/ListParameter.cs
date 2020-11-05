using System;
using System.Collections.Generic;
using System.Text;

namespace JetBrains.Space.Client.Internal
{
    internal static class ListParameter
    {
        public static string? JoinToString<T>(this IList<T>? subject, string parameterName, Func<T, string?> transform)
        {
            if (subject == null)
            {
                return null;
            }

            // Nullify parameter
            if (subject.Count == 0)
            {
                return "null";
            }

            // Repeat parameter
            var builder = new StringBuilder();
            for (var i = 0; i < subject.Count; i++)
            {
                builder.Append(transform(subject[i]));
                if (i != subject.Count - 1)
                {
                    builder.Append($"&{parameterName}=");
                }
            }
            return builder.ToString();
        }
    }
}