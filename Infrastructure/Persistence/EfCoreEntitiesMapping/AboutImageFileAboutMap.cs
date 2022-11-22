using Domain.Entities.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EfCoreEntitiesMapping
{
    public class AboutImageFileAboutMap : IEntityTypeConfiguration<AboutImageFileAbout>
    {
        public void Configure(EntityTypeBuilder<AboutImageFileAbout> builder)
        {
            builder.HasKey(ai => new { ai.AboutId, ai.AboutImageFileId });

            builder.HasOne(ai => ai.About)
                .WithMany(a => a.AboutImageFiles)
                .HasForeignKey(ai => ai.AboutId);

            builder.HasOne(ai => ai.AboutImageFile)
                .WithMany(a => a.Abouts)
                .HasForeignKey(ai => ai.AboutImageFileId);

            
        }
    }
}
