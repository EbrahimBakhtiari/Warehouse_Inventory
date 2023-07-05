using Domain;

namespace Persistence.IServices
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken);
        Task CreateAsync(T entity, CancellationToken cancellationToken);
        Task UpdateAsync(T entity, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

}
