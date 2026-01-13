using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixteenClothing.Contexts;
using SixteenClothing.ViewModels.ProductViewModels;
using System.Threading.Tasks;

namespace SixteenClothing.Areas.Admin.Controllers;
[Area("Admin")]
public class ProductController(AppDbContext _context) : Controller
{
    public async Task<IActionResult> Index()
    {
        var products = await _context.Products.Select(x=>new ProductGetVM()
        {
           Id = x.Id,
           Name = x.Name,
           Description = x.Description,
           ImagePath = x.ImagePath,
           CategoryName = x.Category.Name,
           Price = x.Price,
           Rating = x.Rating
        }).ToListAsync() ;
        return View(products);
    }
}
