using AutoMapper;
using Exam.Application.Common.Interfaces;
using Exam.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Application.Services.RateValue.Queries.GetRateValueDetails
{
    public class GetRateValueDetailsQueryHandler : IRequestHandler<GetRateValueDetailsQuery, RateValueDetailsViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<RateValues> _rateValueRepositoty;
        private readonly ICalculatorValuesRepository _calculatedValueRepository;

        public GetRateValueDetailsQueryHandler(IMapper mapper , IAsyncRepository<RateValues> rateValueRepositoty, ICalculatorValuesRepository calculatedValueRepository)
        {
            _mapper = mapper;
            _rateValueRepositoty = rateValueRepositoty;
            _calculatedValueRepository = calculatedValueRepository;
        }

        public async Task<RateValueDetailsViewModel> Handle(GetRateValueDetailsQuery request, CancellationToken cancellationToken)
        {
            var rateValueResult = await _rateValueRepositoty.GetByIdAsync(request.Id);
            var mappedValues = _mapper.Map<RateValueDetailsViewModel>(rateValueResult);

            var calculatedValues = await _calculatedValueRepository.GetAllCalculatedValuesByRateId(rateValueResult.Id);

            mappedValues.CalculatedValuesDtos = _mapper.Map<List<CalculatedValuesDto>>(calculatedValues);

            return mappedValues;
        }
    }
}
