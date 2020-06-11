using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Infrastructure.RepositoryContract.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Ujjwal
        //Repository should always return IEnumerable and never return IQueriable and should not have update and save methods. : 


        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate); // single or default is in general faster than find

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        //void Update(TEntity entityToUpdate);

    }
}
