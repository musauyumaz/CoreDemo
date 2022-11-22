using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.CrossTables;

namespace Domain.Entities.Storages
{
    public class BlogImageFile : File
    {
        public ICollection<BlogImageFileBlog> Blogs { get; set; }
    }
}
