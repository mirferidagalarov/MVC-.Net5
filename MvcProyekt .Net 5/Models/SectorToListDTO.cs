using MvcProyekt_.Net_5.Entities;
using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Models
{
    public class SectorToListDTO
    {
        public int SectorId { get; set; }
        [Required(ErrorMessage = "Enter sectorname")]
        public string SectorName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
