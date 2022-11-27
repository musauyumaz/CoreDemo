using MediatR;

namespace Application.Features.Abouts.Queries.GetAll
{
    public class GetAllAboutQueryRequest : IRequest<GetAllAboutQueryResponse>
    {
        public int Size { get; set; } = 5;
        public int Page { get; set; } = 0;
    }
}
