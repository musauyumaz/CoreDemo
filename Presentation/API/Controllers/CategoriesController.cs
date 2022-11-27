using Application.Features.Categories.Commands.Create;
using Application.Features.Categories.Commands.Remove;
using Application.Features.Categories.Commands.Update;
using Application.Features.Categories.Queries.GetAll;
using Application.Features.Categories.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateCategoryCommandRequest createCategoryCommandRequest)
        {
            CreateCategoryCommandResponse response = await _mediator.Send(createCategoryCommandRequest);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]GetAllCategoryQueryRequest getAllCategoryQueryRequest)
        {
            GetAllCategoryQueryResponse response = await _mediator.Send(getAllCategoryQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCategoryQueryRequest getByIdCategoryQueryRequest)
        {
            GetByIdCategoryQueryResponse response = await _mediator.Send(getByIdCategoryQueryRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryCommandRequest updateCategoryCommandRequest)
        {
            UpdateCategoryCommandResponse response = await _mediator.Send(updateCategoryCommandRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveCategoryCommandRequest removeCategoryCommandRequest)
        {
            RemoveCategoryCommandResponse response = await _mediator.Send(removeCategoryCommandRequest);
            return Ok(response);
        }
    }
}
