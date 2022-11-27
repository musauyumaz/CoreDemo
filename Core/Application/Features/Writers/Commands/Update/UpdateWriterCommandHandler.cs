using Application.Repositories.WriterRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Writers.Commands.Update
{
    public class UpdateWriterCommandHandler : IRequestHandler<UpdateWriterCommandRequest, UpdateWriterCommandResponse>
    {
        private readonly IWriterWriteRepository _writerWriteRepository;
        private readonly IMapper _mapper;

        public UpdateWriterCommandHandler(IWriterWriteRepository writerWriteRepository, IMapper mapper)
        {
            _writerWriteRepository = writerWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateWriterCommandResponse> Handle(UpdateWriterCommandRequest request, CancellationToken cancellationToken)
        {
            Writer mappedWriter = _mapper.Map<Writer>(request);
            _writerWriteRepository.Update(mappedWriter);
            _writerWriteRepository.Save();
            return new();
        }
    }
}
