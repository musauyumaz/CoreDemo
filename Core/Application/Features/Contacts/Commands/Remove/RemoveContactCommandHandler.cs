using Application.Repositories.ContactRepository;
using MediatR;

namespace Application.Features.Contacts.Commands.Remove
{
    public class RemoveContactCommandHandler : IRequestHandler<RemoveContactCommandRequest, RemoveContactCommandResponse>
    {
        private readonly IContactWriteRepository _contactWriteRepository;

        public RemoveContactCommandHandler(IContactWriteRepository contactWriteRepository)
        {
            _contactWriteRepository = contactWriteRepository;
        }

        public async Task<RemoveContactCommandResponse> Handle(RemoveContactCommandRequest request, CancellationToken cancellationToken)
        {
            _contactWriteRepository.Remove(request.Id);
            _contactWriteRepository.Save();
            return new();
        }
    }
}
