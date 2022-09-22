using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.BLL.Concrete;
using MvcProyekt_.Net_5.DAL.Abstract;
using MvcProyekt_.Net_5.DAL.Concrete;
using MvcProyekt_.Net_5.DAL.Core;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.UnitofWork.Abstract;
using MvcProyekt_.Net_5.UnitofWork.Concrete;

namespace MvcProyekt_.Net_5.DependencyInjection
{
    public class DepInjection
    {
        private readonly IConfiguration Configuration;
        public DepInjection(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void RegisterServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("Db"));
            });

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ISectorRepository, SectorRepository>();
            services.AddScoped<ISectorService, SectorService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISalaryRepository, SalaryRepository>();
            services.AddScoped<ISalaryService, SalaryService>();
            services.AddScoped<IYearRepository, YearRepository>();
            services.AddScoped<IYearService, YearService>();
            services.AddScoped<IMonthRepository, MonthRepository>();
            services.AddScoped<IMonthService, MonthService>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ILoggingRepository, LoggingRepository>();
            services.AddAutoMapper(typeof(Automapper));




            
        }
    }
}
