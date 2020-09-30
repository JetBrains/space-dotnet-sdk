using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.AspNetCoreServer;
using Amazon.Lambda.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SpaceDotNet.Samples.Lambda
{
    public class LambdaEntryPoint : APIGatewayProxyFunction
    {
        protected override void Init(IHostBuilder builder)
        {
            builder.ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        }

        // LAMBDA: NEEDED FOR TOOLING TO PICK IT UP
        public override Task<APIGatewayProxyResponse> FunctionHandlerAsync(APIGatewayProxyRequest request, ILambdaContext lambdaContext)
        {
            var dummy = true;
            return base.FunctionHandlerAsync(request, lambdaContext);
        }
    }
}