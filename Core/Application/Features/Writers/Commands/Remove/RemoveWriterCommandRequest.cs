using MediatR;

namespace Application.Features.Writers.Commands.Remove
{
    public class RemoveWriterCommandRequest : IRequest<RemoveWriterCommandResponse>
    {
        public int Id { get; set; }
    }
}
