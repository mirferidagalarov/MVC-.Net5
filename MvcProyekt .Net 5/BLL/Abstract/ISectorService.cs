using MvcProyekt_.Net_5.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Abstract
{
    public interface ISectorService
    {
        Task<List<SectorToListDTO>> Get();
        Task<SectorToUpdateDTO> GetId(int sectorId);
        Task Add(SectorToAddDTO sectorToAddDTO);
        Task Update(SectorToUpdateDTO sectorToUpdateDTO);
        Task Delete(int sectorId);
    }
}
