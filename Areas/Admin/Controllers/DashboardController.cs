using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers.Admin
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
