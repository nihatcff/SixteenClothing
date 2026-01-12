using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using SixteenClothing.Models.Common;

namespace SixteenClothing.Models
{
    public class Product : BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(512)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 5)]
        [Precision(3, 2)]
        public double Rating { get; set; } = 0;
        [Required]
        public string ImagePath { get; set; } = string.Empty;
        public int ReviewCount { get; set; }

    }
}
