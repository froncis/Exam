using Exam.Application.Common.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.RateValue.Command.CreateRateValue
{
    public class CreateRateValueCommandResponse : BaseResponse
    {
        public CreateRateValueCommandResponse() : base()
        {
        }

        public CreateRateValueCommand RateValue { get; set; }
    }
}
