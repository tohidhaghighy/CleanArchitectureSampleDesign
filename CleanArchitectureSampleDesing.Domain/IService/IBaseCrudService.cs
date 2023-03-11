using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LTMS.Core.GenericDataResponse;

namespace LTMS.Domain.IService
{
    public interface IBaseCrudService<TEntity>
    {
       DataResponse<ICollection<TEntity>> GetAll();
        DataResponse<bool> Update(TEntity model);
        DataResponse<TEntity> Insert(TEntity model);
        DataResponse<IEnumerable<TEntity>> FindBy(Expression<Func<TEntity, bool>> predicate);
        void ExecuteSql(string sql);
        DataResponse<bool> Remove(TEntity Entity);
       DataResponse<TEntity> FindById<TTKey>(TTKey key);
        void Commit();
    }
}
