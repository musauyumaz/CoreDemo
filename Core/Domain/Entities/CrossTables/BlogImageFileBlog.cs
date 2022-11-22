using Domain.Entities.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.CrossTables
{
    public class BlogImageFileBlog
    {
        public int BlogId { get; set; }
        public int BlogImageFileId { get; set; }

        public Blog Blog { get; set; }
        public BlogImageFile BlogImageFile { get; set; }
    }
}
