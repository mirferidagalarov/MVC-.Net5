using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MvcProyekt_.Net_5.Entities
{
    public class ResponseLog
    {
        [Key]
        public int ResponseLogId { get; set; }
        public string TraceIdentifier { get; set; }
        public DateTime ResponseDate { get; set; }
        public string StatusCode { get; set; }
        public string Token { get; set; }
        public int? UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
