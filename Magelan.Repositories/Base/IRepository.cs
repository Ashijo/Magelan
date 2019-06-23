using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Magelan.Domains;

namespace Magelan.Repositories.Interfaces {
    public interface IRepository<TEntity> where TEntity : BasicEntity {
        TEntity Get(Guid id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        // This method was not in the videos, but I thought it would be useful to add.
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

     

        bool SaveChanges();
    }
}