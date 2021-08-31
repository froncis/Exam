using AutoMapper;
using Exam.Application.Common.Interfaces;
using Exam.Application.Profiles;
using Exam.Application.Services.CalculatorValue;
using Exam.Application.UnitTests.Mocks;
using Exam.Domain.Entities;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Exam.Application.UnitTests.CalculatorValue.Queries
{
    public class GetCalculatorListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ICalculatorValuesRepository> _mockRepository;

        public GetCalculatorListQueryHandlerTests()
        {
            _mockRepository = RepositoryMocks.GetCalculatedValues();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetAllCalculatedValues()
        {
            var handler = new GetCalculatorListQueryHandler(_mapper, _mockRepository.Object);
            var result = await handler.Handle(new GetCalculatorValueListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<CalculatorValueViewModel>>();

            result.Count.ShouldBe(4);
        }
    }
}
