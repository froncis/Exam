using Exam.Application.Common.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.CalculatorValue.Commands.CreateListCalculatorValue
{
    public class CalculatedInterestValueCommandResponse : BaseResponse
    {
        public CalculatedInterestValueCommandResponse() : base()
        {

        }

        public CalculatedInterestValueCommand calculatedInterestValueCommand = new CalculatedInterestValueCommand();
    }
}
