using Application.Repositories.AboutRepository;
using MediatR;

namespace Application.Features.Abouts.Commands.Remove
{
    public class RemoveAboutCommandHandler : IRequestHandler<RemoveAboutCommandRequest, RemoveAboutCommandResponse>
    {
        private readonly IAboutWriteRepository _aboutWriteRepository;

        public RemoveAboutCommandHandler(IAboutWriteRepository aboutWriteRepository)
        {
            _aboutWriteRepository = aboutWriteRepository;
        }

        public async Task<RemoveAboutCommandResponse> Handle(RemoveAboutCommandRequest request, CancellationToken cancellationToken)
        {
            _aboutWriteRepository.Remove(request.Id);
            _aboutWriteRepository.Save();
            return new();
        }
    }
}
