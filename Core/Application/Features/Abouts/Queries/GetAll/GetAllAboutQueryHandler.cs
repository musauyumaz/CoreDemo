using Application.Features.Abouts.Models;
using Application.Repositories.AboutRepository;
using AutoMapper;
using MediatR;

namespace Application.Features.Abouts.Queries.GetAll
{
    public class GetAllAboutQueryHandler : IRequestHandler<GetAllAboutQueryRequest, GetAllAboutQueryResponse>
    {
        private readonly IAboutReadRepository _aboutReadRepository;
        private readonly IMapper _mapper;

        public GetAllAboutQueryHandler(IAboutReadRepository aboutReadRepository, IMapper mapper)
        {
            _aboutReadRepository = aboutReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllAboutQueryResponse> Handle(GetAllAboutQueryRequest request, CancellationToken cancellationToken)
        {
            var abouts = _aboutReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).ToList();
            AboutListModel mappedAboutListModel = _mapper.Map<AboutListModel>(abouts);
            return new() { Model = mappedAboutListModel };
        }
    }
}
