using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace API.IntegrationTest
{
    public class IntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;

        public IntegrationTest(WebApplicationFactory<Startup> factory)
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
        public async Task Doubling_ReturnsResult()
        {
            var expected = 10;

            var response = await factory.CreateClient().GetAsync("doubling?input=5");
            var data = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Dictionary<string, int>>(data);
            result.TryGetValue("result", out int actual);

            response.EnsureSuccessStatusCode();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task DoUntil_Multiply_ReturnsResult()
        {
            // Arrange
            var expected = 120;
            var toSend = JsonConvert.SerializeObject(new Number { Until = 5 });
            var httpContent = new StringContent(toSend, Encoding.UTF8, "application/json");

            // Act
            var response = await factory.CreateClient().PostAsync("dountil/factor", httpContent);
            var data = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Dictionary<string, int>>(data);
            result.TryGetValue("result", out int actual);

            // Assert
            //response.EnsureSuccessStatusCode(); =====> It is the same as code on line below.
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Eleanor", "dishwasher", "Oh, hi there Eleanor, my dear dishwasher!")]
        public async Task Greeter_Input_Success(string name, string title, string expected)
        {
            var responce = await factory.CreateClient().GetAsync($"/greeter?name={name}&title={title}");
            var json = responce.Content.ReadAsStringAsync().Result;
            var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            dict.TryGetValue("welcome_message", out string actual);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Zebr", "Zebra")]
        public async Task AppendA_ReturnResult(string appendable, string expected)
        {
            var response = await factory.CreateClient().GetAsync($"/appenda/{appendable}");
            var data = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            result.TryGetValue("result", out string actual);
            var json = response.Content.ReadAsStringAsync().Result;
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("multiply", new int[] { 1, 2, 5, 10 }, 100)]
        public async Task Arrays_ReturnResult(string what, int[] input, int expected)
        {
            var toSend = JsonConvert.SerializeObject(new Arrays { What = what, numbers = input });
            var httpContent = new StringContent(toSend, Encoding.UTF8, "application/json");
            var responce = await factory.CreateClient().PostAsync("/arrays", httpContent);
            var json = responce.Content.ReadAsStringAsync().Result;
            var dict = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
            dict.TryGetValue("result", out int actual);
            Assert.Equal(expected, actual);
        }
    }
}