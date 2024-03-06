using Microsoft.AspNetCore.Mvc;

namespace KarmaShop.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Contact()
        {
            return View();
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        public async Task<IActionResult> ShopCategory()
        {
            return View();
        }
    }
}
