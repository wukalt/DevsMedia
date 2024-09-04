using Delt.Models;

namespace Delt.DataAccess.Interfaces
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Task Update(Blog blog);
    }
}
