using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.DAL.Repositories.Abstract
{
    public interface IGenericRepository<TEntity>
        where TEntity:class ,new()
    {
        Task<List<TEntity>> Get();
        Task<TEntity> GetId(int Id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int Id);
    }
}
