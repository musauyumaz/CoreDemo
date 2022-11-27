using Application.Features.Writers.Commands.Create;
using Application.Features.Writers.Commands.Remove;
using Application.Features.Writers.Commands.Update;
using Application.Features.Writers.Queries.GetAll;
using Application.Features.Writers.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WritersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateWriterCommandRequest createWriterCommandRequest)
        {
            CreateWriterCommandResponse response = await _mediator.Send(createWriterCommandRequest);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllWriterQueryRequest getAllWriterQueryRequest)
        {
            GetAllWriterQueryResponse response = await _mediator.Send(getAllWriterQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdWriterQueryRequest getByIdWriterQueryRequest)
        {
            GetByIdWriterQueryResponse response = await _mediator.Send(getByIdWriterQueryRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateWriterCommandRequest updateWriterCommandRequest)
        {
            UpdateWriterCommandResponse response = await _mediator.Send(updateWriterCommandRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveWriterCommandRequest removeWriterCommandRequest)
        {
            RemoveWriterCommandResponse response = await _mediator.Send(removeWriterCommandRequest);
            return Ok(response);
        }
    }
}
