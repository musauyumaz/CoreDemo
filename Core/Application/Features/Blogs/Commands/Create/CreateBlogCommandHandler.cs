using Application.Repositories.BlogRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Blogs.Commands.Create
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommandRequest, CreateBlogCommandResponse>
    {
        private readonly IBlogWriteRepository _blogWriteRepository;
        private readonly IMapper _mapper;

        public CreateBlogCommandHandler(IBlogWriteRepository blogWriteRepository, IMapper mapper)
        {
            _blogWriteRepository = blogWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateBlogCommandResponse> Handle(CreateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedBlog = _mapper.Map<Blog>(request);
            _blogWriteRepository.Add(mappedBlog);
            _blogWriteRepository.Save();
            return new();
        }
    }
}
