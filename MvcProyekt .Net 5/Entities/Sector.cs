using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Entities
{
    public class Sector
    {
        [Key]
        public int SectorId { get; set; }
        public string SectorName { get; set; }
        public Department Department { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
