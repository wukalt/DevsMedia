using Delt.DataAccess.Data;
using Delt.DataAccess.Interfaces;
using Delt.Models;

namespace Delt.DataAccess.Repository
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        private readonly ApplicationDbContext _context;

        public BlogRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task Update(Blog blog)
        {
            await Task.Run(() =>
            {
                _context.Blogs.Update(blog);
            });
        }
    }
}
