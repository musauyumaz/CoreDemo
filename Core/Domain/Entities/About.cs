using Domain.Entities.Common;
using Domain.Entities.CrossTables;

namespace Domain.Entities
{
    public class About : BaseEntity
    {
        public About()
        {
            AboutImageFiles = new HashSet<AboutImageFileAbout>();
        }
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string MapLocation { get; set; }

        public virtual ICollection<AboutImageFileAbout>? AboutImageFiles { get; set; }
    }
}
