using MediatR;

namespace Application.Features.Writers.Queries.GetById
{
    public class GetByIdWriterQueryRequest : IRequest<GetByIdWriterQueryResponse>
    {
        public int Id { get; set; }
    }
}
