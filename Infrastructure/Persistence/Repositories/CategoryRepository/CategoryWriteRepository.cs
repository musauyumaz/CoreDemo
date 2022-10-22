using Application.Repositories.CategoryRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.CategoryRepository
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(BlogDemoDbContext context) : base(context)
        {
        }
    }
}
