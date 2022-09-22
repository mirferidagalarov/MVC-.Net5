using MvcProyekt_.Net_5.DAL.Abstract;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.DAL.Repositories.Concrete;
using MvcProyekt_.Net_5.Entities;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.DAL.Concrete
{
    public class LoggingRepository: GenericRepository<RequestLog>, ILoggingRepository
    {
        private readonly DataContext _dataContext;
        public LoggingRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task AddLog(RequestLog requestLog)
        {
            await _dataContext.RequestLogs.AddAsync(requestLog);
            await _dataContext.SaveChangesAsync();
        }
    }
}
