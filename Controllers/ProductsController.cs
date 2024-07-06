using Microsoft.AspNetCore.Mvc;
using PosApplication.Models;

namespace PosApplication.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var product = ProductRepository.GetProducts(loadCategory:true);
            return View(product);
        }
    }
}
