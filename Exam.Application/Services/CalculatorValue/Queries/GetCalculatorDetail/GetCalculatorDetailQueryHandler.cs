using AutoMapper;
using Exam.Application.Common.Interfaces;
using Exam.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Application.Services.CalculatorValue
{
    public class GetCalculatorDetailQueryHandler : IRequestHandler<GetCalculatorDetailQuery, List<CalculatorValueViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly ICalculatorValuesRepository _calculatorRepository;
        public GetCalculatorDetailQueryHandler(IMapper mapper, ICalculatorValuesRepository calculatorRepository)
        {
            _mapper = mapper;
            _calculatorRepository = calculatorRepository;
        }
        public async Task<List<CalculatorValueViewModel>> Handle(GetCalculatorDetailQuery request, CancellationToken cancellationToken)
        {
            var calculatorValue = await _calculatorRepository.GetAllCalculatedValuesByRateId(request.RateValueId);
            var calculatorDetail = _mapper.Map<List<CalculatorValueViewModel>>(calculatorValue);

            return calculatorDetail;
        }
    }
}
