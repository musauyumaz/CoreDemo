using Domain.Entities.CrossTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EfCoreEntitiesMapping
{
    public class BlogImageFileBlogMap : IEntityTypeConfiguration<BlogImageFileBlog>
    {
        public void Configure(EntityTypeBuilder<BlogImageFileBlog> builder)
        {
            builder.HasKey(bi => new { bi.BlogId, bi.BlogImageFileId });

            
                
        }
    }
}
