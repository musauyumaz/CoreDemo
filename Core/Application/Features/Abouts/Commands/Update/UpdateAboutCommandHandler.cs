using Application.Repositories.AboutRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Abouts.Commands.Update
{
    public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommandRequest, UpdateAboutCommandResponse>
    {
        private readonly IAboutWriteRepository _aboutWriteRepository;
        private readonly IMapper _mapper;

        public UpdateAboutCommandHandler(IAboutWriteRepository aboutWriteRepository, IMapper mapper)
        {
            _aboutWriteRepository = aboutWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateAboutCommandResponse> Handle(UpdateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedUpdateAbout = _mapper.Map<About>(request);
            _aboutWriteRepository.Update(mappedUpdateAbout);
            _aboutWriteRepository.Save();
            return new();
        }
    }
}
