namespace Delt.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IBlogRepository Blog { get; }
        IBookRepository Book { get; }
        Task Commit();
    }
}
