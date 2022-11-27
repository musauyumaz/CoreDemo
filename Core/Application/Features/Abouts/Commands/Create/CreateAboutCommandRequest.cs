using MediatR;

namespace Application.Features.Abouts.Commands.Create
{
    public class CreateAboutCommandRequest : IRequest<CreateAboutCommandResponse>
    {
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string MapLocation { get; set; }
    }
}
