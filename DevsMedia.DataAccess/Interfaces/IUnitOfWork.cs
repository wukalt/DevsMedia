namespace DevsMedia.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBlogRepository Blog { get; }
        Task Commit();
    }
}
