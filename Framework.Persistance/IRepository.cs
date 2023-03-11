using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Framework.Persistance
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ICollection<TEntity> GetAll();
        TEntity Insert(TEntity model);
        bool Update(TEntity model);
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        void ExecuteSql(string sql);
        bool Remove(TEntity id);
        void Commit();
        TEntity FindById<TTKey>(TTKey key);
    }
}
