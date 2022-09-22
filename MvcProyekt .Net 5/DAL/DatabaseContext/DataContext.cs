using Microsoft.EntityFrameworkCore;
using MvcProyekt_.Net_5.Entities;
using System.Data;

namespace MvcProyekt_.Net_5.DAL.DatabaseContext
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salarys> Salariys { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Years> Years { get; set; }
        public DbSet<Chart> Charts { get; set; }
        public DbSet<RequestLog> RequestLogs { get; set; }
        public DbSet<ResponseLog> ResponseLogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Department>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Sector>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Employee>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Salarys>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<RequestLog>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<ResponseLog>().HasQueryFilter(m => !m.IsDeleted);
        }
    }
    
}
