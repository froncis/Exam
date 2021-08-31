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

namespace Exam.Application.Services.RateValue.Command.CreateRateValue
{
    public class CreateRateValueCommandHandler : IRequestHandler<CreateRateValueCommand, CreateRateValueCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IRateValueRepository _rateValueRepository;
        private readonly ILogger<CreateRateValueCommandHandler> _logger;

        public CreateRateValueCommandHandler(IMapper mapper, IRateValueRepository rateValueRepository)
        {
            _mapper = mapper;
            _rateValueRepository = rateValueRepository;
        }

        public async Task<CreateRateValueCommandResponse> Handle(CreateRateValueCommand request, CancellationToken cancellationToken)
        {
            var createRateValueResponse = new CreateRateValueCommandResponse();

            var validator = new CreateRateValueCommandValidator(_rateValueRepository);

            var validatorResult = await validator.ValidateAsync(request);

            if(validatorResult.Errors.Count > 0)
            {
                createRateValueResponse.Success = false;
                createRateValueResponse.ValidationErrors = new List<string>();
                foreach (var error in validatorResult.Errors)
                {
                    createRateValueResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createRateValueResponse.Success)
            {
                var rateValueResult = _mapper.Map<RateValues>(request);
                rateValueResult = await _rateValueRepository.AddAsync(rateValueResult);
                createRateValueResponse.RateValue = _mapper.Map<CreateRateValueCommand>(rateValueResult);
            }

            return createRateValueResponse;
        }
    }
}
