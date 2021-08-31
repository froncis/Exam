using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.RateValue.Command.CreateRateValue
{
    public class CreateRateValueCommand : IRequest<CreateRateValueCommandResponse>
    {
        public int MaturityYear { get; set; }
        public float UpperBoundInterestRate { get; set; }
        public float IncrementalRate { get; set; }

        public override string ToString()
        {
            return $"Rate Value : Maturity Year - {MaturityYear}; UpperBound Interest Rate - {UpperBoundInterestRate}; Incremental Rate - {IncrementalRate}";
        }
    }
}
