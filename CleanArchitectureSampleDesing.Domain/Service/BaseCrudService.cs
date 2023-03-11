using AutoMapper;
using Framework.Persistance;
using LTMS.Domain.IService;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LTMS.Core.Extensions;
using LTMS.Core.GenericDataResponse;

namespace LTMS.Domain.Service
{
    public class BaseCrudService<TEntity> : IBaseCrudService<TEntity>
        where TEntity : class, new()
    {
        IRepository<TEntity> _repository;
        private IMapper _mapper;
        public BaseCrudService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public DataResponse<bool> Remove(TEntity entity)
        {
            bool result = false;
            DataResponse<bool> response = new DataResponse<bool>();
            try
            {
                result = _repository.Remove(entity);
                Commit();
                response.Result = result;
            }
            catch (Exception e)
            {
                response.ErrorList = new List<ResponseError>();
                response.ErrorList.Add(new ResponseError(DataResponseErrorCode.InternalError, e.Message));
            }
            return response;
        }
        public void ExecuteSql(string sql)
        {
            _repository.ExecuteSql(sql);
            Commit();
        }

        public DataResponse<ICollection<TEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result.ToDataResponse();
        }

        public DataResponse<bool> Update(TEntity entity)
        {
            DataResponse<bool> response = new DataResponse<bool>();
            bool result = false;
            try
            {
                result = _repository.Update(entity);
                Commit();
                response.Result = result;
            }
            catch (Exception e)
            {
                 response.ErrorList = new List<ResponseError>();
                 response.ErrorList.Add(new ResponseError(DataResponseErrorCode.InternalError,e.Message));
            }
            return response;
        }

        public virtual DataResponse<TEntity> Insert(TEntity Entity)
        {
            var obj = _repository.Insert(Entity);
            Commit();
            return obj.ToDataResponse();
        }
        public DataResponse<IEnumerable<TEntity>> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            var result = _repository.FindBy(predicate);
            return result.ToDataResponse();
        }
        public void Commit()
        {
            _repository.Commit();
        }
        public DataResponse<TEntity> FindById<TTKey>(TTKey key)
        {
            var result = _repository.FindById<TTKey>(key);
            return result.ToDataResponse();// _mapper.Map<TEntity>(result);
        }
    }
}
