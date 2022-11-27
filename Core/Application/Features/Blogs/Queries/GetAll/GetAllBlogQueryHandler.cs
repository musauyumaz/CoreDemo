using Application.Repositories.BlogRepository;
using AutoMapper;
using MediatR;

namespace Application.Features.Blogs.Queries.GetAll
{
    public class GetAllBlogQueryHandler : IRequestHandler<GetAllBlogQueryRequest, GetAllBlogQueryResponse>
    {
        private readonly IBlogReadRepository _blogReadRepository;
        private readonly IMapper _mapper;

        public GetAllBlogQueryHandler(IBlogReadRepository blogReadRepository, IMapper mapper)
        {
            _blogReadRepository = blogReadRepository;
            _mapper = mapper;
        }

        public async Task<GetAllBlogQueryResponse> Handle(GetAllBlogQueryRequest request, CancellationToken cancellationToken)
        {
            var blogs = _blogReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).ToList();
            return new() { Blogs = blogs };
        }
    }
}
