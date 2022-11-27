using Application.Repositories.AboutRepository;
using AutoMapper;
using MediatR;

namespace Application.Features.Abouts.Queries.GetById
{
    public class GetByIdAboutQueryHandler : IRequestHandler<GetByIdAboutQueryRequest, GetByIdAboutQueryResponse>
    {
        private readonly IAboutReadRepository _aboutReadRepository;
        private readonly IMapper _mapper;

        public GetByIdAboutQueryHandler(IAboutReadRepository aboutReadRepository, IMapper mapper)
        {
            _aboutReadRepository = aboutReadRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdAboutQueryResponse> Handle(GetByIdAboutQueryRequest request, CancellationToken cancellationToken)
        {
            var about = _aboutReadRepository.GetById(request.Id,false);
            var mappedAbout = _mapper.Map<GetByIdAboutQueryResponse>(about);
            return mappedAbout;
        }
    }
}
