using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixteenClothing.Contexts;
using SixteenClothing.ViewModels.ProductViewModels;

namespace SixteenClothing.Controllers
{
    public class HomeController(AppDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var data = await _context.Products.ToListAsync();
            List<ProductGetVM> vm = new List<ProductGetVM>();
            vm = data.Select(x => new ProductGetVM()
            {
                Description = x.Description,
                ImagePath = x.ImagePath,
                Price = x.Price,
                Rating = x.Rating,
                ReviewCount = x.ReviewCount,
                Title = x.Title
            }).ToList();
            return View(vm);
        }
    }
}
