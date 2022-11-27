using MediatR;

namespace Application.Features.Contacts.Commands.Update
{
    public class UpdateContactCommandRequest : IRequest<UpdateContactCommandResponse>
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
