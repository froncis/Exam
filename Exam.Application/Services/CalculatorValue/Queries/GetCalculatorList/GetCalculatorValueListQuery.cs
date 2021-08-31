using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.CalculatorValue
{
    public class GetCalculatorValueListQuery : IRequest<List<CalculatorValueViewModel>>
    {
    }
}
