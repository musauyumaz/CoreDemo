using MediatR;

namespace Application.Features.Comments.Queries.GetById
{
    public class GetByIdCommentQueryRequest : IRequest<GetByIdCommentQueryResponse>
    {
        public int Id { get; set; }
    }
}
