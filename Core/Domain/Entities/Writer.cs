using Domain.Entities.Common;
using Domain.Entities.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Writer : BaseEntity
    {
        public string FullName { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<WriterImageFileWriter>? WriterImageFiles { get; set; }
    }
}
