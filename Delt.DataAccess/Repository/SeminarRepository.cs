using Delt.DataAccess.Data;
using Delt.DataAccess.Interfaces;
using Delt.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Delt.DataAccess.Repository
{
    public class SeminarRepository : Repository<Seminar>, ISeminarRepository
    {
        private readonly ApplicationDbContext _context;

        public SeminarRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task Update(Seminar seminar)
        {
            await Task.Run(() =>
            {
                _context.Seminars.Update(seminar);
            });
        }

        public override async Task<IEnumerable<Seminar>> GetAllAsync(int take = 0)
        {
            return await _context.Seminars.Include(x => x.Teacher).ToListAsync();
        }

        public override async Task<Seminar> GetAsync(Expression<Func<Seminar, bool>> filter)
        {
            Seminar? seminar = await _context.Seminars.Where(filter).Include(x => x.Teacher).FirstOrDefaultAsync();
            return seminar ?? new Seminar();
        }
    }
}
