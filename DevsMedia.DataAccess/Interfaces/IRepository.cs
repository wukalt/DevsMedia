using System.Linq.Expressions;

namespace DevsMedia.DataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task Add(T entity);
        Task Remove(T entity);

        //IEnumerable<T> GetAll();
        //T Get(Expression<Func<T, bool>> filter);

    }
}
