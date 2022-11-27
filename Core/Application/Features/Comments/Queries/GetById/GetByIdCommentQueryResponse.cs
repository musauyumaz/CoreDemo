namespace Application.Features.Comments.Queries.GetById
{
    public class GetByIdCommentQueryResponse
    {
        public int BlogId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
