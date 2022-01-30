using LifeOfFighter.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LifeOfFighter.Application.Repositories
{
    public interface IRepository<TEntity> where TEntity: BaseEntity
    {
        Task<IEnumerable<TEntity>> GellAllAsync(Expression<Func<TEntity, bool>> predicate = null);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task InsertAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
