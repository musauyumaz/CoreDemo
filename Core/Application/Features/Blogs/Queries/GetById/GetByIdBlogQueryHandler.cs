using Application.Repositories.BlogRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Blogs.Queries.GetById
{
    public class GetByIdBlogQueryHandler : IRequestHandler<GetByIdBlogQueryRequest, GetByIdBlogQueryResponse>
    {
        private readonly IBlogReadRepository _blogReadRepository;
        private readonly IMapper _mapper;

        public GetByIdBlogQueryHandler(IBlogReadRepository blogReadRepository, IMapper mapper)
        {
            _blogReadRepository = blogReadRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdBlogQueryResponse> Handle(GetByIdBlogQueryRequest request, CancellationToken cancellationToken)
        {
            Blog blog = _blogReadRepository.GetById(request.Id,false);
            GetByIdBlogQueryResponse mappedBlog = _mapper.Map<GetByIdBlogQueryResponse>(blog);
            return mappedBlog;
        }
    }
}
