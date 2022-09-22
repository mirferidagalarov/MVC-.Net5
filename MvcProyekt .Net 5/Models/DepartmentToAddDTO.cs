using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Models
{
    public class DepartmentToAddDTO
    {
        [Required(ErrorMessage = "Enter departmentname")]
        public string DepartmentName { get; set; }
    }
}
