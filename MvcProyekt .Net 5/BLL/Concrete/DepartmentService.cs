using AutoMapper;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.Entities;
using MvcProyekt_.Net_5.Models;
using MvcProyekt_.Net_5.UnitofWork.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Concrete
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DepartmentService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Add(DepartmentToAddDTO departmentToAddDTO)
        {
          Department department=_mapper.Map<Department>(departmentToAddDTO);
          await _unitOfWork.departmentRepository.Add(department);
          await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int departmentId)
        {
           await _unitOfWork.departmentRepository.Delete(departmentId);
           await _unitOfWork.CommitAsync();
        }

        public async Task Update(DepartmentToUpdateDTO departmentToEditDTO)
        {
            Department department = _mapper.Map<Department>(departmentToEditDTO);
            await _unitOfWork.departmentRepository.Update(department);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<DepartmentToListDTO>> Get()
        {
            List<Department> departments = await _unitOfWork.departmentRepository.Get();
            return _mapper.Map<List<DepartmentToListDTO>>(departments);

        }

        public async Task<DepartmentToUpdateDTO> GetId(int departmentId)
        {
            Department department = await _unitOfWork.departmentRepository.GetId(departmentId);
            return _mapper.Map<DepartmentToUpdateDTO>(department);
        }
    }
}

