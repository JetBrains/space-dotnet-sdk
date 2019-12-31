using System.Collections.Generic;
using System.Linq;

namespace SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp
{
    public static class ApiResourcePathSegmentExtensions
    {
        public static string ToPath(this IEnumerable<ApiResourcePathSegment> segments) =>
            string.Join("/", segments.Select(it =>
            {
                return it switch
                {
                    ApiResourcePathSegment.Const constSegment => constSegment.Value,
                    ApiResourcePathSegment.PrefixedVar prefixedVarSegment => (prefixedVarSegment.Prefix + ":{" + prefixedVarSegment.Name + "}"),
                    ApiResourcePathSegment.Var varSegment => ("{" + varSegment.Name + "}"),
                    _ => null
                };
            }).Where(it => !string.IsNullOrEmpty(it)));
    }
}