using System;
using System.Collections.Generic;
using Magelan.Domains;
using Microsoft.AspNetCore.Identity;

namespace Magelan.Domains
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        private MagelanUser MagelanUser { get; set; }
    }
}
