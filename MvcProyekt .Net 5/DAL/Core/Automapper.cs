using AutoMapper;
using MvcProyekt_.Net_5.Entities;
using MvcProyekt_.Net_5.Models;
using System;

namespace MvcProyekt_.Net_5.DAL.Core
{
    public class Automapper:Profile
    {
        public Automapper()
        {
            CreateMap<User, UserToListDTO>();
            CreateMap<UserToAddDTO, User>();
            CreateMap<UserToUpdateDTO, User>();
            CreateMap<Department, DepartmentToListDTO>();
            CreateMap<DepartmentToAddDTO, Department>();
            CreateMap<DepartmentToUpdateDTO, Department>().ReverseMap(); 
            CreateMap<Sector, SectorToListDTO>();
            CreateMap<SectorToAddDTO, Sector>();
            CreateMap<SectorToUpdateDTO, Sector>().ReverseMap();
            CreateMap<Employee, EmployeeToListDTO>().ForMember(dest => dest.DateofBirth, opt => opt.MapFrom(src => src.DateofBirth.ToString("dd-MMM-yyyy")));
            CreateMap<EmployeeToAddDTO, Employee>().ForMember(dest => dest.DateofBirth, opt => opt.MapFrom(src => Convert.ToDateTime(src.DateofBirth.ToString("dd-MMM-yyyy"))));
            CreateMap<EmployeeToUpdateDTO, Employee>().ReverseMap().ForMember(dest => dest.DateofBirth, opt => opt.MapFrom(src => src.DateofBirth.ToString("dd-MMM-yyyy"))); 
            CreateMap<Position, PositionToListDTO>();
            CreateMap<Month, MonthToListDTO>();
            CreateMap<Years, YearToListDTO>();
            CreateMap<Salarys, SalaryToListDTO>();
            CreateMap<SalaryToAddDTO, Salarys>(); 



        }
    }
}
