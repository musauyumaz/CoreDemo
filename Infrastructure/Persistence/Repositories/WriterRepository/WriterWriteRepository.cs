using Application.Repositories.WriterRepository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.WriterRepository
{
    public class WriterWriteRepository : WriteRepository<Writer>, IWriterWriteRepository
    {
        public WriterWriteRepository(BlogDemoDbContext context) : base(context)
        {
        }
    }
}
