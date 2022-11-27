using Application.Repositories.ContactRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Contacts.Commands.Update
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommandRequest, UpdateContactCommandResponse>
    {
        private readonly IContactWriteRepository _contactWriteRepository;
        private readonly IMapper _mapper;

        public UpdateContactCommandHandler(IContactWriteRepository contactWriteRepository, IMapper mapper)
        {
            _contactWriteRepository = contactWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateContactCommandResponse> Handle(UpdateContactCommandRequest request, CancellationToken cancellationToken)
        {
            Contact mappedContact = _mapper.Map<Contact>(request);
            _contactWriteRepository.Update(mappedContact);
            _contactWriteRepository.Save();
            return new();
        }
    }
}
