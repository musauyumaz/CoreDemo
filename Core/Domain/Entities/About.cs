using Domain.Entities.Common;
using Domain.Entities.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class About : BaseEntity
    {
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string MapLocation { get; set; }

        public ICollection<AboutImageFileAbout> AboutImageFiles { get; set; }
    }
}
