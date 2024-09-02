using DevsMedia.Models;

namespace DevsMedia.DataAccess.Interfaces
{
    public interface IBookRepository
    {
        Task Update(Book book);
    }
}
