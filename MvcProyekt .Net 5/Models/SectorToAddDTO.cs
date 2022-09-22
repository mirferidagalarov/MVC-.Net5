using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Models
{
    public class SectorToAddDTO
    {
        [Required(ErrorMessage = "Enter sectorname")]
        public string SectorName { get; set; }
        public int DepartmentId { get; set; }
        public List<DepartmentToListDTO> Departments { get; set; }
    }
}
