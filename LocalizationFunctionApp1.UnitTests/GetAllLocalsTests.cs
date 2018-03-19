using LocalizationFunctionApp1.AzureFunctions;
using Xunit;
using Moq;
using LocalizationFunctionApp1.Models;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LocalizationFunctionApp1.UnitTests
{
    public class GetAllLocalsTests
    {
        [Fact]
        public void Test1()
        {
            //var tracer = new Microsoft.Azure.WebJobs.Host.TraceWriter();
            //var mockLogger = new Mock<Microsoft.Azure.WebJobs.Host.TraceWriter>();

            var mockRequest = new Mock<Microsoft.AspNetCore.Http.HttpRequest>();            
            var mockLogger = new Mock<Microsoft.Extensions.Logging.ILogger>();
            
            var actionResult = GetAllLocals.Run(mockRequest.Object, mockLogger.Object);

            var okObjectResult = actionResult as OkObjectResult;
            Assert.NotNull(okObjectResult);

            var result = okObjectResult.Value as List<Local>;
            Assert.NotNull(result);

            var expected = Local.GenerateList();
            Assert.Equal(expected.Count, result.Count);
            Assert.Equal(expected[0].Id, result[0].Id);
            Assert.Equal(expected[0].Country, result[0].Country);
        }
    }
}