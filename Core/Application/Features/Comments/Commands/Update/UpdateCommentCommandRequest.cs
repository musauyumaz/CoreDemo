using MediatR;

namespace Application.Features.Comments.Commands.Update
{
    public class UpdateCommentCommandRequest : IRequest<UpdateCommentCommandResponse>
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
