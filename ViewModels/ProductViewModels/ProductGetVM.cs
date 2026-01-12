using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SixteenClothing.ViewModels.ProductViewModels
{
    public class ProductGetVM
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public double Rating { get; set; }
        public string ImagePath { get; set; } = string.Empty;
        public int ReviewCount { get; set; }
    }
}
