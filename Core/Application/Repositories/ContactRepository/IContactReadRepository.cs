using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.ContactRepository
{
    public interface IContactReadRepository : IReadRepository<Contact>
    {
    }
}
