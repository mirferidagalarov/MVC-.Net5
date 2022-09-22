using MvcProyekt_.Net_5.Entities;

namespace MvcProyekt_.Net_5.Models
{
    public class SalaryToListDTO
    {
        public int SalaryId { get; set; }
        public double Salary { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public Month Month { get; set; }
        public int MonthId { get; set; }
        public Years Year { get; set; }
        public int YearsId { get; set; }
    }
}
