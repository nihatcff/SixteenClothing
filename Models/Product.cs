using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using SixteenClothing.Models.Common;

namespace SixteenClothing.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public double Rating { get; set; } = 0;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

    }
}
