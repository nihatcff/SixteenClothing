using System.ComponentModel.DataAnnotations;

namespace SixteenClothing.ViewModels.ProductViewModels
{
    public class ProductUpdateVM
    {
        public int Id { get; set; }
        [Required, MaxLength(256), MinLength(3)]
        public string Name { get; set; } = string.Empty;
        [Required, MaxLength(1024), MinLength(3)]
        public string Description { get; set; } = string.Empty;
        [Required, Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        [Required, Range(0, 5)]
        public double Rating { get; set; } = 0;
        [Required]
        public int CategoryId { get; set; }
        public IFormFile? Image { get; set; } 
    }

}
