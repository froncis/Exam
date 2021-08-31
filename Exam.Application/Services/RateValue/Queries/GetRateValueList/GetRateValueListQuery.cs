using Exam.Application.Services.RateValue.Queries.GetRateValueDetails;
using MediatR;
using System.Collections.Generic;

namespace Exam.Application.Services.RateValue.Queries.GetRateValueList
{
    public class GetRateValueListQuery : IRequest<List<RateValueListViewModel>>
    {
    }
}
