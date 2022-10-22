using Application.Repositories.AboutRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.AboutRepository
{
    public class AboutWriteRepository : WriteRepository<About>, IAboutWriteRepository
    {
        public AboutWriteRepository(BlogDemoDbContext context) : base(context)
        {
        }
    }
}
