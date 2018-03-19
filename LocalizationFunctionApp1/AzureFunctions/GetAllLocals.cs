using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using LocalizationFunctionApp1.Models;
using Microsoft.Extensions.Logging;

namespace LocalizationFunctionApp1.AzureFunctions
{
    public static class GetAllLocals
    {
        [FunctionName("GetAllLocals")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function: Get List of all locals.");

            //Mock Data
            var locals = Local.GenerateList();

            return (ActionResult)new OkObjectResult(locals);
        }
    }
}