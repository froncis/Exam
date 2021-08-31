using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.CalculatorValue
{
    public class GetCalculatorDetailQuery : IRequest<List<CalculatorValueViewModel>>
    {
        public int RateValueId { get; set; }
    }
}
