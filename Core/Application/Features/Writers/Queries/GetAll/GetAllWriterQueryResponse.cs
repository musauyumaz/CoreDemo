using Domain.Entities;

namespace Application.Features.Writers.Queries.GetAll
{
    public class GetAllWriterQueryResponse
    {
        public IList<Writer> Writers { get; set; }
    }
}
