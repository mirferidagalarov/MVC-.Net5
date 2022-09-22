using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Models
{
    public class DepartmentToUpdateDTO
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Enter departmentname")]
        public string DepartmentName { get; set; }
    }
}
