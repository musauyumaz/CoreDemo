using Application.Repositories.BlogRepository;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Blogs.Commands.Update
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommandRequest, UpdateBlogCommandResponse>
    {
        private readonly IBlogWriteRepository _blogWriteRepository;
        private readonly IMapper _mapper;

        public UpdateBlogCommandHandler(IBlogWriteRepository blogWriteRepository, IMapper mapper)
        {
            _blogWriteRepository = blogWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateBlogCommandResponse> Handle(UpdateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            Blog mappedBlog = _mapper.Map<Blog>(request);
            _blogWriteRepository.Update(mappedBlog);
            _blogWriteRepository.Save();
            return new();
        }
    }
}
