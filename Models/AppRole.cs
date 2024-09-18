using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using CloudIABackend.Models;

namespace CloudIABackend.Models
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
