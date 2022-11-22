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
    public class AboutMap : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.Detail1).HasMaxLength(500).IsRequired();
            builder.Property(a => a.Detail2).HasMaxLength(500).IsRequired();
            builder.Property(a => a.MapLocation).HasMaxLength(250).IsRequired();

            builder.Property(b => b.CreatedDate).IsRequired();
            builder.Property(b => b.UpdatedDate).IsRequired();
            builder.Property(b => b.IsActive).IsRequired();

            builder.ToTable("Abouts");
        }
    }
}
