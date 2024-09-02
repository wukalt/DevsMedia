using DevsMedia.DataAccess.Data;
using DevsMedia.DataAccess.Interfaces;
using DevsMedia.Models;

namespace DevsMedia.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBlogRepository Blog { get; private set; }
       
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Blog = new BlogRepository(_context);
        }

        public async Task Commit() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
