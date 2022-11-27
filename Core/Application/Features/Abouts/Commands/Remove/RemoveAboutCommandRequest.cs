using MediatR;

namespace Application.Features.Abouts.Commands.Remove
{
    public class RemoveAboutCommandRequest : IRequest<RemoveAboutCommandResponse>
    {
        public int Id { get; set; }
    }
}
