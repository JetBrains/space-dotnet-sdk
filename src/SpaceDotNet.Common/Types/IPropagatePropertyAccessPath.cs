using System.Collections.Generic;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public interface IPropagatePropertyAccessPath
    {
        void SetAccessPath(string path, bool validateHasBeenSet);
    }

    public static class PropagatePropertyAccessPathHelper
    {
        public static void SetAccessPathForValue<T>(string path, bool validateHasBeenSet, T value)
        {
            if (value == null) return;
                  
            if (value is IPropagatePropertyAccessPath valueWithPropertyAccessValidation)
            {
                valueWithPropertyAccessValidation.SetAccessPath(path, validateHasBeenSet);
            }
            if (value is IEnumerable<IPropagatePropertyAccessPath> enumerable)
            {
                foreach (var item in enumerable)
                {
                    item.SetAccessPath(path, validateHasBeenSet);
                }
            }
        }
    }
}