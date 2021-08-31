using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Application.Services.RateValue.Command.DeleteRateValue
{
    public class DeleteRateValueCommand : IRequest
    {
        public int Id { get; set; }
    }
}
