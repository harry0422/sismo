using Dinaf.Sismo.Domain.Common.Entities;
using System.Collections.Generic;

namespace Dinaf.Sismo.Domain.Common.Repositories
{
    public interface IRepository
    {

    }

    public interface IRepository<TEntity, TPrimaryKey> : IRepository where TEntity : IAggregateRoot
    {
        IList<TEntity> GetAll();
        TEntity Get(TPrimaryKey key);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TPrimaryKey id);
    }
}