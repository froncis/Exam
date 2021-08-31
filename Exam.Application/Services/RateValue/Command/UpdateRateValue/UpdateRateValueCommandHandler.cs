using AutoMapper;
using Exam.Application.Common.Exceptions;
using Exam.Application.Common.Interfaces;
using Exam.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Application.Services.RateValue.Command.UpdateRateValue
{
    public class UpdateRateValueCommandHandler : IRequestHandler<UpdateRateValueCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<RateValues> _rateValueRepository;

        public UpdateRateValueCommandHandler(IMapper mapper, IAsyncRepository<RateValues> rateValueRepository)
        {
            _mapper = mapper;
            _rateValueRepository = rateValueRepository;
        }

        public async Task<Unit> Handle(UpdateRateValueCommand request, CancellationToken cancellationToken)
        {
            var updateValue = await _rateValueRepository.GetByIdAsync(request.Id);

            if (updateValue == null)
            {
                throw new NotFoundException(nameof(CalculatorValues), request.Id);
            }

            var validator = new UpdateRateValueCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if (validatorResult.Errors.Count > 0)
                throw new ValidationException(validatorResult);

            _mapper.Map(request, updateValue, typeof(UpdateRateValueCommand), typeof(RateValues));

            await _rateValueRepository.UpdateAsync(updateValue);

            return Unit.Value;
        }
    }
}
