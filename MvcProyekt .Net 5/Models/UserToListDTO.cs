using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Models
{
    public class UserToListDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "The email you've entered is incorrect")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The password you've entered is incorrect")]
        public string Password { get; set; }
    }
}
