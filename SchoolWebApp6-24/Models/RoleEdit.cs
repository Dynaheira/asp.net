﻿using Microsoft.AspNetCore.Identity;

namespace SchoolWebApp6_24.Models {
    public class RoleEdit {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUser> RoleMembers { get; set; }
        public IEnumerable<AppUser> RoleNonMembers { get; set; }
    }
}
