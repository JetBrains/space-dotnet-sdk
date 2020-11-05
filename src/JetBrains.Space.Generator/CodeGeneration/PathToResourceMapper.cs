using System.Collections.Generic;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration
{
    public class PathToResourceMapper
    {
        private const int MinDepth = 1;
        private const int MaxDepth = 2;
        
        public Dictionary<string, List<ApiResource>> CreateMapOfPathToResources(ApiResource apiResource)
        {
            var mapOfPathToResources = new Dictionary<string, List<ApiResource>>();

            Build(mapOfPathToResources, apiResource, string.Empty, 0);
            
            return mapOfPathToResources;
        }

        private static void Build(
            Dictionary<string, List<ApiResource>> targetMap, 
            ApiResource apiResource, 
            string currentPath, 
            int currentDepth)
        {
            currentPath = (currentPath.Length > 0 ? currentPath + "/" : currentPath) + apiResource.DisplaySingular;

            // Self
            if (currentDepth >= MinDepth)
            {
                if (!targetMap.TryGetValue(currentPath, out var list))
                {
                    list = new List<ApiResource>();
                    targetMap[currentPath] = list;
                }

                list.Add(apiResource);
            }

            // Nested resources
            var newDepth = currentDepth + 1;
            if (newDepth < MaxDepth)
            {
                foreach (var apiNestedResource in apiResource.NestedResources)
                {
                    Build(targetMap, apiNestedResource, currentPath, newDepth);
                }
            }
        }
    }
}