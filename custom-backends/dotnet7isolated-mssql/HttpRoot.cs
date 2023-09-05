using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace Dfm.DotNetIsolatedMsSql
{
    public class HttpRoot
    {
        [Function(nameof(HttpRoot))]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "/")] HttpRequestData req)
        {
            var response = req.CreateResponse(HttpStatusCode.TemporaryRedirect);
            response.Headers.Add("Location", "durable-functions-monitor");
            return response;
        }
    }
}
