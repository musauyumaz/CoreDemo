using Domain.Entities;

namespace Application.Features.Contacts.Queries.GetAll
{
    public class GetAllContactQueryResponse
    {
        public IList<Contact> Contacts { get; set; }
    }
}
