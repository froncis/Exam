using AutoMapper;
using Exam.Application.Common.Interfaces;
using Exam.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Application.Services.CalculatorValue
{
    public class GetCalculatorListQueryHandler : IRequestHandler<GetCalculatorValueListQuery, List<CalculatorValueViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<CalculatorValues> _calculatorRepository;

        public GetCalculatorListQueryHandler(IMapper mapper, IAsyncRepository<CalculatorValues> calculatorRepository)
        {
            _mapper = mapper;
            _calculatorRepository = calculatorRepository;
        }
        public async Task<List<CalculatorValueViewModel>> Handle(GetCalculatorValueListQuery request, CancellationToken cancellationToken)
        {
            var allValues = (await _calculatorRepository.ListAllAsync()).OrderBy(i => i.DateCreated);
            return _mapper.Map<List<CalculatorValueViewModel>>(allValues);
        }
    }
}
