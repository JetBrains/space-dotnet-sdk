using System;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.Extensions;

public static class ApiMethodExtensions
{
    public static string ToHttpMethod(this ApiMethod current) =>
        current switch
        {
            ApiMethod.HTTP_GET => "GET",
            ApiMethod.HTTP_POST => "POST",
            ApiMethod.HTTP_PATCH => "PATCH",
            ApiMethod.HTTP_PUT => "PUT",
            ApiMethod.HTTP_DELETE => "DELETE",
            ApiMethod.REST_QUERY => "GET",
            ApiMethod.REST_GET => "GET",
            ApiMethod.REST_CREATE => "POST",
            ApiMethod.REST_UPDATE => "PATCH",
            ApiMethod.REST_DELETE => "DELETE",
            _ => throw new ArgumentOutOfRangeException(nameof(current), current, null)
        };
}