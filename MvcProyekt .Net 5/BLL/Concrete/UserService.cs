using AutoMapper;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.DAL.Abstract;
using MvcProyekt_.Net_5.Entities;
using MvcProyekt_.Net_5.Models;
using MvcProyekt_.Net_5.UnitofWork.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Concrete
{
    public class UserService:IUserService
    {
        private readonly IUnitOfWork  _unitOfWork ;
        private readonly IMapper _mapper;
        public UserService(IUnitOfWork  unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(UserToAddDTO userToAddDTO)
        {
            User user = _mapper.Map<User>(userToAddDTO);
            await _unitOfWork.userRepository.Add(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int userId)
        {
            await _unitOfWork.userRepository.Delete(userId);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<UserToListDTO>> Get()
        {
            List<User> users = await _unitOfWork.userRepository.Get();
            return _mapper.Map<List<UserToListDTO>>(users);

        }

        public async Task<UserToListDTO> GetId(int userId)
        {
            User user = await _unitOfWork.userRepository.GetId(userId);
            return _mapper.Map<UserToListDTO>(user);
        }

        public async Task Update(User userToUpdateDTO)
        {
            User user = _mapper.Map<User>(userToUpdateDTO);
            await _unitOfWork.userRepository.Update(user);
            await _unitOfWork.CommitAsync();
        }
    }
}
