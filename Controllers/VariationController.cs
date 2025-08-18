using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class VariationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Variation variation)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(variation);
        }
    }
}
