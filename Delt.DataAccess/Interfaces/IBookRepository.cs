using Delt.Models;

namespace Delt.DataAccess.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Task Update(Book book);
    }
}
