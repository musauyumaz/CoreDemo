using Application.Repositories.WriterRepository;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.WriterRepository
{
    public class WriterReadRepository : ReadRepository<Writer>, IWriterReadRepository
    {
        public WriterReadRepository(BlogDemoDbContext context) : base(context)
        {
        }
    }
}
