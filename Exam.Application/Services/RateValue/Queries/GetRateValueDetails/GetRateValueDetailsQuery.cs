using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.RateValue.Queries.GetRateValueDetails
{
    public class GetRateValueDetailsQuery : IRequest<RateValueDetailsViewModel>
    {
        public int Id { get; set; }
    }
}
