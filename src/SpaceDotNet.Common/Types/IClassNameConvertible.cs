using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public interface IClassNameConvertible
    {
        string? ClassName { get; set; }
    }
}