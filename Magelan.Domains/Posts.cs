using System;
using System.Collections.Generic;
using Magelan.Domains;

namespace Magelan.Repositories
{
    public partial class Posts : BasicEntity
    {
        public string Id { get; set; }
        public DateTime Creation { get; set; }
        public bool Deleted { get; set; }
        public bool Archive { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
