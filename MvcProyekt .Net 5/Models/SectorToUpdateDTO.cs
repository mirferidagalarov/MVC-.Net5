using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Models
{
    public class SectorToUpdateDTO
    {
        public int SectorId { get; set; }
        [Required(ErrorMessage = "Enter sectorname")]
        public string SectorName { get; set; }
        public int DepartmentId { get; set; }
        public List<DepartmentToListDTO> Departments { get; set; }
    }
}
