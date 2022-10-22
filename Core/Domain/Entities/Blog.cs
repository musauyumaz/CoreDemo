using Domain.Entities.Common;
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
        public string Image { get; set; }
        public string ThumbnailImage { get; set; }

        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
