using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.CalculatorValue.Commands.CreateListCalculatorValue
{
    public class CalculatedInterestValueCommand : IRequest<CalculatedInterestValueCommandResponse>
    {
        public decimal PresentValue { get; set; }
        public decimal FutureValue { get; set; }
        public int Year { get; set; }
        public float LowerBoundInterestRate { get; set; }
    }
}
