using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace MvcProyekt_.Net_5.Models
{
    public class EmployeeToUpdateDTO
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Enter EmployeeName")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Enter EmployeeSurname")]
        public string EmployeeSurname { get; set; }

        [Required(ErrorMessage = "Enter Salary")]
        public double Salary { get; set; }
        public DateTime DateofBirth { get; set; }
        public List<DepartmentToListDTO> Departments { get; set; }
        public int DepartmentId { get; set; }
        public List<SectorToListDTO> Sectors { get; set; }
        public int SectorId { get; set; }
        public List<PositionToListDTO> Positions { get; set; }
        public int PositionId { get; set; }
    }
}
