using Delt.DataAccess.Data;
using Delt.DataAccess.Interfaces;
using Delt.Models;

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
    }
}
