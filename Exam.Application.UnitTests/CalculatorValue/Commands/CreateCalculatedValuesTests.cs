using AutoMapper;
using Exam.Application.Common.Interfaces;
using Exam.Application.Profiles;
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

        //[Fact]
        //public async Task Handle_ValidValues_AddedToCalculatorRepo()
        //{
        //    var handler = new CreateCalculatorValueCommandHandler(_mapper, _mockCalculatorValuesRepository.Object);

        //    await handler.Handle(new CreateCalculatorValueCommand()
        //    {
        //        PresentValue = 2145,
        //        FutureValue = 3217.5M,
        //        LowerBoundInterestRate = 0.5F,
        //    }, CancellationToken.None);

        //    var allCalculatedValues = await _mockCalculatorValuesRepository.Object.ListAllAsync();
        //    allCalculatedValues.Count.ShouldBe(5);
        //}
    }
}
