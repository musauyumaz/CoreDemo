using Application.Repositories.ContactRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.ContactRepository
{
    public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
    {
        public ContactWriteRepository(BlogDemoDbContext context) : base(context)
        {
        }
    }
}
