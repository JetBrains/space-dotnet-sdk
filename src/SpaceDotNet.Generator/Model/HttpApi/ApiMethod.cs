namespace SpaceDotNet.Generator.Model.HttpApi
{
    public enum ApiMethod {
        HTTP_GET,
        HTTP_POST,
        HTTP_PATCH,
        HTTP_PUT,
        HTTP_DELETE,
        
        REST_CREATE = HTTP_POST,
        REST_QUERY = HTTP_GET,
        REST_GET = HTTP_GET,
        REST_UPDATE = HTTP_PATCH,
        REST_DELETE = HTTP_DELETE
    }
}