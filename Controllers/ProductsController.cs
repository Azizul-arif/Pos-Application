using Microsoft.AspNetCore.Mvc;
using PosApplication.Models;
using PosApplication.ViewModel;

namespace PosApplication.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var product = ProductRepository.GetProducts(loadCategory:true);
            return View(product);
        }

        public IActionResult Add()
        {
            var productViewModel = new ProductViewModel
            {
                Categories = CategoriesRepository.GetCategories()
            };
            return View(productViewModel);

        }

        [HttpPost]
        public IActionResult Add(ProductViewModel productViewModel)
        {
            if(ModelState.IsValid)
            {
                ProductRepository.AddProduct(productViewModel.Product);
                return RedirectToAction("Index");
            }
            productViewModel.Categories = CategoriesRepository.GetCategories();
            return View(productViewModel);
            
        }
    }
}
