using Microsoft.AspNetCore.Mvc;

namespace KarmaShop.Controllers
{
    public class BlogController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> BlogDetails()
        {
            return View();
        }
    }
}
