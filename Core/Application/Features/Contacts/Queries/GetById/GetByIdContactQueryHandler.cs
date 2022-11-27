using Application.Repositories.ContactRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Contacts.Queries.GetById
{
    public class GetByIdContactQueryHandler : IRequestHandler<GetByIdContactQueryRequest, GetByIdContactQueryResponse>
    {
        private readonly IContactReadRepository _contactReadRepository;
        private readonly IMapper _mapper;

        public GetByIdContactQueryHandler(IContactReadRepository contactReadRepository, IMapper mapper)
        {
            _contactReadRepository = contactReadRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdContactQueryResponse> Handle(GetByIdContactQueryRequest request, CancellationToken cancellationToken)
        {
            Contact contact = _contactReadRepository.GetById(request.Id,false);
            GetByIdContactQueryResponse mappedContact = _mapper.Map<GetByIdContactQueryResponse>(contact);
            return mappedContact;
        }
    }
}
