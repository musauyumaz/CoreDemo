using Domain.Entities;

namespace Application.Features.Comments.Queries.GetAll
{
    public class GetAllCommentQueryResponse
    {
        public IList<Comment> Comments { get; set; }
    }
}
