using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EfCoreEntitiesMapping
{
    public class BlogMap : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(b=> b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();

            builder.Property(b => b.Title).HasMaxLength(100).IsRequired();
            builder.Property(b => b.Content).HasMaxLength(300).IsRequired();
            builder.Property(b => b.Image).HasMaxLength(250).IsRequired();
            builder.Property(b => b.ThumbnailImage).HasMaxLength(250).IsRequired();

            builder.Property(b => b.CreatedDate).IsRequired();
            builder.Property(b => b.UpdatedDate).IsRequired();
            builder.Property(b => b.IsActive).IsRequired();

            builder.HasOne(b => b.Category)
                .WithMany(c => c.Blogs)
                .HasForeignKey(b => b.CategoryId);

            builder.ToTable("Blogs");
        }
    }
}
