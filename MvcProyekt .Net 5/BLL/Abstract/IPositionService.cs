using MvcProyekt_.Net_5.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Abstract
{
    public interface IPositionService
    {
        Task<List<PositionToListDTO>> Get();
        //Task<EmployeeToUpdateDTO> GetId(int employeeId);
        //Task Add(EmployeeToAddDTO employeeToAddDTO, string filename);
        //Task Edit(EmployeeToUpdateDTO employeeToUpdateDTO);
        //Task Delete(int employeeId);
    }
}
