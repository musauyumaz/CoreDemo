using Domain.Entities.Common;

namespace Application.Repositories
{
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
