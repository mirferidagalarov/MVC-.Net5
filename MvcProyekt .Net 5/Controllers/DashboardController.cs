using Microsoft.AspNetCore.Mvc;

namespace MvcProyekt_.Net_5.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
