using MediatR;

namespace Application.Features.Comments.Commands.Remove
{
    public class RemoveCommentCommandRequest : IRequest<RemoveCommentCommandResponse>
    {
        public int Id { get; set; }
    }
}
