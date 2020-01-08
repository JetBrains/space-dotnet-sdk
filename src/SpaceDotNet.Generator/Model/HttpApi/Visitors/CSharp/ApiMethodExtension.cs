using System;

namespace SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp
{
    public static class ApiMethodExtension
    {
        public static string ToHttpMethod(this ApiMethod current)
        {
            if (current == ApiMethod.HTTP_GET)
                return "GET";
            if (current == ApiMethod.HTTP_POST)
                return "POST";
            if (current == ApiMethod.HTTP_PATCH)
                return "PATCH";
            if (current == ApiMethod.HTTP_PUT)
                return "PUT";
            if (current == ApiMethod.HTTP_DELETE)
                return "DELETE";
            
            if (current == ApiMethod.REST_QUERY)
                return "GET";         
            if (current == ApiMethod.REST_GET)
                return "GET";
            if (current == ApiMethod.REST_CREATE)
                return "POST";
            if (current == ApiMethod.REST_UPDATE)
                return "PATCH";
            if (current == ApiMethod.REST_DELETE)
                return "DELETE";
            
            throw new ArgumentOutOfRangeException(nameof(current), current, null);
        }
    }
}