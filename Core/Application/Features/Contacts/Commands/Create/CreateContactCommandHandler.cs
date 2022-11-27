using Application.Repositories.ContactRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Contacts.Commands.Create
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommandRequest, CreateContactCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IContactWriteRepository _contactWriteRepository;

        public CreateContactCommandHandler(IMapper mapper, IContactWriteRepository contactWriteRepository)
        {
            _mapper = mapper;
            _contactWriteRepository = contactWriteRepository;
        }

        public async Task<CreateContactCommandResponse> Handle(CreateContactCommandRequest request, CancellationToken cancellationToken)
        {
            Contact mappedContact = _mapper.Map<Contact>(request);
            _contactWriteRepository.Add(mappedContact);
            _contactWriteRepository.Save();

            return new();
        }
    }
}
