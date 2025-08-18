using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class DiscountController : Controller
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
        public IActionResult Create(Discount discount)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(discount);
        }
    }
}
