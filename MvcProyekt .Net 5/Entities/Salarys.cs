using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MvcProyekt_.Net_5.Entities
{
    public class Salarys
    {
        [Key]
        public int SalaryId { get; set; }
        public double Salary { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Month Month { get; set; }
        [ForeignKey("Months")]
        public int MonthId { get; set; }
        public Years Year { get; set; }
        [ForeignKey("Years")]
        public int YearId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
