using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Entities
{
    public class Chart
    {
        [Key]
        public int Id { get; set; }
        public string proname { get; set; }
        public int count { get; set; }
    }
}
