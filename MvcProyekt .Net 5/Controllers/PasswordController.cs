using Microsoft.AspNetCore.Mvc;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.Controllers
{
    public class PasswordController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IUserService _userService;
        public PasswordController(DataContext dataContext, IUserService userService)
        {
            _dataContext = dataContext;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PasswordUpdate(UserToUpdateDTO userToUpdateDTO)
        {

            var yoxla = _dataContext.Users.SingleOrDefault(m => m.Email == userToUpdateDTO.Email);
            if (yoxla != null)
            {
                if (userToUpdateDTO.Password == userToUpdateDTO.ConfirmPassword)
                {
                    yoxla.Password = userToUpdateDTO.Password;
                    await _userService.Update(yoxla);
                    return RedirectToAction("Index", "Login");
                }
            }
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            return View();

        }
    }
}
