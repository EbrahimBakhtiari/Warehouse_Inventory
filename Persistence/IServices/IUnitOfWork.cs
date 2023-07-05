using Domain.Entities;

namespace Persistence.IServices
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        Task<int> CompleteAsync(CancellationToken cancellationToken);
    }

}
