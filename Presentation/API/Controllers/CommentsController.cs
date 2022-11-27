using Application.Features.Comments.Commands.Create;
using Application.Features.Comments.Commands.Remove;
using Application.Features.Comments.Commands.Update;
using Application.Features.Comments.Queries.GetAll;
using Application.Features.Comments.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateCommentCommandRequest createCommentCommandRequest)
        {
            CreateCommentCommandResponse response = await _mediator.Send(createCommentCommandRequest);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCommentQueryRequest getAllCommentQueryRequest)
        {
            GetAllCommentQueryResponse response = await _mediator.Send(getAllCommentQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCommentQueryRequest getByIdCommentQueryRequest)
        {
            GetByIdCommentQueryResponse response = await _mediator.Send(getByIdCommentQueryRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCommentCommandRequest updateCommentCommandRequest)
        {
            UpdateCommentCommandResponse response = await _mediator.Send(updateCommentCommandRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveCommentCommandRequest removeCommentCommandRequest)
        {
            RemoveCommentCommandResponse response = await _mediator.Send(removeCommentCommandRequest);
            return Ok(response);
        }
    }
}
