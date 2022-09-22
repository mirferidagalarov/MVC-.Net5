using MvcProyekt_.Net_5.DAL.Abstract;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.DAL.Repositories.Concrete;
using MvcProyekt_.Net_5.Entities;

namespace MvcProyekt_.Net_5.DAL.Concrete
{
    public class MonthRepository:GenericRepository<Month>,IMonthRepository
    {
        public MonthRepository(DataContext dataContext):base(dataContext)
        {

        }
    }
}
