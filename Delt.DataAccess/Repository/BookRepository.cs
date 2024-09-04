using Delt.DataAccess.Data;
using Delt.DataAccess.Interfaces;
using Delt.Models;

namespace Delt.DataAccess.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context) : base(context)
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
