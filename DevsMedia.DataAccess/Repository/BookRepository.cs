using DevsMedia.DataAccess.Data;
using DevsMedia.DataAccess.Interfaces;
using DevsMedia.Models;

namespace DevsMedia.DataAccess.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Update(Book book)
        {
            await Task.Run(() =>
            {
                _context.Update(book);
            });
        }
    }
}
