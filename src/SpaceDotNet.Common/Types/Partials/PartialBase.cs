using System;
using System.Diagnostics.CodeAnalysis;

namespace SpaceDotNet.Common.Types
{
    /// <summary>
    /// Base class for <see cref="Partial{T}"/>. Should not be used directly.
    /// </summary>
    public class PartialBase
    {
        [SuppressMessage("ReSharper", "UnusedParameter.Local", Justification = "Reserved for future use.")]
        internal PartialBase(Type ownType, PartialBase? parent = null)
        {
        }
    }
}