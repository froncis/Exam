using AutoMapper;
using Exam.Application.Common.Interfaces;
using Exam.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Application.Services.CalculatorValue.Commands.CreateListCalculatorValue
{
    public class CalculatedInterestValueCommandHandler : IRequestHandler<CalculatedInterestValueCommand, CalculatedInterestValueCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICalculatorValuesRepository _calculatorValuesRepository;
        private readonly ILogger<CalculatedInterestValueCommandHandler> _logger;

        public CalculatedInterestValueCommandHandler(ICalculatorValuesRepository calculatorValuesRepository, IMapper mapper)
        {
            _calculatorValuesRepository = calculatorValuesRepository;
            _mapper = mapper;
        }

        public async Task<CalculatedInterestValueCommandResponse> Handle(CalculatedInterestValueCommand request, CancellationToken cancellationToken)
        {
            var response = new CalculatedInterestValueCommandResponse();

            var validator = new CreateCalculatorValueCommandValidator(_calculatorValuesRepository);

            var validatorResult = await validator.ValidateAsync(request);
            if (validatorResult.Errors.Capacity > 0)
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();
                foreach (var error in validatorResult.Errors)
                {
                    response.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (response.Success)
            {
                var calculatedValues = _mapper.Map<CalculatorValues>(request);
                calculatedValues = await _calculatorValuesRepository.AddAsync(calculatedValues);
                response.calculatedInterestValueCommand = _mapper.Map<CalculatedInterestValueCommand>(calculatedValues);
            }
            return response;
        }
    }
}
