using Application.Repositories.CommentRepository;
using MediatR;

namespace Application.Features.Comments.Queries.GetAll
{
    public class GetAllCommentQueryHandler : IRequestHandler<GetAllCommentQueryRequest, GetAllCommentQueryResponse>
    {
        private readonly ICommentReadRepository _commentReadRepository;

        public GetAllCommentQueryHandler(ICommentReadRepository commentReadRepository)
        {
            _commentReadRepository = commentReadRepository;
        }

        public async Task<GetAllCommentQueryResponse> Handle(GetAllCommentQueryRequest request, CancellationToken cancellationToken)
        {
            var comments = _commentReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).ToList();
            return new() { Comments = comments };
        }
    }
}
