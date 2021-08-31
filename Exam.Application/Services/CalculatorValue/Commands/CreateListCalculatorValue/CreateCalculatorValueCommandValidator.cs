using Exam.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.CalculatorValue.Commands.CreateListCalculatorValue
{
    public class CreateCalculatorValueCommandValidator : AbstractValidator<CalculatedInterestValueCommand>
    {
        private readonly ICalculatorValuesRepository _calculatorValuesRepository;

        public CreateCalculatorValueCommandValidator(ICalculatorValuesRepository calculatorValuesRepository)
        {
            _calculatorValuesRepository = calculatorValuesRepository;

            RuleFor(p => p.PresentValue)
                .NotEmpty().WithMessage("{PresentValue} is required")
                .NotNull()
                .GreaterThan(0)
                .NotEqual(0);

            RuleFor(p => p.FutureValue)
                .NotEmpty().WithMessage("{LowerBoundInterestRate} is required")
                .NotNull()
                .GreaterThan(0)
                .NotEqual(0);

            RuleFor(p => p.Year)
                .NotEmpty().WithMessage("{LowerBoundInterestRate} is required")
                .NotNull()
                .GreaterThan(0)
                .NotEqual(0);

            RuleFor(p => p.LowerBoundInterestRate)
                .NotEmpty().WithMessage("{LowerBoundInterestRate} is required")
                .NotNull()
                .GreaterThan(0)
                .NotEqual(0);
        }
    }
}
