using MediatR;

namespace Application.Features.Categories.Commands.Remove
{
    public class RemoveCategoryCommandRequest : IRequest<RemoveCategoryCommandResponse>
    {
        public int Id { get; set; }
    }
}
