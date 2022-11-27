using Application.Repositories;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly BlogDemoDbContext _context;

        public WriteRepository(BlogDemoDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public bool Add(T model)
        {
            EntityEntry entityEntry = Table.Add(model);
            return entityEntry.State == EntityState.Added;
        }

        public bool AddRange(IList<T> datas)
        {
            Table.AddRange(datas);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool Remove(int id)
        {
            T model = Table.FirstOrDefault(data => data.Id == id);
            model.IsNotActive = true;
            //EntityEntry entityEntry = Table.Remove(model);
            //return entityEntry.State == EntityState.Deleted;
            return true;
        }

        public bool RemoveRange(IList<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public int Save()
            => _context.SaveChanges();

        public bool Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}
