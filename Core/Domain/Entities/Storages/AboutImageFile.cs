using Domain.Entities.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Storages
{
    public class AboutImageFile : File
    {
        public virtual ICollection<AboutImageFileAbout>? Abouts { get; set; }
    }
}
