using Domain.Entities;
using Persistence.IServices;

namespace Persistence.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public IRepository<User> Users { get; private set; }

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            Users = new Repository<User>(_context);
        }

        public async Task<int> CompleteAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
