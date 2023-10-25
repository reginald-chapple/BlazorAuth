using Microsoft.AspNetCore.Identity;

namespace BlazorAuth.Server.Models
{
    public class ApplicationUser : IdentityUser<string>
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; } = new List<ApplicationUserRole>();
    }
}