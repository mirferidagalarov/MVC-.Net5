using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Entities
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        public string PositionName { get; set; }
    }
}
