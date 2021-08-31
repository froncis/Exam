using Exam.Application.Common.Interfaces;
using Exam.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.UnitTests.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<ICalculatorValuesRepository> GetCalculatedValues()
        {

            var values = new List<CalculatorValues>
            {
                new CalculatorValues
                {
                    PresentValue = 1000,
                    FutureValue = 1100,
                    //MaturityYear = 4,
                    LowerBoundInterestRate = 0.1F,
                    //UpperBoundInterestRate = 0.5F,
                    //IncrementalRate = 0.2F
                },
                new CalculatorValues
                {
                    PresentValue = 1100,
                    FutureValue = 1430,
                    //MaturityYear = 4,
                    LowerBoundInterestRate = 0.3F,
                    //UpperBoundInterestRate = 0.5F,
                    //IncrementalRate = 0.2F
                },
                new CalculatorValues
                {
                     PresentValue = 1430,
                    FutureValue = 2145,
                    //MaturityYear = 4,
                    LowerBoundInterestRate = 0.5F,
                    //UpperBoundInterestRate = 0.5F,
                    //IncrementalRate = 0.2F
                },
                new CalculatorValues
                {
                    PresentValue = 2145,
                    FutureValue = 3217.5M,
                    //MaturityYear = 4,
                    LowerBoundInterestRate = 0.5F,
                    //UpperBoundInterestRate = 0.5F,
                    //IncrementalRate = 0.2F
                },
            };

            var mockCalculatedValues = new Mock<ICalculatorValuesRepository>();
            mockCalculatedValues.Setup(repo => repo.ListAllAsync()).ReturnsAsync(values);

            mockCalculatedValues.Setup(repo => repo.AddAsync(It.IsAny<CalculatorValues>()))
                .ReturnsAsync((CalculatorValues calculatedValue) =>
                {
                    values.Add(calculatedValue);
                    return calculatedValue;
                });

            return mockCalculatedValues;
        }

        public static Mock<ICalculatorValuesRepository> AddCalculatedValues()
        {

            var values = new List<CalculatorValues>
            {
                new CalculatorValues
                {
                    PresentValue = 1000,
                    FutureValue = 1100,
                    //MaturityYear = 4,
                    LowerBoundInterestRate = 0.1F,
                    //UpperBoundInterestRate = 0.5F,
                    //IncrementalRate = 0.2F
                },
                new CalculatorValues
                {
                    PresentValue = 1100,
                    FutureValue = 1430,
                    //MaturityYear = 4,
                    LowerBoundInterestRate = 0.3F,
                    //UpperBoundInterestRate = 0.5F,
                    //IncrementalRate = 0.2F
                },
                new CalculatorValues
                {
                     PresentValue = 1430,
                    FutureValue = 2145,
                    //MaturityYear = 4,
                    LowerBoundInterestRate = 0.5F,
                    //UpperBoundInterestRate = 0.5F,
                    //IncrementalRate = 0.2F
                },
                new CalculatorValues
                {
                    PresentValue = 2145,
                    FutureValue = 3217.5M,
                    //MaturityYear = 4,
                    LowerBoundInterestRate = 0.5F,
                    //UpperBoundInterestRate = 0.5F,
                    //IncrementalRate = 0.2F
                },
            };

            var mockCalculatedValues = new Mock<ICalculatorValuesRepository>();
            mockCalculatedValues.Setup(repo => repo.ListAllAsync()).ReturnsAsync(values);

            mockCalculatedValues.Setup(repo => repo.AddAsync(It.IsAny<CalculatorValues>()))
                .ReturnsAsync((CalculatorValues calculatedValue) =>
                {
                    values.Add(calculatedValue);
                    return calculatedValue;
                });

            return mockCalculatedValues;
        }
    }
}
