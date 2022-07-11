using System;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

public static class ApiDocumentationUtilities
{
    public static void RenderCSharpDocumentation(
        ApiDescription? description,
        ApiExperimental? experimental,
        Action<string> renderOutput)
    {
        if (description != null)
        {
            renderOutput(description.ToCSharpDocumentationSummary());
        }
        if (experimental != null)
        {
            renderOutput(experimental.ToCSharpDocumentation());
        }
    }
}