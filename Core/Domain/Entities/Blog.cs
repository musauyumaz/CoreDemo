using Domain.Entities.Common;
using Domain.Entities.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Blog : BaseEntity
    {
        public Blog()
        {
            Comments = new HashSet<Comment>();
        }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<BlogImageFileBlog> BlogImageFiles { get; set; }
    }
}
