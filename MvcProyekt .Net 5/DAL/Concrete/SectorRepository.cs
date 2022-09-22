using Microsoft.EntityFrameworkCore;
using MvcProyekt_.Net_5.DAL.Abstract;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.DAL.Repositories.Concrete;
using MvcProyekt_.Net_5.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.DAL.Concrete
{
    public class SectorRepository:GenericRepository<Sector>,ISectorRepository
    {
        private readonly DataContext _dataContext;
        public SectorRepository(DataContext dataContext):base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Sector>> GetAll()
        {
            List<Sector> sectors = await _dataContext.Sectors.Include(m => m.Department).ToListAsync();
            return sectors;
        }
    }
}
