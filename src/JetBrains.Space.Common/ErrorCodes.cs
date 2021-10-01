namespace JetBrains.Space.Common;

/// <summary>
/// Known error codes in Space.
/// </summary>
internal static class ErrorCodes
{
    public const string ValidationError = "validation-error";
    public const string AuthenticationRequired = "authentication-required";
    public const string PermissionDenied = "permission-denied";
    public const string DuplicatedEntity = "duplicated-entity";
    public const string RequestError = "request-error";
    public const string NotFound = "not-found";
    public const string RateLimited = "rate-limited";
    public const string PayloadTooLarge = "payload-too-large";
    public const string InternalServerError = "internal-server-error";
}