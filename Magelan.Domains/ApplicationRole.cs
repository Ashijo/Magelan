using System;
using System.Collections.Generic;
using Magelan.Domains;
using Microsoft.AspNetCore.Identity;

namespace Magelan.Domains
{
    public class ApplicationRole : IdentityRole<Guid> // : BasicEntity
    {
        private MagelanRole magelanRole { get; set; }
    }
}
