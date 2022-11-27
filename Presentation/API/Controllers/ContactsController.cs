using Application.Features.Contacts.Commands.Create;
using Application.Features.Contacts.Commands.Remove;
using Application.Features.Contacts.Commands.Update;
using Application.Features.Contacts.Queries.GetAll;
using Application.Features.Contacts.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateContactCommandRequest createContactCommandRequest)
        {
            CreateContactCommandResponse response = await _mediator.Send(createContactCommandRequest);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllContactQueryRequest getAllContactQueryRequest)
        {
            GetAllContactQueryResponse response = await _mediator.Send(getAllContactQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdContactQueryRequest getByIdContactQueryRequest)
        {
            GetByIdContactQueryResponse response = await _mediator.Send(getByIdContactQueryRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateContactCommandRequest updateContactCommandRequest)
        {
            UpdateContactCommandResponse response = await _mediator.Send(updateContactCommandRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveContactCommandRequest removeContactCommandRequest)
        {
            RemoveContactCommandResponse response = await _mediator.Send(removeContactCommandRequest);
            return Ok(response);
        }
    }
}
