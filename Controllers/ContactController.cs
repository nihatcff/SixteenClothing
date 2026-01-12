using Microsoft.AspNetCore.Mvc;

namespace SixteenClothing.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
