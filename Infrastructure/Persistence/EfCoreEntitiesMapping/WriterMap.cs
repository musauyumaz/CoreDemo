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
    public class WriterMap : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Id).ValueGeneratedOnAdd();

            builder.Property(w => w.FullName).HasMaxLength(100);
            builder.Property(w => w.About).HasMaxLength(300);
            builder.Property(w => w.Email).HasMaxLength(100);
            builder.Property(w => w.Password).HasMaxLength(25);

            builder.Property(w => w.CreatedDate).IsRequired();
            builder.Property(w => w.UpdatedDate).IsRequired();
            builder.Property(w => w.IsNotActive).IsRequired();

            builder.ToTable("Writers");
        }
    }
}
