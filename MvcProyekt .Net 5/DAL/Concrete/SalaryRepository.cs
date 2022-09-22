using Microsoft.EntityFrameworkCore;
using MvcProyekt_.Net_5.DAL.Abstract;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.DAL.Repositories.Concrete;
using MvcProyekt_.Net_5.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.DAL.Concrete
{
    public class SalaryRepository:GenericRepository<Salarys>,ISalaryRepository
    {
        private readonly DataContext _dataContext;
        public SalaryRepository(DataContext dataContext):base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Salarys>> GetAll()
        {
            List<Salarys> salaryys = await _dataContext.Salariys.Include(m => m.Month).Include(m => m.Year).Include(m => m.Employee).ToListAsync();
            return salaryys;
        }
    }
}
