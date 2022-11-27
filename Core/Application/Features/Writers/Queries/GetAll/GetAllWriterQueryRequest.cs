using MediatR;

namespace Application.Features.Writers.Queries.GetAll
{
    public class GetAllWriterQueryRequest : IRequest<GetAllWriterQueryResponse>
    {
        public int Size { get; set; }
        public int Page { get; set; }
    }
}
