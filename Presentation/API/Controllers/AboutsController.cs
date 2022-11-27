using Application.Features.Abouts.Commands.Create;
using Application.Features.Abouts.Commands.Remove;
using Application.Features.Abouts.Commands.Update;
using Application.Features.Abouts.Queries.GetAll;
using Application.Features.Abouts.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateAboutCommandRequest createAboutCommandRequest)
        {
            CreateAboutCommandResponse response = await _mediator.Send(createAboutCommandRequest);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllAboutQueryRequest getAllAboutQueryRequest)
        {
            GetAllAboutQueryResponse response = await _mediator.Send(getAllAboutQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdAboutQueryRequest getByIdAboutQueryRequest)
        {
            GetByIdAboutQueryResponse response = await _mediator.Send(getByIdAboutQueryRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateAboutCommandRequest updateAboutCommandRequest)
        {
            UpdateAboutCommandResponse response = await _mediator.Send(updateAboutCommandRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveAboutCommandRequest removeAboutCommandRequest)
        {
            RemoveAboutCommandResponse response = await _mediator.Send(removeAboutCommandRequest);
            return Ok(response);
        }
    }
}
