using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixteenClothing.Contexts;
using SixteenClothing.ViewModels.ProductViewModels;
using System.Threading.Tasks;

namespace SixteenClothing.Areas.Admin.Controllers;
[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
