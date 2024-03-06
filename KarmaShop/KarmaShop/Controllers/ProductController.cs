using Microsoft.AspNetCore.Mvc;

namespace KarmaShop.Controllers
{
    public class ProductController : Controller
    {
        public async Task<IActionResult> Details()
        {
            return View();
        }
    }
}
