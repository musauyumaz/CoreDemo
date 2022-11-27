using Domain.Entities.Storages;

namespace Domain.Entities.CrossTables
{
    public class WriterImageFileWriter
    {
        public int WriterId { get; set; }
        public int WriterImageId { get; set; }

        public virtual Writer? Writer { get; set; }
        public virtual WriterImageFile? WriterImageFile { get; set; }
    }
}
