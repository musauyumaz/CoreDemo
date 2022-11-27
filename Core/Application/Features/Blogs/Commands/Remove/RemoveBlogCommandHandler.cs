using Application.Repositories.BlogRepository;
using MediatR;

namespace Application.Features.Blogs.Commands.Remove
{
    public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommandRequest, RemoveBlogCommandResponse>
    {
        private readonly IBlogWriteRepository _blogWriteRepository;

        public RemoveBlogCommandHandler(IBlogWriteRepository blogWriteRepository)
        {
            _blogWriteRepository = blogWriteRepository;
        }

        public async Task<RemoveBlogCommandResponse> Handle(RemoveBlogCommandRequest request, CancellationToken cancellationToken)
        {
            _blogWriteRepository.Remove(request.Id);
            _blogWriteRepository.Save();
            return new();
        }
    }
}
