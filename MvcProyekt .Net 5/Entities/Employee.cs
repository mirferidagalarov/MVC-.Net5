using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MvcProyekt_.Net_5.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string ImagePath { get; set; }
        public double Salary { get; set; }
        public DateTime DateofBirth { get; set; }
        public Department Department { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Sector Sector { get; set; }
        [ForeignKey("Sector")]
        public int SectorId { get; set; }
        public Position Position { get; set; }
        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
