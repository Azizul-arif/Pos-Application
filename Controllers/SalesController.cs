using Microsoft.AspNetCore.Mvc;
using PosApplication.Models;
using PosApplication.ViewModel;

namespace PosApplication.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            var salesViewModel = new SalesViewModel
            {
                Categories = CategoriesRepository.GetCategories()
            };
            return View(salesViewModel);
        }
    }
}
