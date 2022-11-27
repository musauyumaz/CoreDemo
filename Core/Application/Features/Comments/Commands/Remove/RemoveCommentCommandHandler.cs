using Application.Repositories.CommentRepository;
using MediatR;

namespace Application.Features.Comments.Commands.Remove
{
    public class RemoveCommentCommandHandler : IRequestHandler<RemoveCommentCommandRequest, RemoveCommentCommandResponse>
    {
        private readonly ICommentWriteRepository _commentWriteRepository;

        public RemoveCommentCommandHandler(ICommentWriteRepository commentWriteRepository)
        {
            _commentWriteRepository = commentWriteRepository;
        }

        public async Task<RemoveCommentCommandResponse> Handle(RemoveCommentCommandRequest request, CancellationToken cancellationToken)
        {
            _commentWriteRepository.Remove(request.Id);
            _commentWriteRepository.Save();
            return new();
        }
    }
}
