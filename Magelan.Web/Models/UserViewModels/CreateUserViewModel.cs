using System;
using System.Collections.Generic;
using Magelan.Domains;
using Magelan.Repositories;

namespace Magelan.Web.Models.UserViewModels {
    public class CreateUserViewModel {
        
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public bool LockoutEnabled { get; set; }

        public virtual ICollection<AspNetUserRoles>      AspNetUserRoles { get; set; }
    }
}