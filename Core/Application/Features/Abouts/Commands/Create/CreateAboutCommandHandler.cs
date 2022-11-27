using Application.Repositories.AboutRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Abouts.Commands.Create
{
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommandRequest, CreateAboutCommandResponse>
    {
        private readonly IAboutWriteRepository _aboutWriteRepository;
        private readonly IMapper _mapper;

        public CreateAboutCommandHandler(IAboutWriteRepository aboutWriteRepository, IMapper mapper)
        {
            _aboutWriteRepository = aboutWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateAboutCommandResponse> Handle(CreateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedAbout = _mapper.Map<About>(request);
            _aboutWriteRepository.Add(mappedAbout);
            _aboutWriteRepository.Save();
            return new();
        }
    }
}
