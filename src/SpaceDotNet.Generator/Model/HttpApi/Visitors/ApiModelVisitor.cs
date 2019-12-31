namespace SpaceDotNet.Generator.Model.HttpApi.Visitors
{
    public class ApiModelVisitor
    {
        public virtual void Visit(ApiModel apiModel)
        {
            foreach (var apiEnum in apiModel.Enums)
            {
                Visit(apiEnum);
            }
            
            foreach (var apiDto in apiModel.Dto)
            {
                Visit(apiDto);
            }
            
            foreach (var apiResource in apiModel.Resources)
            {
                Visit(apiResource);
            }
        }
        
        public virtual void Visit(ApiEnum apiEnum)
        {
        }

        public virtual void Visit(ApiDto apiDto)
        {
            foreach (var apiDtoField in apiDto.Fields)
            {
                Visit(apiDtoField);
            }
        }

        public virtual void Visit(ApiDtoField apiDtoField)
        {
            Visit(apiDtoField.Field);
        }
        
        public virtual void Visit(ApiField apiField)
        {
            Visit(apiField.Type);
        }

        public virtual void Visit(ApiFieldType apiFieldType)
        {
        }
        
        public virtual void Visit(ApiResource apiResource)
        {
            foreach (var apiEndpoint in apiResource.Endpoints)
            {
                Visit(apiResource, apiEndpoint);
            }
            
            foreach (var apiNestedResource in apiResource.NestedResources)
            {
                Visit(apiNestedResource);
            }
        }

        public virtual void Visit(ApiResource apiResource, ApiEndpoint apiEndpoint)
        {
        }
    }
}