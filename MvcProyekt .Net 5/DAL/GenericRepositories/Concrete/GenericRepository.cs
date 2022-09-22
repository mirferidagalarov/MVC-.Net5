using Microsoft.EntityFrameworkCore;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.DAL.Repositories.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.DAL.Repositories.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        protected DataContext _dataContext;
        private DbSet<TEntity> _dbset;
        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dbset = dataContext.Set<TEntity>();
        }

        public async Task Add(TEntity entity)
        {
           await _dbset.AddAsync(entity);
        }

        public async Task Delete(int Id)
        {
            TEntity entity=await _dbset.FindAsync(Id);
            _dbset.Remove(entity);
        }

        public async Task<List<TEntity>> Get()
        {
           return await _dbset.ToListAsync();
        }

        public async Task<TEntity> GetId(int Id)
        {
            return await _dbset.FindAsync(Id);
        }

        public async Task Update(TEntity entity)
        {
          _dbset.Update(entity);
        }
    }
}
