using Application.Features.Blogs.Commands.Create;
using Application.Features.Blogs.Commands.Remove;
using Application.Features.Blogs.Commands.Update;
using Application.Features.Blogs.Queries.GetAll;
using Application.Features.Blogs.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateBlogCommandRequest createBlogCommandRequest)
        {
            CreateBlogCommandResponse response = await _mediator.Send(createBlogCommandRequest);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllBlogQueryRequest getAllBlogQueryRequest)
        {
            GetAllBlogQueryResponse response = await _mediator.Send(getAllBlogQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBlogQueryRequest getByIdBlogQueryRequest)
        {
            GetByIdBlogQueryResponse response = await _mediator.Send(getByIdBlogQueryRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateBlogCommandRequest updateBlogCommandRequest)
        {
            UpdateBlogCommandResponse response = await _mediator.Send(updateBlogCommandRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveBlogCommandRequest removeBlogCommandRequest)
        {
            RemoveBlogCommandResponse response = await _mediator.Send(removeBlogCommandRequest);
            return Ok(response);
        }
    }
}
