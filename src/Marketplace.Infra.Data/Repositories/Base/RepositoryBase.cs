using Marketplace.Domain.Interfaces.Repositories.Base;
using Marketplace.Infra.Data.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Infra.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected MarketplaceContext Db = new MarketplaceContext();

        public async Task<TEntity> Add(TEntity entity)
        {
            Db.Set<TEntity>().Add(entity);
            await Db.SaveChangesAsync();
            return entity;
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Db.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(long id)
        {
            return await Db.Set<TEntity>().FindAsync(id);
        }

        public async Task Remove(TEntity entity)
        {
            Db.Set<TEntity>().Remove(entity);
            await Db.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            Db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            await Db.SaveChangesAsync();
        }
    }
}
