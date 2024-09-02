using DevsMedia.Models;

namespace DevsMedia.DataAccess.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Task Update(Book book);
    }
}
