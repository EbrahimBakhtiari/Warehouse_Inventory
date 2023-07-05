using Domain.Entities;

namespace Persistence.IServices
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByUsernameAsync(string username, CancellationToken cancellationToken);
        Task<bool> IsUsernameExistsAsync(string username, CancellationToken cancellationToken);
    }

}
