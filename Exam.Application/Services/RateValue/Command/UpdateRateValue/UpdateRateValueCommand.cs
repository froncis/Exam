using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.RateValue.Command.UpdateRateValue
{
    public class UpdateRateValueCommand : IRequest
    {
        public int Id { get; set; }
        public int MaturityYear { get; set; }
        public float UpperBoundInterestRate { get; set; }
        public float IncrementalRate { get; set; }
    }
}
