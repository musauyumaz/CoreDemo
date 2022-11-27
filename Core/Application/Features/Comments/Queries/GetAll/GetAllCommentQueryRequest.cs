using MediatR;

namespace Application.Features.Comments.Queries.GetAll
{
    public class GetAllCommentQueryRequest : IRequest<GetAllCommentQueryResponse>
    {
        public int Size { get; set; }
        public int Page { get; set; }
    }
}
