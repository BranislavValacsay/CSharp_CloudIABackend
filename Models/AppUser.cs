using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CloudIABackend.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string GiveName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PositionName { get; set; }
        public bool isActive { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
