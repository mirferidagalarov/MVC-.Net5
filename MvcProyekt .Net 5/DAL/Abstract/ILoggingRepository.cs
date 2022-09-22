using MvcProyekt_.Net_5.DAL.Repositories.Abstract;
using MvcProyekt_.Net_5.Entities;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.DAL.Abstract
{
    public interface ILoggingRepository : IGenericRepository<RequestLog>
    {
      
            Task AddLog(RequestLog requestLog);
        
    }
}
