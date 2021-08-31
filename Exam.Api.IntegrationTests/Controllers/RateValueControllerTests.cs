using Exam.Api.IntegrationTests.Base;
using Exam.Application.Services.RateValue.Queries.GetRateValueDetails;
using Exam.Application.Services.RateValue.Queries.GetRateValueList;
using Newtonsoft.Json;
using System.Collections.Generic;
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
    }
}
