namespace DevsMedia.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBlogRepository Blog { get; }
        IBookRepository Book { get; }
        Task Commit();
    }
}
