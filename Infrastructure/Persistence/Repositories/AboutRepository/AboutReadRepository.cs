using Application.Repositories.AboutRepository;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.AboutRepository
{
    public class AboutReadRepository : ReadRepository<About>,IAboutReadRepository
    {
        public AboutReadRepository(BlogDemoDbContext context) : base(context)
        {
        }
    }
}
