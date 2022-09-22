using MvcProyekt_.Net_5.DAL.Abstract;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using System;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.UnitofWork.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable
    {
       
        public IDepartmentRepository departmentRepository { get; set; }
        public ISectorRepository sectorRepository { get; set; } 
        public IEmployeeRepository employeeRepository { get; set; } 
        public IUserRepository userRepository { get; set; }
        public IPositionRepository positionRepository { get; set; }
        public ISalaryRepository salaryRepository { get; set; }
        public IYearRepository yearRepository { get; set; }
        public IMonthRepository monthRepository { get; set; }
        public Task CommitAsync();
    
    }
}
