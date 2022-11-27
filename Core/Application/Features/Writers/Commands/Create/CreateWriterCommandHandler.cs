using Application.Repositories.WriterRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Writers.Commands.Create
{
    public class CreateWriterCommandHandler : IRequestHandler<CreateWriterCommandRequest, CreateWriterCommandResponse>
    {
        private IWriterWriteRepository _writerWriteRepository;
        private IMapper _mapper;

        public CreateWriterCommandHandler(IWriterWriteRepository writerWriteRepository, IMapper mapper)
        {
            _writerWriteRepository = writerWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateWriterCommandResponse> Handle(CreateWriterCommandRequest request, CancellationToken cancellationToken)
        {
            Writer mappedWriter = _mapper.Map<Writer>(request);
            _writerWriteRepository.Add(mappedWriter);
            _writerWriteRepository.Save();
            return new();
        }
    }
}
