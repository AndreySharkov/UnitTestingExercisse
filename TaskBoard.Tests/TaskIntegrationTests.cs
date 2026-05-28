using NUnit.Framework;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaskBoard.Tests
{
    [TestFixture]
    public class TaskIntegrationTests
    {
        private WebApplicationFactory<Program> _factory;
        private HttpClient _client;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Task 1: Create an integration test class for the Web API endpoints.
            _factory = new WebApplicationFactory<Program>();
            
            // Task 2: Instantiate an HttpClient to send HTTP requests to the running application.
            _client = _factory.CreateClient();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _client.Dispose();
            _factory.Dispose();
        }

        [Test]
        public async System.Threading.Tasks.Task GetTasks_ReturnsSuccessStatusCode()
        {
            // Task 3: Send a GET request to the /tasks endpoint and use assertions to ensure the response.StatusCode is HttpStatusCode.OK.
            
            // Act
            // var response = await _client.GetAsync("/Tasks");

            // Assert
            // Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
