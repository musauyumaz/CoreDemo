using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> method);
        T GetSingle(Expression<Func<T, bool>> method);
        T GetById(int id);
    }
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        bool Add(T model);
        bool AddRange(IList<T> datas);
        bool Remove(T model);
        bool Remove(int id);
        bool RemoveRange(IList<T> datas);
        bool Update(T model);
        int Save();
    }
}
