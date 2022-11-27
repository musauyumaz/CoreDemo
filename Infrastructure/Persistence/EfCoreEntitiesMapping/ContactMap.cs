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
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.UserName).HasMaxLength(75);
            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.Subject).HasMaxLength(100);
            builder.Property(c => c.Message).HasMaxLength(500);

            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.UpdatedDate).IsRequired();
            builder.Property(c => c.IsNotActive).IsRequired();

            builder.ToTable("Contacts");
        }
    }
}
