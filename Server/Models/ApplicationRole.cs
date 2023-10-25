#nullable disable
using Microsoft.AspNetCore.Identity;

namespace BlazorAuth.Server.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
