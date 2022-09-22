using MvcProyekt_.Net_5.DAL.Repositories.Abstract;
using MvcProyekt_.Net_5.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.DAL.Abstract
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
        Task<List<Employee>> GetAll();
    }
}
