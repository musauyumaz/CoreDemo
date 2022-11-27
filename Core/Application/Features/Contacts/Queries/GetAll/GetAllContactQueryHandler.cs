using Application.Repositories.ContactRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Contacts.Queries.GetAll
{
    public class GetAllContactQueryHandler : IRequestHandler<GetAllContactQueryRequest, GetAllContactQueryResponse>
    {
        private readonly IContactReadRepository _contactReadRepository;
        private readonly IMapper _mapper;

        public GetAllContactQueryHandler(IContactReadRepository contactReadRepository, IMapper mapper)
        {
            _contactReadRepository = contactReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllContactQueryResponse> Handle(GetAllContactQueryRequest request, CancellationToken cancellationToken)
        {
            List<Contact> contacts = _contactReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).ToList();
            return new() { Contacts = contacts };
        }
    }
}
