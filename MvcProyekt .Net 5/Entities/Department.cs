using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Entities
{
    public class Department
    {

        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
