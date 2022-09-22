using AutoMapper;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.Entities;
using MvcProyekt_.Net_5.Models;
using MvcProyekt_.Net_5.UnitofWork.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Concrete
{
    public class SalaryService : ISalaryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SalaryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(SalaryToAddDTO salaryToAddDTO)
        {
            Salarys salary = _mapper.Map<Salarys>(salaryToAddDTO);
            await _unitOfWork.salaryRepository.Add(salary);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int salaryId)
        {
           await _unitOfWork.salaryRepository.Delete(salaryId);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<SalaryToListDTO>> Get()
        {
            List<Salarys> salarys = await _unitOfWork.salaryRepository.GetAll();
            return _mapper.Map<List<SalaryToListDTO>>(salarys);
        }
    }
}
