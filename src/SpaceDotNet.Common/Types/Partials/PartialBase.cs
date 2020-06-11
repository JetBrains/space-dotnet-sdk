using System;

namespace SpaceDotNet.Common.Types
{
    /// <summary>
    /// Base class for <see cref="Partial{T}"/>. Should not be used directly.
    /// </summary>
    public class PartialBase
    {
        private readonly Type _ownType;
        private readonly PartialBase? _parent;

        internal PartialBase(Type ownType, PartialBase? parent = null)
        {
            _ownType = ownType;
            _parent = parent;
        }
    }
}