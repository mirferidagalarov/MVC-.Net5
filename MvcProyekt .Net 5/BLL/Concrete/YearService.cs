using AutoMapper;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.Entities;
using MvcProyekt_.Net_5.Models;
using MvcProyekt_.Net_5.UnitofWork.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Concrete
{
    public class YearService : IYearService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public YearService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<YearToListDTO>> Get()
        {
            List<Years> years =await _unitOfWork.yearRepository.Get();
           return _mapper.Map<List<YearToListDTO>>(years);
        }
    }
}
