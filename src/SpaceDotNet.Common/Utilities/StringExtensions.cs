using System;

namespace SpaceDotNet.Common.Utilities
{
    public static class StringExtensions
    {
        public static string? ToUppercaseFirst(this string? subject)
        {
            if (!string.IsNullOrEmpty(subject) && subject.Length == 1)
            {
                return subject.ToUpperInvariant();
            }

            if (!string.IsNullOrEmpty(subject) && subject.Length >= 2)
            {
                return subject.Substring(0, 1).ToUpperInvariant() + subject.Substring(1);
            }

            return subject;
        }
        
        public static string? RemovePrefix(this string? subject, string prefix)
        {
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(prefix) || !subject.StartsWith(prefix))
            {
                return subject;
            }
            
            var prefixLength = prefix.Length;
            return subject.Substring(prefixLength, subject.Length - prefixLength);
        }
        
        public static string? SubstringBefore(this string? subject, string delimiter, StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(delimiter))
            {
                return subject;
            }

            var indexOf = subject.IndexOf(delimiter, comparisonType);
            if (indexOf < 0)
            {
                return subject;
            }

            return subject.Substring(0, indexOf);
        }
    }
}