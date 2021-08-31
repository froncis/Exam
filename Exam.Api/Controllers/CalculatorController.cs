using Exam.Application.Services.Calculator;
using Exam.Application.Services.CalculatorValue.Commands.CreateListCalculatorValue;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Exam.Api.Controllers
{
    [Route("api/[Controller]")]
    public class CalculatorController : Controller
    {
        private readonly IMediator _mediator;

        public CalculatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "Calculator")]
        public List<CalculatorDto> CalculateInterestRate(CalculatorDto calculatorDto)
        {
            var result = InterestRateCalculator.GetYearlyValueByClass(calculatorDto);
            return result;
        }
    }
}
