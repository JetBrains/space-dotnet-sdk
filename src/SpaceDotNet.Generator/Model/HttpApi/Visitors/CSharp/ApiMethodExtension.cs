using System;

namespace SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp
{
    public static class ApiMethodExtension
    {
        public static string ToHttpMethod(this ApiMethod current) =>
            current switch
            {
                ApiMethod.HTTP_GET => "GET",
                ApiMethod.HTTP_POST => "POST",
                ApiMethod.HTTP_PATCH => "PATCH",
                ApiMethod.HTTP_PUT => "PUT",
                ApiMethod.HTTP_DELETE => "DELETE",
                _ => throw new ArgumentOutOfRangeException(nameof(current), current, null)
            };
    }
}