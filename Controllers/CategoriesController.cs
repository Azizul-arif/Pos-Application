using Microsoft.AspNetCore.Mvc;
using PosApplication.Models;

namespace PosApplication.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }

        public IActionResult Edit(int? id)
        {
            ViewBag.Action = "edit";
            var category = CategoriesRepository.GetCategoryById(id.HasValue ? id.Value : 0);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CategoriesRepository.UpdateCategory(category.CategoryId, category);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "create";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
           if(ModelState.IsValid)
            {
                try
                {
                    CategoriesRepository.AddCategory(category);
                    return RedirectToAction("Index");
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while adding the category.");
                }

            }
            return View(category);
        }

        public IActionResult Delete(int id)
        {
            CategoriesRepository.DeleteCategory(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
