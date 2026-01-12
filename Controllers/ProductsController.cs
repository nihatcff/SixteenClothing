using Microsoft.AspNetCore.Mvc;

namespace SixteenClothing.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
