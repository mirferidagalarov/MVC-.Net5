using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Entities
{
    public class Month
    {
        [Key]
        public int MonthId { get; set; }
        public string MonthName { get; set; }
    }
}
