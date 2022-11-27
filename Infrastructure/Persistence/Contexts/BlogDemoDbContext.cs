using Domain.Entities;
using Domain.Entities.Common;
using Domain.Entities.Storages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Reflection;

namespace Persistence.Contexts
{
    public class BlogDemoDbContext : DbContext
    {
        public BlogDemoDbContext(DbContextOptions options) : base(options)
        {}
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Domain.Entities.Storages.File> Files { get; set; }
        public DbSet<AboutImageFile> AboutImageFiles { get; set; }
        public DbSet<BlogImageFile> BlogImageFiles { get; set; }                                                                                                                               
        public DbSet<WriterImageFile> WriterImageFiles { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public override int SaveChanges()
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                if(data.State == EntityState.Modified)
                    data.Entity.UpdatedDate = DateTime.UtcNow;
                if (data.State == EntityState.Added)
                {
                    data.Entity.CreatedDate = DateTime.UtcNow;
                    data.Entity.IsNotActive = false;
                }
            }

            return base.SaveChanges();
        }

    }
    
}
