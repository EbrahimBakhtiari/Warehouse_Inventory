using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.IServices;
using Persistence.Services;

namespace Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context)
        {

        }

        public async Task<User> GetByUsernameAsync(string username, CancellationToken cancellationToken)
        {
            return await _context.Users.Where(u => !u.IsDeleted).SingleOrDefaultAsync(u => u.Username == username, cancellationToken);
        }

        public async Task<bool> IsUsernameExistsAsync(string username, CancellationToken cancellationToken)
        {
            return await _context.Users.AnyAsync(u => u.Username == username && !u.IsDeleted, cancellationToken);
        }
    }
}
