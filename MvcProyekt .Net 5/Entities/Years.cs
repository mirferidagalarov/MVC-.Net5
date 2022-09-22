using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Entities
{
    public class Years
    {
        [Key]
        public int YearId { get; set; }
        public int Year { get; set; }
    }
}
