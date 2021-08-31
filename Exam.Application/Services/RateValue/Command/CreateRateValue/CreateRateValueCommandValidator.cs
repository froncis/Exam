using Exam.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.RateValue.Command.CreateRateValue
{
    public class CreateRateValueCommandValidator : AbstractValidator<CreateRateValueCommand>
    {
        private readonly IRateValueRepository _rateValueRepository;

        public CreateRateValueCommandValidator(IRateValueRepository rateValueRepository)
        {
            _rateValueRepository = rateValueRepository;

            RuleFor(p => p.MaturityYear)
                .NotEmpty().WithMessage("{MaturityYear} is required")
                .NotNull()
                .GreaterThan(0)
                .NotEqual(0);

            RuleFor(p => p.IncrementalRate)
                .NotEmpty().WithMessage("{IncrementalRate} is required")
                .NotNull()
                .GreaterThan(0)
                .NotEqual(0);

            RuleFor(p => p.UpperBoundInterestRate)
                .NotEmpty().WithMessage("{UpperBoundInterestRate} is required")
                .NotNull()
                .GreaterThan(0)
                .NotEqual(0);
        }
    }
}
