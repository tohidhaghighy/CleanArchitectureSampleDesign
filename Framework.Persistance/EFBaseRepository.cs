using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Framework.Persistance
{
    public abstract class EFRepositoryBase<TContext, TEntity> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        protected readonly DbContext _dbContext;

        public EFRepositoryBase(DbContext context)
        {
            this._dbContext = context;
        }

        public virtual bool Delete<TKey>(TKey id)
        {
            try
            {
                var model = this.Get(id);
                this.GetSet().Remove(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ICollection<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return this.GetSet().Where(predicate).ToList();
            }
            catch (Exception)
            {
                return new List<TEntity>();
            }
        }

        public TEntity Get<TKey>(TKey id)
        {
            try
            {
                return this.GetSet().Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public TEntity FindById<TTKey>(TTKey key)
        {
            return this.GetSet().Find(key);
        }
        public ICollection<TEntity> GetAll()
        {
            var res = this.GetSet().ToList();
            return res;
        }

        public virtual TEntity Insert(TEntity model)
        {
            this.GetSet().Add(model);
          //  this.GetSet().Attach(model);
            return model;
        }
        public void Commit()
        {
            this._dbContext.SaveChanges();
        }
        public void ExecuteSql(string sql)
        {
            //  _dbContext.Database.<string>(@sql);
            _dbContext.SaveChanges();
        }
        public bool Remove(TEntity Model)
        {
            try
            {
                GetSet().Remove(Model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(TEntity model)
        {
            this.GetSet().Attach(model);
            this._dbContext.Entry(model).State = EntityState.Modified;
            return true;
        }
        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return GetSet().Where(predicate).ToList();
        }
        protected DbSet<TEntity> GetSet()
        {
            return this._dbContext.Set<TEntity>();
        }
    }
}
