using System.Collections.Generic;

namespace MvcProyekt_.Net_5.Models
{
    public class SalaryToAddDTO
    {
        public double Salary { get; set; }
        public List<EmployeeToListDTO> Employee { get; set; }
        public int EmployeeId { get; set; }
        public List<MonthToListDTO> Month { get; set; }
        public int MonthId { get; set; }
        public List<YearToListDTO> Year { get; set; }
        public int YearId { get; set; }
    }
}
