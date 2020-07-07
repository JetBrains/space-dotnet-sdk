using JetBrains.Annotations;

namespace SpaceDotNet.AspNetCore.WebHooks.Types
{
    [PublicAPI]
    public interface IWebHookPayload 
    {
        string? ClassName { get; }
    }
}