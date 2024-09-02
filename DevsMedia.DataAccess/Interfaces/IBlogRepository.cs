using DevsMedia.Models;

namespace DevsMedia.DataAccess.Interfaces
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Task Update(Blog blog);
    }
}
