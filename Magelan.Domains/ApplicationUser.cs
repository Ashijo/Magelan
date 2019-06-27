using System;
using System.Collections.Generic;
using Magelan.Domains;
using Microsoft.AspNetCore.Identity;

namespace Magelan.Domains
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public DateTime Creation { get; set; }
        public bool Deleted { get; set; }
        public bool Archive { get; set; }
    }
}
