using MvcProyekt_.Net_5.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Abstract
{
    public interface IMonthService
    {
        Task<List<MonthToListDTO>> Get();
    }
}
