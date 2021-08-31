using AutoMapper;
using Exam.Application.Common.Interfaces;
using Exam.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Application.Services.RateValue.Command.DeleteRateValue
{
    public class DeleteRateValueCommandHandler : IRequestHandler<DeleteRateValueCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<RateValues> _rateValuesRepository;

        public DeleteRateValueCommandHandler(IMapper mapper, IAsyncRepository<RateValues> rateValuesRepository)
        {
            _mapper = mapper;
            _rateValuesRepository = rateValuesRepository;
        }

        public async Task<Unit> Handle(DeleteRateValueCommand request, CancellationToken cancellationToken)
        {
            var rateValue = await _rateValuesRepository.GetByIdAsync(request.Id);
            await _rateValuesRepository.DeleteAsync(rateValue);
            return Unit.Value;
        }
    }
}
