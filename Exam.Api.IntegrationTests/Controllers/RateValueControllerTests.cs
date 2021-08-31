using Exam.Api.IntegrationTests.Base;
using Exam.Application.Services.RateValue.Command.CreateRateValue;
using Exam.Application.Services.RateValue.Queries.GetRateValueDetails;
using Exam.Application.Services.RateValue.Queries.GetRateValueList;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Exam.Api.IntegrationTests.Controllers
{
    public class RateValueControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public RateValueControllerTests(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ReturnSuccessResult()
        {
            var client = _factory.GetAnonymousClient();

            var response = await client.GetAsync("/api/RateValue/all");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<RateValueListViewModel>>(responseString);

            Assert.IsType<List<RateValueListViewModel>>(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task ReturnSuccessResultById()
        {
            var client = _factory.GetAnonymousClient();

            var response = await client.GetAsync("/api/RateValue/" + 1);

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<RateValueDetailsViewModel>(responseString);

            Assert.IsType<RateValueDetailsViewModel>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task CreateNewRateValue()
        {
            var client = _factory.GetAnonymousClient();

            CreateRateValueCommand command = new CreateRateValueCommand();
            command.IncrementalRate = 10;
            command.MaturityYear = 4;
            command.UpperBoundInterestRate = 50;

            StringContent httpContent = new StringContent(JsonConvert.SerializeObject(command), System.Text.Encoding.UTF8, "application/json");


            var response = await client.PostAsync("/api/RateValue" , httpContent);

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.True(response.IsSuccessStatusCode);
        }
    }
}
