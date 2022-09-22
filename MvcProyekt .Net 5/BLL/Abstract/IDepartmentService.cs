using MvcProyekt_.Net_5.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Abstract
{
    public interface IDepartmentService
    {
        Task<List<DepartmentToListDTO>> Get();
        Task<DepartmentToUpdateDTO> GetId(int departmentId);
        Task Add(DepartmentToAddDTO departmentToAddDTO);
        Task Update(DepartmentToUpdateDTO departmentToEditDTO);
        Task Delete(int departmentId);

    }
}
