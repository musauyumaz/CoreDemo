using MediatR;

namespace Application.Features.Contacts.Commands.Create
{
    public class CreateContactCommandRequest : IRequest<CreateContactCommandResponse>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
