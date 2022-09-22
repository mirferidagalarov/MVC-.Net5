using Microsoft.EntityFrameworkCore;
using MvcProyekt_.Net_5.DAL.Abstract;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.DAL.Repositories.Concrete;
using MvcProyekt_.Net_5.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.DAL.Concrete
{
    public class EmployeeRepository:GenericRepository<Employee>,IEmployeeRepository
    {
        private readonly DataContext _dataContext;
        public EmployeeRepository(DataContext dataContext):base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Employee>> GetAll()
        {
            List<Employee> employees = await _dataContext.Employees.Include(m => m.Department).Include(m => m.Sector).Include(m => m.Position).ToListAsync();
            return employees;
        }
    }
}
