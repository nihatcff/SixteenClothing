using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixteenClothing.Contexts;
using System.Threading.Tasks;

namespace SixteenClothing.Areas.Admin.Controllers;
[Area("Admin")]
public class DashboardController(AppDbContext _context) : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Test()
    {
        return View();
    }

    public async Task<IActionResult> Create()
    {   
        var categories = await _context.Categories.ToListAsync();
        ViewBag.Categories = categories;
        return View();
    }
}
