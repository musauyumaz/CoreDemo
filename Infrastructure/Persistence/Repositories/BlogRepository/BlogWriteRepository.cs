using Application.Repositories.BlogRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.BlogRepository
{
    public class BlogWriteRepository : WriteRepository<Blog>, IBlogWriteRepository
    {
        public BlogWriteRepository(BlogDemoDbContext context) : base(context)
        {
        }
    }
}
