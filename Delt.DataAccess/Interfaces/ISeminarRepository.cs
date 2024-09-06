using Delt.Models;

namespace Delt.DataAccess.Interfaces
{
    public interface ISeminarRepository : IRepository<Seminar>
    {
        Task Update(Seminar seminar);
    }
}
