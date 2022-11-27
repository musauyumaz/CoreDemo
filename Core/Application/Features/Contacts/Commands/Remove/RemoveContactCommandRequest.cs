using MediatR;

namespace Application.Features.Contacts.Commands.Remove
{
    public class RemoveContactCommandRequest : IRequest<RemoveContactCommandResponse>
    {
        public int Id { get; set; }
    }
}
