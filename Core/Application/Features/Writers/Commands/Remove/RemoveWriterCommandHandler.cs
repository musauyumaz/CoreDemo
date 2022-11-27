using Application.Repositories.WriterRepository;
using MediatR;

namespace Application.Features.Writers.Commands.Remove
{
    public class RemoveWriterCommandHandler : IRequestHandler<RemoveWriterCommandRequest, RemoveWriterCommandResponse>
    {
        private readonly IWriterWriteRepository _writerWriteRepository;

        public RemoveWriterCommandHandler(IWriterWriteRepository writerWriteRepository)
        {
            _writerWriteRepository = writerWriteRepository;
        }

        public async Task<RemoveWriterCommandResponse> Handle(RemoveWriterCommandRequest request, CancellationToken cancellationToken)
        {
            _writerWriteRepository.Remove(request.Id);
            _writerWriteRepository.Save();
            return new();
        }
    }
}
