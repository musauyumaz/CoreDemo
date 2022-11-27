using MediatR;

namespace Application.Features.Abouts.Queries.GetById
{
    public class GetByIdAboutQueryRequest : IRequest<GetByIdAboutQueryResponse>
    {
        public int Id { get; set; }
    }
}
