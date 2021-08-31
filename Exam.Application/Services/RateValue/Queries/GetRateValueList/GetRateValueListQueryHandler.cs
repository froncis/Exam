using AutoMapper;
using Exam.Application.Common.Interfaces;
using Exam.Application.Services.RateValue.Queries.GetRateValueDetails;
using Exam.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Application.Services.RateValue.Queries.GetRateValueList
{
    public class GetRateValueListQueryHandler : IRequestHandler<GetRateValueListQuery, List<RateValueListViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<RateValues> _rateValuesRepository;

        public GetRateValueListQueryHandler(IAsyncRepository<RateValues> rateValuesRepository, IMapper mapper)
        {
            _rateValuesRepository = rateValuesRepository;
            _mapper = mapper;
        }

        public async Task<List<RateValueListViewModel>> Handle(GetRateValueListQuery request, CancellationToken cancellationToken)
        {
            var allRateValue = await _rateValuesRepository.ListAllAsync();
            return _mapper.Map<List<RateValueListViewModel>>(allRateValue);
        }
    }
}
