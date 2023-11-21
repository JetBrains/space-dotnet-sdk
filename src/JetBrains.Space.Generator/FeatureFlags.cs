// ReSharper disable RedundantLogicalConditionalExpressionOperand

namespace JetBrains.Space.Generator;

internal static class FeatureFlags
{
    /// <summary>
    /// Hide request objects?
    /// 
    /// When true, will expose request object properties as API request parameters, making the API surface nicer to use.
    /// When false, will generate API method calls that require request objects to be passed.
    ///
    /// Recommended value: true
    /// </summary>
    public static readonly bool DoNotExposeRequestObjects = true;

    /// <summary>
    /// Generate enumerable method for SyncBatch API endpoints?
    /// 
    /// When true, will generate enumerable method for SyncBatch API endpoints.
    /// When false, will not generate enumerable method for SyncBatch API endpoints.
    /// </summary>
    public static readonly bool GenerateEnumerableMethodForSyncBatchApiEndpoint = false;

    /// <summary>
    /// Generate experimental annotations?
    ///
    /// When true, will generate experimental annotations.
    /// When false, will not generate experimental annotations.
    /// </summary>
    public static readonly bool GenerateExperimentalAnnotations = false;
}