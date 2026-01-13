using Microsoft.AspNetCore.Identity;

namespace SixteenClothing.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
