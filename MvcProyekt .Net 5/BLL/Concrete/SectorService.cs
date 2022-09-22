using AutoMapper;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.Entities;
using MvcProyekt_.Net_5.Models;
using MvcProyekt_.Net_5.UnitofWork.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.BLL.Concrete
{
    public class SectorService : ISectorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SectorService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork= unitOfWork;
            _mapper = mapper;
        }
        public async Task Add(SectorToAddDTO sectorToAddDTO)
        {
           Sector sector=_mapper.Map<Sector>(sectorToAddDTO);
            await _unitOfWork.sectorRepository.Add(sector);
            await _unitOfWork.CommitAsync();

        }

        public async Task Delete(int sectorId)
        {
           await _unitOfWork.sectorRepository.Delete(sectorId);
           await _unitOfWork.CommitAsync();
        }

        public async Task Update(SectorToUpdateDTO sectorToUpdateDTO)
        {
            Sector sector=_mapper.Map<Sector>(sectorToUpdateDTO);
            await _unitOfWork.sectorRepository.Update(sector);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<SectorToListDTO>> Get()
        {
            List<Sector> sectors = await _unitOfWork.sectorRepository.GetAll();
            return _mapper.Map<List<SectorToListDTO>>(sectors);
        }

        public async Task<SectorToUpdateDTO> GetId(int sectorId)
        {
            Sector sector =await _unitOfWork.sectorRepository.GetId(sectorId);
            return _mapper.Map<SectorToUpdateDTO>(sector);
        }
    }
}
