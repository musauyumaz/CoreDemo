using MediatR;

namespace Application.Features.Comments.Commands.Create
{
    public class CreateCommentCommandRequest : IRequest<CreateCommentCommandResponse>
    {
        public int BlogId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
