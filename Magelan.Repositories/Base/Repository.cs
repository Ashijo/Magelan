using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Magelan.Domains;
using Magelan.Repositories.DbContexts;
using Magelan.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Magelan.Repositories.Base {
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IBasicEntity {
        protected readonly MagelanDbContext Context;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(MagelanDbContext context) {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }


        public virtual  TEntity Get<TId>(TId id) {
            // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
            // such as Courses or Authors, and we need to use the generic Set() method to access them.

            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll() {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.

            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) {
            return DbSet.Where(predicate);
        }

        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate) {
            return DbSet.SingleOrDefault(predicate);
        }

        public virtual void Add(TEntity entity) {
            var entry = Context.Entry(entity);

            entity.Creation = DateTime.Now;
            entry.State = EntityState.Detached;

            DbSet.Add(entity);
        }

        public virtual void AddRange(IEnumerable<TEntity> entities) {
            foreach (var entity in entities) {
                entity.Creation = DateTime.Now;
            }

            DbSet.AddRange(entities);
        }


        public virtual bool SaveChanges() {
            return Context.SaveChanges() > 0;
        }
    }
}