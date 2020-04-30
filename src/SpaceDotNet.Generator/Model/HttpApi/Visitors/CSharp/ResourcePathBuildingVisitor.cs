using System.Collections.Generic;

namespace SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp
{
    public class ResourcePathBuildingVisitor : ApiModelVisitor
    {
        private int _depth;
        private readonly int _minDepth;
        private readonly int _maxDepth;
        private string _resourceBreadcrumbPath = string.Empty;
        
        public readonly Dictionary<string, List<ApiResource>> Paths = new Dictionary<string, List<ApiResource>>();

        public ResourcePathBuildingVisitor(int minDepth, int maxDepth)
        {
            _minDepth = minDepth;
            _maxDepth = maxDepth;
        }
        
        public override void Visit(ApiResource apiResource)
        {
            var originalResourceBreadcrumbPath = _resourceBreadcrumbPath;
            _resourceBreadcrumbPath = (_resourceBreadcrumbPath.Length > 0 ? _resourceBreadcrumbPath + "." : _resourceBreadcrumbPath) +  apiResource.DisplaySingular.ToSafeIdentifier();

            // Self
            if (_depth >= _minDepth)
            {
                if (!Paths.TryGetValue(_resourceBreadcrumbPath, out var list))
                {
                    list = new List<ApiResource>();
                    Paths[_resourceBreadcrumbPath] = list;
                }

                list.Add(apiResource);
            }

            // Nested resources
            _depth++;
            if (_depth < _maxDepth)
            {
                foreach (var apiNestedResource in apiResource.NestedResources)
                {
                    Visit(apiNestedResource);
                }
            }
            _depth--;

            _resourceBreadcrumbPath = originalResourceBreadcrumbPath;
        }
    }
}