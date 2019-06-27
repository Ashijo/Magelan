using System.Collections.Generic;
using Magelan.Domains;
using Magelan.Repositories.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Magelan.Repositories.Base {
    public class CrudableRepository<TEntity> : Repository<TEntity> where TEntity : BasicEntity {

        public CrudableRepository(MagelanDbContext context) : base(context) { }
        
        
        public void Remove(TEntity entity) {
           // entity.Deleted = true;
            DbSet.Update(entity);

            
            //We use soft delete here
            //DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities) {
            foreach (var entity in entities) {
               // entity.Deleted = true;
            }

            DbSet.UpdateRange(entities);
            //DbSet.RemoveRange(entities);
        }

        public void Update(TEntity entity) {
            var entry = Context.Entry(entity);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Modified;
            }
            else
            {
                DbSet.Update(entity);
            }
        }

        public void UpdateRange(IEnumerable<TEntity> entities) {
            DbSet.UpdateRange(entities);
        }
        

    }
}