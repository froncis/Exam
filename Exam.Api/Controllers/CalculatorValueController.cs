using Exam.Application.Services.CalculatorValue;
using Exam.Application.Services.CalculatorValue.Commands.CreateListCalculatorValue;
using Exam.Application.Services.RateValue.Queries.GetRateValueList;
using Exam.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CalculatorValueController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CalculatorValueController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize]
        [HttpGet("all", Name ="GetAllCalculatedValues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<RateValueListViewModel>>> GetAllCalculatedValues()
        {
            var result = await _mediator.Send(new GetCalculatorValueListQuery());
            return Ok(result);
        }

        //[Authorize]
        [HttpGet("{rateId}", Name ="GetCalculatedValueByRateId")]
        public async Task<ActionResult<CalculatorValueViewModel>> GetCalculatedValueById(int rateId)
        {
            var result = new GetCalculatorDetailQuery() { RateValueId = rateId };
            return Ok(await _mediator.Send(result));
        }

        //[Authorize]
        [HttpPost(Name ="CreateCalculatedValues")]
        public async Task<ActionResult<CalculatedInterestValueCommandResponse>> Create([FromBody] List<CalculatedInterestValueCommand> createCalculatorValueCommand)
        {
            foreach (var request in createCalculatorValueCommand)
            {
               await _mediator.Send(request);
            }

            return Ok();
        }
    }
}
