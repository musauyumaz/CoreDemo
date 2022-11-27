using MediatR;

namespace Application.Features.Writers.Commands.Update
{
    public class UpdateWriterCommandRequest : IRequest<UpdateWriterCommandResponse>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
