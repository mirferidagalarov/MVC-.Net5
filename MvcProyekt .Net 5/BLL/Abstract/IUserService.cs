using MvcProyekt_.Net_5.Entities;
using MvcProyekt_.Net_5.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Abstract
{
    public interface IUserService
    {
        Task<List<UserToListDTO>> Get();
        Task<UserToListDTO> GetId(int userId);
        Task Add(UserToAddDTO userToAddDTO);
        Task Update(User yoxla);
        Task Delete(int userId);
    }
}
