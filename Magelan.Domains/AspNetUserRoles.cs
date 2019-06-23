using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magelan.Domains
{
    public partial class AspNetUserRoles
    {
        
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetRoles Role { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
