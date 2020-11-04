using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using API;
using API.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace API.IntegrationTests
{
    internal class IntegrationTest
    {
        public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
        {
            private readonly WebApplicationFactory<Startup> factory;

            public IntegrationTests(WebApplicationFactory<Startup> factory)
            {
                this.factory = factory;
            }

            [Fact]
            public async Task MainPageLoadsSuccessfully()
            {
                var responseMessage = await factory.CreateClient().GetAsync("/");

                responseMessage.EnsureSuccessStatusCode();
            }
            [Fact]
            public async Task DoublingWorks()
            {
                var responseMessage = await factory.CreateClient().GetAsync("/doubling");

                responseMessage.EnsureSuccessStatusCode();
            }
            [Fact]
            public async Task Doubling_ReturnsResult()
            {
                var expected = 10;

                var response = await factory.CreateClient().GetAsync("values/doubling?input=5");
                var responseContent = await response.Content.ReadAsStringAsync();

                var content = JsonConvert.DeserializeObject<Dictionary<string, int>>(responseContent);
                content.TryGetValue("result", out int actual);

                response.EnsureSuccessStatusCode();
                Assert.Equal(expected, actual);
            }
            [Fact]
            public async Task DoUntil_Multiply_ReturnsResult()
            {
                //Arrange
                var expected = 120;
                var dataToSend = JsonConvert.SerializeObject(new Number { Until = 5 });
                var httpContent = new StringContent(dataToSend, Encoding.UTF8, "application/json");

                //Act
                var response = await factory.CreateClient().PostAsync("api/values/dountil/multiply", httpContent);
                var responseContent = await response.Content.ReadAsStringAsync();
                var content = JsonConvert.DeserializeObject<Dictionary<string, int>>(responseContent);
                content.TryGetValue("result", out int actual);

                //Assert
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
                Assert.Equal(expected, actual);
            }
        }
    }
}