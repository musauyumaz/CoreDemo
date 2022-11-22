using Domain.Entities.Storages;

namespace Domain.Entities.CrossTables
{
    public class AboutImageFileAbout
    {
        public int AboutId { get; set; }
        public int AboutImageFileId { get; set; }

        public About About { get; set; }
        public AboutImageFile AboutImageFile { get; set; }
    }
}
