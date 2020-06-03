using System.Collections.Generic;
using SpaceDotNet.Generator.Model.HttpApi;
using SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp;

namespace SpaceDotNet.Generator.CodeGeneration
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

        private void Build(
            Dictionary<string, List<ApiResource>> targetMap, 
            ApiResource apiResource, 
            string currentPath, 
            int currentDepth)
        {
            currentPath = (currentPath.Length > 0 ? currentPath + "." : currentPath) + apiResource.DisplaySingular.ToSafeIdentifier();

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
            if (currentDepth < MaxDepth)
            {
                foreach (var apiNestedResource in apiResource.NestedResources)
                {
                    Build(targetMap, apiNestedResource, currentPath, currentDepth + 1);
                }
            }
        }
    }
}