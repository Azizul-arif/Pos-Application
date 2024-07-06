using Microsoft.AspNetCore.Mvc;

namespace PosApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
