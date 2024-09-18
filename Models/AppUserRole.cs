using CloudIABackend.Models;
using Microsoft.AspNetCore.Identity;

namespace CloudIABackend.Models
{
    public class AppUserRole:IdentityUserRole<int>
    {
        public AppUser User { get; set; }
        public AppRole Roles { get; set; }
    }
}
