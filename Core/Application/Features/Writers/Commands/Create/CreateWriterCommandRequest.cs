using MediatR;

namespace Application.Features.Writers.Commands.Create
{
    public class CreateWriterCommandRequest : IRequest<CreateWriterCommandResponse>
    {
        public string FullName { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
