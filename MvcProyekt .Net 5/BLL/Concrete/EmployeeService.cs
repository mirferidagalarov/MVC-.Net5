using AutoMapper;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.Entities;
using MvcProyekt_.Net_5.Models;
using MvcProyekt_.Net_5.UnitofWork.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task Add(EmployeeToAddDTO employeeToAddDTO,string filename)
        {
            Employee employee = _mapper.Map<Employee>(employeeToAddDTO);
            employee.ImagePath = filename;
            await _unitOfWork.employeeRepository.Add(employee);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int sectorId)
        {
            await _unitOfWork.employeeRepository.Delete(sectorId);
            await _unitOfWork.CommitAsync();
        }

        public async Task Update(EmployeeToUpdateDTO employeeToUpdateDTO)
        {
            Employee employee = _mapper.Map<Employee>(employeeToUpdateDTO);
            await _unitOfWork.employeeRepository.Update(employee);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<EmployeeToListDTO>> Get()
        {
            List<Employee> employees = await _unitOfWork.employeeRepository.GetAll();
            return _mapper.Map<List<EmployeeToListDTO>>(employees);
        }

        public async Task<EmployeeToUpdateDTO> GetId(int employeeId)
        {
            Employee employee = await _unitOfWork.employeeRepository.GetId(employeeId);
            return _mapper.Map<EmployeeToUpdateDTO>(employee);
        }
    }
}
