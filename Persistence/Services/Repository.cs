using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.IServices;

namespace Persistence.Services
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DatabaseContext _context;

        public Repository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(e => e.Id == id && !e.IsDeleted, cancellationToken);
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Set<T>().Where(e => !e.IsDeleted).ToListAsync(cancellationToken);
        }

        public async Task CreateAsync(T entity, CancellationToken cancellationToken)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = await _context.Set<T>().FindAsync( id , cancellationToken);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeleteDateTime = DateTime.Now;
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }

}
