using JetBrains.Annotations;

namespace SpaceDotNet.AspNetCore.WebHooks
{
    [PublicAPI]
    public interface IWebHookPayload 
    {
        string? ClassName { get; }
    }
}