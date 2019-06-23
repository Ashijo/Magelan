using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magelan.Domains
{
    public partial class AspNetUserTokens
    {
        
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
