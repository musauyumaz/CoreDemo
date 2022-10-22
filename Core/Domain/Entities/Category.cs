using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Blogs = new HashSet<Blog>();
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Blog> Blogs { get; set; }

    }
}
