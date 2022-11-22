using Domain.Entities.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EfCoreEntitiesMapping
{
    public class WriterImageFileWriterMap : IEntityTypeConfiguration<WriterImageFileWriter>
    {
        public void Configure(EntityTypeBuilder<WriterImageFileWriter> builder)
        {
            builder.HasKey(wi => new { wi.WriterId, wi.WriterImageId });

            builder.HasOne(wi => wi.Writer)
                .WithMany(w => w.WriterImageFiles)
                .HasForeignKey(wi => wi.WriterId);

            builder.HasOne(wi => wi.WriterImageFile)
                .WithMany(i => i.Writers) 
                .HasForeignKey(wi => wi.WriterImageId);
        }
    }
}
