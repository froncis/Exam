using AutoMapper;
using Exam.Application.Common.Interfaces;
using Exam.Application.Profiles;
using Exam.Application.Services.CalculatorValue.Commands.CreateListCalculatorValue;
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

namespace Exam.Application.UnitTests.CalculatorValue.Commands
{
    public class CreateCalculatedValuesTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ICalculatorValuesRepository> _mockCalculatorValuesRepository;

        public CreateCalculatedValuesTests()
        {
            _mockCalculatorValuesRepository = RepositoryMocks.AddCalculatedValues();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidValues_AddedToCalculatorRepo()
        {
            var handler = new CalculatedInterestValueCommandHandler(_mockCalculatorValuesRepository.Object, _mapper);

            await handler.Handle(new CalculatedInterestValueCommand()
            {
                PresentValue = 2145,
                FutureValue = 3217.5M,
                LowerBoundInterestRate = 0.5F,
                Year = 1
            }, CancellationToken.None);

            var allCalculatedValues = await _mockCalculatorValuesRepository.Object.ListAllAsync();
            allCalculatedValues.Count.ShouldBe(5);
        }
    }
}
