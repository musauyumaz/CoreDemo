using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.CrossTables;

namespace Domain.Entities.Storages
{
    public class WriterImageFile : File
    {
        public virtual ICollection<WriterImageFileWriter>? Writers { get; set; }
    }
}
