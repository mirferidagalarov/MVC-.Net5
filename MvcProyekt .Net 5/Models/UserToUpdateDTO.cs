using System.ComponentModel.DataAnnotations;

namespace MvcProyekt_.Net_5.Models
{
    public class UserToUpdateDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter confirmpassword")]
        public string ConfirmPassword { get; set; }
    }
}
