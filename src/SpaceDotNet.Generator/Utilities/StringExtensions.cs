namespace SpaceDotNet.Generator.Utilities
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
    }
}