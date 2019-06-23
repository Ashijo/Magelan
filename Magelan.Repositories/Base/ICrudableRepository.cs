using System.Collections.Generic;
using Magelan.Domains;
using Magelan.Repositories.Interfaces;

namespace Magelan.Repositories.Base {
    public interface ICrudableRepository<TEntity> : IRepository<TEntity> where TEntity : BasicEntity {
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entity);
    }
}