using MvcProyekt_.Net_5.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Abstract
{
    public interface ISalaryService
    {
        Task<List<SalaryToListDTO>> Get();
        //Task<SectorToUpdateDTO> GetId(int sectorId);
        Task Add(SalaryToAddDTO  salaryToAddDTO);
        //Task Edit(SectorToUpdateDTO sectorToUpdateDTO);
        Task Delete(int salaryId);
    }
}
