using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Generator
{
    internal static class FeatureFlags
    {
        /// <summary>
        /// Generate backing fields for DTOs?
        /// 
        /// When true, will make use of <see cref="PropertyValue{T}"/> and keep track of partial paths/not requested fields.
        /// When false, will generate auto-properties.
        ///
        /// Recommended value: true
        /// </summary>
        public const bool GenerateBackingFieldsForDtoProperties = true;
        
        /// <summary>
        /// Hide request objects?
        /// 
        /// When true, will expose request object properties as API request parameters, making the API surface nicer to use.
        /// When false, will generate API method calls that require request objects to be passed.
        ///
        /// Recommended value: true
        /// </summary>
        public const bool DoNotExposeRequestObjects = true;
        
        /// <summary>
        /// Generate constructor for DTOs?
        /// 
        /// When true, will generate a default constructor + property constructor for DTOs.
        /// When false, will not generate constructors.
        /// 
        /// Recommended value: true
        /// </summary>
        public const bool GenerateDtoConstructor = true;
        
        /// <summary>
        /// Generate factory methods for DTO inheritors?
        /// 
        /// When true, will generate factory methods for DTO inheritors.
        /// When false, will not generate methods.
        ///
        /// Recommended value: true
        /// </summary>
        public const bool GenerateInheritorFactoryMethods = true;
    }
}