using Microsoft.EntityFrameworkCore;

namespace Application.Infra
{
    public interface IARepository<TEntity> where TEntity : class
    {
        DbContext DbContext { get; }
        void Commit();
        IQueryable<TEntity> Queryable();
        void Delete(object id);
        void Delete(TEntity entity);
    }
}
