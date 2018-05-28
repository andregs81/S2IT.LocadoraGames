using Microsoft.EntityFrameworkCore;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace S2IT.LocadoraGames.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> 
        where TEntity : class
    {
        protected DbSet<TEntity> DbSet;
        protected readonly LocadoraGamesContext Db;

        public Repository(LocadoraGamesContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            Db.Add(obj);
        }

        public void Update(TEntity obj)
        {
            Db.Update(obj);
        }


        public void Remove(int id)
        {
            Db.Remove(DbSet.Find(id));
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
