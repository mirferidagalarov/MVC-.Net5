using Microsoft.AspNetCore.Mvc;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.Entities;
using System.Linq;

namespace MvcProyekt_.Net_5.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataContext _dataContext;
        public LoginController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(User user)
        {

            var yoxla = _dataContext.Users.FirstOrDefault(m => m.Email == user.Email && m.Password == user.Password);
            if (yoxla == null)
            {
                if (!ModelState.IsValid)
                {
                }

                return View("Index");

            }
            return RedirectToAction("Index", "Dashboard");


        }
    }
}
