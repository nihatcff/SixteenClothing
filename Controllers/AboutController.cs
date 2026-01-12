using Microsoft.AspNetCore.Mvc;

namespace SixteenClothing.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
