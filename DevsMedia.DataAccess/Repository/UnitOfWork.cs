using DevsMedia.DataAccess.Data;
using DevsMedia.DataAccess.Interfaces;
using DevsMedia.Models;

namespace DevsMedia.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        #region InterfaceRepositories
        public IBlogRepository Blog { get; private set; }
        public IBookRepository Book { get; private set; }
        #endregion

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Blog = new BlogRepository(_context);
            Book = new BookRepository(_context);
        }

        public async Task Commit() => await _context.SaveChangesAsync();
    }
}
