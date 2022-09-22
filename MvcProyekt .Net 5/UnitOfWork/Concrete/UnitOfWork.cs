using MvcProyekt_.Net_5.DAL.Abstract;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.UnitofWork.Abstract;
using System;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.UnitofWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public IDepartmentRepository departmentRepository { get; set; }
        public ISectorRepository sectorRepository { get; set; }
        public IEmployeeRepository employeeRepository { get; set; }
        public IUserRepository userRepository { get; set; }
        public IPositionRepository positionRepository { get; set; }
        public ISalaryRepository salaryRepository { get; set; }
        public IYearRepository yearRepository { get; set; }
        public IMonthRepository monthRepository { get; set; }
       
        private bool isDisposed = false;

        public UnitOfWork(IDepartmentRepository DepartmentRepository, ISectorRepository SectorRepository, IEmployeeRepository EmployeeRepository, IUserRepository UserRepository, DataContext dataContext, IPositionRepository PositionRepository, ISalaryRepository SalaryRepository,IYearRepository YearRepository,IMonthRepository MonthRepository)
        {
            _dataContext = dataContext;
            departmentRepository = DepartmentRepository;
            sectorRepository = SectorRepository;
            employeeRepository = EmployeeRepository;
            userRepository = UserRepository;
            positionRepository = PositionRepository;
            yearRepository = YearRepository;
            salaryRepository = SalaryRepository;
            monthRepository = MonthRepository;
        }

        public async Task CommitAsync()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                isDisposed = true;
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dataContext.Dispose();
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (!isDisposed)
            {
                isDisposed = true;
                await DisposeAsync(true);
                GC.SuppressFinalize(this);
            }
        }

        protected async ValueTask DisposeAsync(bool disposing)
        {
            if (disposing)
            {
                await _dataContext.DisposeAsync();
            }
        }
    }
}
