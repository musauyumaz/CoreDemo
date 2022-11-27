using Domain.Entities.Storages;

namespace Domain.Entities.CrossTables
{
    public class AboutImageFileAbout
    {
        public int AboutId { get; set; }
        public int AboutImageFileId { get; set; }

        public virtual About? About { get; set; }
        public virtual AboutImageFile? AboutImageFile { get; set; }
    }
}
