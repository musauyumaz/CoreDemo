using Domain.Entities.Storages;

namespace Domain.Entities.CrossTables
{
    public class WriterImageFileWriter
    {
        public int WriterId { get; set; }
        public int WriterImageId { get; set; }

        public Writer Writer { get; set; }
        public WriterImageFile WriterImageFile { get; set; }
    }
}
