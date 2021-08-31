using Exam.Application.Services.RateValue.Command.CreateRateValue;
using Exam.Application.Services.RateValue.Command.DeleteRateValue;
using Exam.Application.Services.RateValue.Command.UpdateRateValue;
using Exam.Application.Services.RateValue.Queries.GetRateValueDetails;
using Exam.Application.Services.RateValue.Queries.GetRateValueList;
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
    public class RateValueController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RateValueController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize]
        [HttpGet("all", Name = "GetRateValues")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<RateValueListViewModel>>> GetRateValueWithCalculatedValues()
        {
            GetRateValueListQuery getCategoriesListWithEventsQuery = new GetRateValueListQuery();

            var dtos = await _mediator.Send(getCategoriesListWithEventsQuery);
            return Ok(dtos);
        }

        //[Authorize]
        [HttpGet("{id}", Name = "GetRateValueByIdWithDetails")]
        public async Task<ActionResult<RateValueDetailsViewModel>> GetRateValueById(int id)
        {
            var result = new GetRateValueDetailsQuery() { Id = id };
            return Ok(await _mediator.Send(result));
        }

        //[Authorize]
        [HttpPost(Name = "CreateRateValue")]
        public async Task<ActionResult<CreateRateValueCommandResponse>> Create([FromBody] CreateRateValueCommand createRateValueCommand)
        {
            var response = await _mediator.Send(createRateValueCommand);
            return Ok(response);
        }

        [HttpPut(Name = "UpdateRateValue")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateRateValueCommand updateEventCommand)
        {
            await _mediator.Send(updateEventCommand);
            return NoContent();
        }

        [HttpDelete("{id}",Name ="DeleteRateValue")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var result = new DeleteRateValueCommand() { Id = id };
            await _mediator.Send(result);
            return NoContent();
        }
    }
}
