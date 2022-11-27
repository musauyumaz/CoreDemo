using MediatR;

namespace Application.Features.Contacts.Queries.GetById
{
    public class GetByIdContactQueryRequest : IRequest<GetByIdContactQueryResponse>
    {
        public int Id { get; set; }
    }
}
