using Microsoft.AspNetCore.Mvc;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.Models;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUserService _userService;
        public RegisterController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CreatedUser(UserToAddDTO userToAddDTO)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            await _userService.Add(userToAddDTO);
            return RedirectToAction("Index", "Login");

        }
    }
}
